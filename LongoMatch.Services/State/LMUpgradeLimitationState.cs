﻿//
//  Copyright (C) 2017 Fluendo S.A.
using System;
using LongoMatch.Core;
using VAS.Core.Common;
using VAS.Core.MVVMC;
using VAS.Core.ViewModel;
using VAS.Services.State;
using VAS.Services.ViewModel;
using LMConstants = LongoMatch.Core.Common.Constants;

namespace LongoMatch.Services.State
{
	/// <summary>
	/// LongoMatch ugrade limitation state. Used to configure the
	/// UpgradeLimitationVM with the corresponding LongoMatch requirements.
	/// </summary>
	public class LMUpgradeLimitationState : UpgradeLimitationState
	{
		protected override void CreateViewModel (dynamic data)
		{
			ViewModel = new UpgradeLimitationVM ();
			LimitationVM limitation = (LimitationVM)data.limitationVM;
			if (limitation is FeatureLimitationVM) {
				ViewModel.Header = $"{Catalog.GetString ("The")} {((FeatureLimitationVM)limitation).FeatureName} " +
					$"{Catalog.GetString ("is not available in the")} {App.Current.LicenseManager.LicenseStatus.PlanName} " +
					$"{Catalog.GetString ("plan")}";
			} else if (limitation is CountLimitationVM) {
				ViewModel.Header = Catalog.GetString ("You have reached the limit of") +
					$" {((CountLimitationVM)limitation).RegisterName} available for your plan";
			} else {
				ViewModel.Header = Catalog.GetString ("Unlock your team's potential with LongoMatch PRO");
			}
			if (limitation != null) {
				ViewModel.FeaturesHeader = Catalog.GetString ("Upgrade to LongoMatch PRO and unlock your team's potential");
			} else {
				ViewModel.FeaturesHeader = Catalog.GetString ("Upgrade to get access to the following features");
			}
			//FIXME: still undecided Features
			ViewModel.Features = new RangeObservableCollection<string> {
				Catalog.GetString("Unlimited projects"),
				Catalog.GetString("Another awesome thing"),
				Catalog.GetString("Some other cool thing"),
				Catalog.GetString("Some more features")
			};
			ViewModel.FeaturesCaption = Catalog.GetString ("... and much more");
			//FIXME: still undecided UpgradeURL
			ViewModel.UpgradeCommand = new Command (() => {
				Utils.OpenURL (LMConstants.UPGRADE_URL, $"Limitation_{limitation.RegisterName.Replace (" ", string.Empty)}");
			});
			ViewModel.UpgradeCommand.Text = Catalog.GetString ("UPGRADE TO PRO");
			ViewModel.Undecided = Catalog.GetString ("Still undecided?");
			//FIXME: still undecided OtherPlansURL
			ViewModel.OtherPlansURL = LMConstants.OTHER_PLANS_URL;
		}
	}
}
