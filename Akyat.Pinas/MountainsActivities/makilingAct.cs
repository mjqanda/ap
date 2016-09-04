using Akyat.Pinas.ORM;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using System;
namespace Akyat.Pinas.MountainsActivities
{
    [Activity(Theme = "@style/Theme.NoTitle", Label = "makilingAct")]
    public class makilingAct : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.makilingLayout);

            //create database and table
            Button btnItinerary = FindViewById<Button>(Resource.Id.btnItinerary);
            btnItinerary.Click += ((sender, e) =>
            {
                DBItineraryRepository dbr = new DBItineraryRepository();
                var result = dbr.CreateDB();
                Toast.MakeText(this, result, ToastLength.Short).Show();

              
                
                    var intent = new Intent(this, typeof(itineraryAct));
                intent.PutExtra("name", "Makiling");
                    StartActivity(intent);
                
            });
            // Create your application here

        }

      
    }
}