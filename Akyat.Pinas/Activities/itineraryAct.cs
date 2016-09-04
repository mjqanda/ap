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
using Akyat.Pinas.Activities;

namespace Akyat.Pinas.ORM
{
    [Activity(Theme = "@style/Theme.NoTitle", Label = "Activity1")]
    public class itineraryAct : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.itineraryLayout);
            // Create your application here

            string name = Intent.GetStringExtra("name");
            Button btnAddIti = FindViewById<Button>(Resource.Id.btnAddIti);
            btnAddIti.Click += ((sender, e) =>
            {
                DBItineraryRepository dbr = new DBItineraryRepository();
                var resultTable = dbr.CreateTable();
                Toast.MakeText(this, resultTable, ToastLength.Short).Show();

                var intent = new Intent(this, typeof(addItineraryAct));
                intent.PutExtra("name", name);
                StartActivity(intent);
            });


        }
    }
}