//
//  Copyright (C) 2017 Fluendo S.A.
using System.Linq;
using LongoMatch.Core;
using LongoMatch.Core.Common;
using LongoMatch.Core.Store;
using LongoMatch.Core.Store.Templates;
using LongoMatch.License;
using VAS.Core.Events;
using VAS.Core.License;
using VAS.Core.MVVMC;
using VAS.Core.Store.Templates;
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
			App.Current.EventsBroker.Subscribe<StorageAddedEvent<Team>> (HandleTeamCreated);
			App.Current.EventsBroker.Subscribe<StorageDeletedEvent<Team>> (HandleTeamDeleted);
			App.Current.EventsBroker.Subscribe<StorageAddedEvent<Dashboard>> (HandleDashboardCreated);
			App.Current.EventsBroker.Subscribe<StorageDeletedEvent<Dashboard>> (HandleDashboardDeleted);

			UpdateLicenseLimitationsCounters ();

			return base.Start ();
		}

		public override bool Stop ()
		{
			App.Current.EventsBroker.Unsubscribe<StorageAddedEvent<LMProject>> (HandleProjectCreated);
			App.Current.EventsBroker.Unsubscribe<StorageDeletedEvent<LMProject>> (HandleProjectDeleted);
			App.Current.EventsBroker.Unsubscribe<StorageAddedEvent<Team>> (HandleTeamCreated);
			App.Current.EventsBroker.Unsubscribe<StorageDeletedEvent<Team>> (HandleTeamDeleted);
			App.Current.EventsBroker.Unsubscribe<StorageAddedEvent<Dashboard>> (HandleDashboardCreated);
			App.Current.EventsBroker.Unsubscribe<StorageDeletedEvent<Dashboard>> (HandleDashboardDeleted);

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

			count = App.Current.TeamTemplatesProvider.Templates.OfType<LMTeam> ().Count ();
			// Exclude the 2 static teams
			Get<CountLimitationVM> (LongoMatchCountLimitedObjects.Team.ToString ()).Count = count - 2;

			count = App.Current.CategoriesTemplatesProvider.Templates.OfType<LMDashboard> ().Count ();
			// Exclude the system dashboard
			Get<CountLimitationVM> (LongoMatchCountLimitedObjects.Dashboard.ToString ()).Count = count - 1;
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
			Add (new CountLicenseLimitation {
				RegisterName = LongoMatchCountLimitedObjects.Team.ToString (),
				Enabled = true,
				Maximum = 2
			}, new Command (() => Utils.OpenURL (Constants.WEBSITE, "Limitation_Teams")));
			Add (new CountLicenseLimitation {
				RegisterName = LongoMatchCountLimitedObjects.Dashboard.ToString (),
				Enabled = true,
				Maximum = 1
			}, new Command (() => Utils.OpenURL (Constants.WEBSITE, "Limitation_Dashboards")));
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

		void HandleTeamCreated (StorageAddedEvent<Team> obj)
		{
			var limit = Get<CountLimitationVM> (LongoMatchCountLimitedObjects.Team.ToString ());
			limit.Count++;
		}

		void HandleTeamDeleted (StorageDeletedEvent<Team> obj)
		{
			var limit = Get<CountLimitationVM> (LongoMatchCountLimitedObjects.Team.ToString ());
			limit.Count--;
		}

		void HandleDashboardCreated (StorageAddedEvent<Dashboard> obj)
		{
			var limit = Get<CountLimitationVM> (LongoMatchCountLimitedObjects.Dashboard.ToString ());
			limit.Count++;
		}

		void HandleDashboardDeleted (StorageDeletedEvent<Dashboard> obj)
		{
			var limit = Get<CountLimitationVM> (LongoMatchCountLimitedObjects.Dashboard.ToString ());
			limit.Count--;
		}
	}
}
