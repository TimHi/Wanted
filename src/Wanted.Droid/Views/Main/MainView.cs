using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;
using Wanted.Core.ViewModels.Main;

namespace Wanted.Droid.Views.Main
{
    [MvxActivityPresentation]
    [Activity(Label = "Main View",
     Theme = "@style/AppTheme",
     LaunchMode = LaunchMode.SingleTop,
     Name = "wanted.droid.views.mainView"
     )]
    public class MainView : MvxActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);


            //SetContentView(Resource.Layout.layout_main_view);
        }
    }
}
