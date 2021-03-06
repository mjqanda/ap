﻿using Akyat.Pinas.ORM;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace Akyat.Pinas.Activities
{
    [Activity( Theme = "@style/Theme.NoTitle", Label="AP")]
    public class MainMenuAct : Activity
    {
        //Our Main Menu Activity
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            RequestWindowFeature(WindowFeatures.NoTitle);
         
            SetContentView(Resource.Layout.mainMenuLayout);

            DBItineraryRepository dbr = new DBItineraryRepository();
            var result = dbr.CreateDB();

            Button btnMountainList = FindViewById<Button>(Resource.Id.btnMountainList);
            Button btnThingsToBring = FindViewById<Button>(Resource.Id.btnThingsToBring);
            Button btnNoTrace = FindViewById<Button>(Resource.Id.btnLeaveNoTrace);
            Button btnMountainMap = FindViewById<Button>(Resource.Id.btnMountainMap);
            Button btnSettings = FindViewById<Button>(Resource.Id.btnSetting);
          

            btnMountainList.Click += (sender, e) =>
            {
                const string message ="Data Fetching, Please wait.";
                var intent = new Intent(this, typeof(MountainListAct));
                Toast.MakeText(this, message, ToastLength.Short).Show();

                StartActivity(intent);
                OverridePendingTransition(Resource.Animation.slide_right, Resource.Animation.fade_out);
                Finish();
            };

            btnThingsToBring.Click += (sender, e) =>
            {
                var resultTable = dbr.CreateTableChecklist();
                var resultTableIti = dbr.CreateTable();
                var intent = new Intent(this, typeof(ItiAndTtbActivity));
                StartActivity(intent);
                OverridePendingTransition(Resource.Animation.slide_right, Resource.Animation.fade_out);
            };

            btnNoTrace.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(EssentialsAct));
                StartActivity(intent);
                OverridePendingTransition(Resource.Animation.slide_right, Resource.Animation.fade_out);

            };

            btnMountainMap.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(MountainMapAct));
                StartActivity(intent);
                OverridePendingTransition(Resource.Animation.fade_in, Resource.Animation.fade_out);
                Finish();
            };

            btnSettings.Click += (sender, e) =>
            {
                var resultTable = dbr.CreateTableSettings();
                var intent = new Intent(this, typeof(SettingsAct));
                StartActivity(intent);
                OverridePendingTransition(Resource.Animation.fade_in, Resource.Animation.fade_out);
            };
        }
     
        public override void OnBackPressed()
        {
            this.Finish();
        }
        
    }
}

