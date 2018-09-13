﻿using Foundation;
using UIKit;

namespace FinancialChartExample.iOS {
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options) {
            global::Xamarin.Forms.Forms.Init();
            DevExpress.XF.Charts.iOS.ChartViewRenderer renderer = new DevExpress.XF.Charts.iOS.ChartViewRenderer();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
