using Akyat.Pinas.ORM;
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

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            RequestWindowFeature(WindowFeatures.NoTitle);
         
            SetContentView(Resource.Layout.mainMenuLayout);
            //view.playSoundEffect(SoundEffectConstants.CLICK);

            DBItineraryRepository dbr = new DBItineraryRepository();
            var result = dbr.CreateDB();


            Button btnMountainList = FindViewById<Button>(Resource.Id.btnMountainList);
            Button btnThingsToBring = FindViewById<Button>(Resource.Id.btnThingsToBring);
            Button btnNoTrace = FindViewById<Button>(Resource.Id.btnLeaveNoTrace);
            Button btnMountainMap = FindViewById<Button>(Resource.Id.btnMountainMap);
            Button btnSettings = FindViewById<Button>(Resource.Id.btnSetting);
          

            btnMountainList.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof (MountainListAct));
                StartActivity(intent);
            };

            btnThingsToBring.Click += (sender, e) =>
            {
               
                var resultTable = dbr.CreateTableChecklist();

                Toast.MakeText(this, result + resultTable, ToastLength.Short).Show();
                var intent = new Intent(this, typeof(MainT2B));
                StartActivity(intent);
            };

            
            btnNoTrace.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(LeaveNoTraceAct));
                StartActivity(intent);
            };

            btnMountainMap.Click += (sender, e) =>
            {
                var i = new Intent(this, typeof(MountainMapAct));
                StartActivity(i);
            };


            btnSettings.Click += (sender, e) =>
            {
                
                var resultTable = dbr.CreateTableSettings();
                Toast.MakeText(this, result + resultTable, ToastLength.Short).Show();
                var intent = new Intent(this, typeof(SettingsAct));
                StartActivity(intent);
            };


        }
    }
}

