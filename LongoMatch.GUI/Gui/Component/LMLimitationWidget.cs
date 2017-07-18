//
//  Copyright (C) 2017 Fluendo S.A.
using System;
using System.ComponentModel;
using VAS.Core.Common;
using VAS.Core.MVVMC;
using VAS.Core.ViewModel;
using VAS.Core.ViewModel.Statistics;
using VAS.Drawing;
using VAS.Drawing.Cairo;
using VAS.Drawing.CanvasObjects.Statistics;
using VAS.UI.Helpers.Bindings;

namespace LongoMatch.Gui.Component
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class LMLimitationWidget : Gtk.Bin
	{
		LicenseLimitationVM viewModel;
		BindingContext ctx;
		BarChartView barView;
		Canvas barCanvas;

		public LMLimitationWidget ()
		{
			this.Build ();
			barCanvas = new Canvas (new WidgetWrapper (barDrawingArea));
			barView = new BarChartView ();
			barCanvas.AddObject (barView);
			SetBarViewModel ();

			button1.Clicked += (sender, e) => {
				barView.ViewModel.Series.ViewModels [0].Elements--;
				barView.ViewModel.Series.ViewModels [1].Elements++;
				barView.ReDraw ();
			};
		}

		/// <summary>
		/// Gets or sets the view model.
		/// </summary>
		/// <value>The view model.</value>
		public LicenseLimitationVM ViewModel {
			get {
				return viewModel;
			}

			set {
				if (viewModel != null) {
					viewModel.PropertyChanged -= HandlePropertyChangedEventHandler;
				}
				viewModel = value;
				ctx.UpdateViewModel (viewModel);
				if (viewModel != null) {
					viewModel.PropertyChanged += HandlePropertyChangedEventHandler;
					viewModel.Sync ();
				}
			}
		}

		void Bind ()
		{
			ctx = this.GetBindingContext ();
			//ctx.Add (button1.Bind (vm => ((LicenseLimitationVM)vm).UpgradeCommand));
			ctx.Add (countLabel.Bind (vm => ((LicenseLimitationVM)vm).Count, new Int32Converter ()));
		}

		void HandlePropertyChangedEventHandler (object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == nameof (ViewModel.Count)) {
				SetBarViewModel ();
			}
		}

		void SetBarViewModel ()
		{
			barView.SetViewModel (new BarChartVM {
				Height = 10,
				Series = new SeriesCollectionVM {
					ViewModels = {
						new SeriesVM("Remaining", 2, VAS.Core.Common.Color.Green),
						//viewModel.Maximum - viewModel.Count
						new SeriesVM("Current", 1, VAS.Core.Common.Color.Red)
						//viewModel.Count
					}
				}
			});
		}
	}
}
