using Android.App;
using Android.OS;
using Android.Widget;
using Plugin.LocalNotifications;
using System;

namespace AndroidApp
{
    [Activity(Label = "AndroidApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
            
            var testNotifierButton = FindViewById<Button>(Resource.Id.TestNotifierButton);

            testNotifierButton.Click += delegate
            {
                CrossLocalNotifications.Current.Show("Test", "This is a test notification",0);
                CrossLocalNotifications.Current.Show("Test", "This is a test notification" + System.Environment.NewLine
                                                            + "with a summary",1);
                CrossLocalNotifications.Current.Show("Test", "This is a test notification"+ System.Environment.NewLine
                                                            + "that has multiple lines"+ System.Environment.NewLine
                                                            + "and so on ..." + System.Environment.NewLine
                                                            + "with a summary",2);
                CrossLocalNotifications.Current.Show("Test", "This is a test notification from the future.", 3, DateTime.Now.AddSeconds(10));
            };

            var testAppLookupButton = FindViewById<Button>(Resource.Id.TestAppLookupButton);
        }
    }
}

