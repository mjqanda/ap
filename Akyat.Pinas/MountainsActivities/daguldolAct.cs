using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Akyat.Pinas.ORM;

namespace Akyat.Pinas.MountainsActivities
{
    [Activity(Theme = "@style/Theme.NoTitle", Label = "daguldolAct")]
    public class daguldolAct : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.daguldolLayout);
            // Create your application here
            Button btnItinerary = FindViewById<Button>(Resource.Id.btnItinerary);
            btnItinerary.Click += ((sender, e) =>
            {
                DBItineraryRepository dbr = new DBItineraryRepository();
                var result = dbr.CreateDB();
                Toast.MakeText(this, result, ToastLength.Short).Show();



                var intent = new Intent(this, typeof(itineraryAct));
                intent.PutExtra("name", "Daguldol");
                StartActivity(intent);

            });
        }
    }
}