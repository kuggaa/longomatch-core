//
//  Copyright (C) 2017 Fluendo S.A.
using System;
using System.ComponentModel;
using VAS.Core.Common;
using VAS.Core.Interfaces.MVVMC;
using VAS.Core.MVVMC;
using VAS.Core.ViewModel;
using VAS.Core.ViewModel.Statistics;
using VAS.Drawing;
using VAS.Drawing.Cairo;
using VAS.Drawing.CanvasObjects.Blackboard;
using VAS.Drawing.CanvasObjects.Statistics;
using VAS.UI.Helpers;
using VAS.UI.Helpers.Bindings;

namespace LongoMatch.Gui.Component
{
	/// <summary>
	/// LongoMatch widget for count limitations.
	/// It shows a "progress bar" with the number of remaining/current elements limited.
	/// </summary>
	[System.ComponentModel.ToolboxItem (true)]
	public partial class LMLimitationWidget : Gtk.Bin, IView<CountLimitationVM>
	{
		CountLimitationVM viewModel;
		BindingContext ctx;
		BarChartView barView;
		Canvas barCanvas;

		public LMLimitationWidget ()
		{
			this.Build ();
			// FIXME: This color is bg_dark_color from gtkrc, it should be set in the color scheme, styleconf, whatever...
			backgroundBox.ModifyBg (Gtk.StateType.Normal, Misc.ToGdkColor (Color.Parse ("#151a20")));
			barCanvas = new Canvas (new WidgetWrapper (barDrawingArea));
			barView = new BarChartView ();
			barCanvas.AddObject (barView);

			upgradeButton.ApplyStyleNormal ();

			Bind ();

			//upgradeButton.Clicked += (sender, e) => {
			//	barView.ViewModel.Series.ViewModels [0].Elements--;
			//	barView.ViewModel.Series.ViewModels [1].Elements++;
			//	barView.ReDraw ();
			//};
		}

		public override void Dispose ()
		{
			Dispose (true);
			base.Dispose ();
		}

		protected virtual void Dispose (bool disposing)
		{
			if (Disposed) {
				return;
			}
			if (disposing) {
				Destroy ();
			}
			Disposed = true;
		}

		protected override void OnDestroyed ()
		{
			Log.Verbose ($"Destroying {GetType ()}");
			ctx?.Dispose ();
			ctx = null;
			ViewModel = null;

			base.OnDestroyed ();

			Disposed = true;
		}

		protected bool Disposed { get; private set; } = false;

		/// <summary>
		/// Gets or sets the view model.
		/// </summary>
		/// <value>The view model.</value>
		public CountLimitationVM ViewModel {
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

		public void SetViewModel (object viewModel)
		{
			ViewModel = (CountLimitationVM)viewModel;
		}

		void Bind ()
		{
			ctx = this.GetBindingContext ();
			ctx.Add (upgradeButton.Bind (vm => ((CountLimitationVM)vm).UpgradeCommand));
			ctx.Add (countLabel.Bind (vm => ((CountLimitationVM)vm).Count, new Int32Converter ()));
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
						new SeriesVM("Remaining", ViewModel.Maximum - ViewModel.Count, Color.Green1),
						new SeriesVM("Current", ViewModel.Count, Color.Transparent)
					}
				},
				Background = new ImageCanvasObject {
					Image = App.Current.ResourcesLocator.LoadImage ("/Users/vguzman/Desktop/gradient_bg.png"),
					Mode = ScaleMode.Fill
				}
			});
		}
	}
}
