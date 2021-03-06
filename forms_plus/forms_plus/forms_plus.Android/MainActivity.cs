﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content.Res;

using Android.Support.Design.Widget;
using forms_plus;
using forms_plus.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android.AppCompat;

//[assembly: ExportRenderer(typeof(TabbedPage), typeof(forms_plus.Droid.MainActivity.RankingPageRenderer))]
namespace forms_plus.Droid
{
    [Activity(Label = "더하기", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation =ScreenOrientation.Portrait)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public override Resources Resources
        {
            get
            {
                Resources res = base.Resources;
                Configuration config = new Configuration();
                config.SetToDefaults();
                res.UpdateConfiguration(config, res.DisplayMetrics);
                return res;
            }
        }
#if false
        public class RankingPageRenderer : TabbedPageRenderer
        {
            public override void OnViewAdded(Android.Views.View child)
            {
                base.OnViewAdded(child);
                var tabLayout = child as TabLayout;
                if (tabLayout != null)
                {
                    tabLayout.TabMode = TabLayout.ModeScrollable;
                }
            }

        }
#endif

    }
}