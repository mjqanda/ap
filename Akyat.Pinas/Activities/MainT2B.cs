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
    [Activity(Theme = "@style/Theme.NoTitle",Label = "MainT2B")]
    public class MainT2B : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MainT2BLayout);
            // Create your application here


            DBItineraryRepository dbr = new DBItineraryRepository();
            TextView txtList = FindViewById<TextView>(Resource.Id.txtList);
           string output = "";

            try
            {
               string result = dbr.GetRecordPapel();
                output = result;
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.Message, ToastLength.Short).Show();
            }

            txtList.Text = output;

            ImageButton add = FindViewById<ImageButton>(Resource.Id.imageButtonAdd);
            add.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(ThingsToBringAct));
                StartActivity(intent);
            };


        }
    }
}