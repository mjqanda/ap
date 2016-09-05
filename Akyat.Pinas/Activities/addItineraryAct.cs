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

namespace Akyat.Pinas.Activities
{
    [Activity(Theme = "@style/Theme.NoTitle", Label = "addItineraryAct")]
    public class addItineraryAct : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.AddItiLayout);
            // Create your application here
            string name = Intent.GetStringExtra("name");


            Button btnAdd = FindViewById<Button>(Resource.Id.btnAdd);
            btnAdd.Click += ((sender, e) =>
            {
                EditText txtItinerary = FindViewById<EditText>(Resource.Id.txtItinerary);
                DBItineraryRepository dbr = new DBItineraryRepository();

                string result = dbr.InsertRecord(txtItinerary.Text);
                Toast.MakeText(this, result, ToastLength.Short).Show();
            });

        }
    }
}