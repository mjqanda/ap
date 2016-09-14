using Akyat.Pinas.ORM;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;


namespace Akyat.Pinas.Activities
{
    [Activity(Label = "Akyat.Pinas", Theme = "@style/Theme.NoTitle" ,Icon = "@drawable/Icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            RequestWindowFeature(WindowFeatures.NoTitle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button btnMountainList = FindViewById<Button>(Resource.Id.btnMountainList);
            Button btnThingsToBring = FindViewById<Button>(Resource.Id.btnThingsToBring);
            Button btnNoTrace = FindViewById<Button>(Resource.Id.btnLeaveNoTrace);
            Button btnMountainMap = FindViewById<Button>(Resource.Id.btnMountainMap);
            Button btnSettings = FindViewById<Button>(Resource.Id.btnSettings);

            btnMountainList.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof (MountainListsAct));
                StartActivity(intent);
            };

            btnThingsToBring.Click += (sender, e) =>
            {
                DBItineraryRepository dbr = new DBItineraryRepository();
                var result = dbr.CreateDBChecklist();
              var resultTable = dbr.CreateTableChecklist();

                Toast.MakeText(this, result + resultTable, ToastLength.Short).Show();
                var intent = new Intent(this, typeof(T2BAct));
                StartActivity(intent);
            };



            btnNoTrace.Click += (sender, e) =>

            {
                var intent = new Intent(this, typeof(LeaveNoTraceAct));
                StartActivity(intent);
            };
            btnMountainMap.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(mountainMapAct));
                StartActivity(intent);
            };

        }
    }
}

