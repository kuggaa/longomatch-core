//
//  Copyright (C) 2017 Fluendo S.A.
using System.Diagnostics;
using System.Linq;
using LongoMatch.Core;
using LongoMatch.Core.Common;
using LongoMatch.Core.Store;
using LongoMatch.License;
using VAS.Core.Events;
using VAS.Core.License;
using VAS.Core.MVVMC;
using VAS.Core.ViewModel;
using VAS.Services;
using Utils = VAS.Core.Common.Utils;

namespace LongoMatch.Services
{
	/// <summary>
	/// LongoMatch license limitation service, used to Initialize the limitations
	/// and update the limitations when a license is changed.
	/// </summary>
	public class LMLicenseLimitationsService : LicenseLimitationsService
	{
		public LMLicenseLimitationsService ()
		{
			CreateLimitations ();
		}

		public override bool Start ()
		{
			App.Current.EventsBroker.Subscribe<StorageAddedEvent<LMProject>> (HandleProjectCreated);
			App.Current.EventsBroker.Subscribe<StorageDeletedEvent<LMProject>> (HandleProjectDeleted);
			UpdateLicenseLimitationsCounters ();
			return base.Start ();
		}

		public override bool Stop ()
		{
			App.Current.EventsBroker.Unsubscribe<StorageAddedEvent<LMProject>> (HandleProjectCreated);
			App.Current.EventsBroker.Unsubscribe<StorageDeletedEvent<LMProject>> (HandleProjectDeleted);
			return base.Stop ();
		}

		protected override void UpdateFeatureLimitations ()
		{
			LMLicenseStatus status = (LMLicenseStatus)App.Current.LicenseManager.LicenseStatus;

			string databaseLimitation = LongoMatchFeature.DatabaseManager.ToString ();
			var databaseManagerFeature = Get<FeatureLimitationVM> (databaseLimitation);
			databaseManagerFeature.Model.Enabled = status.Limitations.Contains (databaseLimitation);

			string conversionLimitation = LongoMatchFeature.VideoConverter.ToString ();
			var converterFeature = Get<FeatureLimitationVM> (conversionLimitation);
			converterFeature.Model.Enabled = status.Limitations.Contains (conversionLimitation);
		}

		void UpdateLicenseLimitationsCounters ()
		{
			int count = App.Current.DatabaseManager.ActiveDB.Count<LMProject> ();
			Get<CountLimitationVM> ("Projects").Count = count;
		}

		void CreateLimitations ()
		{
			LMLicenseStatus status = (LMLicenseStatus)App.Current.LicenseManager.LicenseStatus;

			Add (new FeatureLicenseLimitation {
				RegisterName = LongoMatchFeature.DatabaseManager.ToString (),
				Enabled = status.Limitations.Contains (LongoMatchFeature.DatabaseManager.ToString ()),
				FeatureName = Catalog.GetString ("Database Manager")
			});
			Add (new FeatureLicenseLimitation {
				RegisterName = LongoMatchFeature.VideoConverter.ToString (),
				Enabled = status.Limitations.Contains (LongoMatchFeature.VideoConverter.ToString ()),
				FeatureName = Catalog.GetString ("Video Converter")
			});
			Add (new CountLicenseLimitation {
				RegisterName = "Projects",
				Enabled = true,
				Maximum = 3,
			}, new Command (() => Utils.OpenURL (Constants.WEBSITE, "Limitation_Projects")));
		}

		void HandleProjectCreated (StorageAddedEvent<LMProject> obj)
		{
			var limit = Get<CountLimitationVM> ("Projects");
			limit.Count++;
		}

		void HandleProjectDeleted (StorageDeletedEvent<LMProject> obj)
		{
			var limit = Get<CountLimitationVM> ("Projects");
			limit.Count--;
		}
	}
}
