using Akyat.Pinas.ORM;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace Akyat.Pinas.MountainsActivities
{
    [Activity(Theme = "@style/Theme.NoTitle", Label = "cristobalAct")]
    public class cristobalAct : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.cristobalLayout);
            // Create your application here

            Button btnItinerary = FindViewById<Button>(Resource.Id.btnItinerary);
            btnItinerary.Click += ((sender, e) =>
            {
                DBItineraryRepository dbr = new DBItineraryRepository();
                var result = dbr.CreateDB();
                Toast.MakeText(this, result, ToastLength.Short).Show();



                var intent = new Intent(this, typeof(itineraryAct));
                intent.PutExtra("name", "Cristobal");
                StartActivity(intent);

            });
        }
    }
}