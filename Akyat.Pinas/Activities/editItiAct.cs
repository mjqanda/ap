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
    [Activity(Theme = "@style/Theme.NoTitle", Label = "editItiAct")]
    public class EditItiAct : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.editItiLayout);
            // Create your application here

            string name = Intent.GetStringExtra("name");

            string editThis = Intent.GetStringExtra("editThis");

            EditText editItinerary = FindViewById<EditText>(Resource.Id.txtEditItinerary);
            editItinerary.Text = editThis;

            Button btnUpdate = FindViewById<Button>(Resource.Id.btnSave);

            btnUpdate.Click += (sender, e) =>
            {
                DBItineraryRepository dbr = new DBItineraryRepository();

                string result = dbr.UpdateRecord(name, editItinerary.Text);
                Toast.MakeText(this, result, ToastLength.Short).Show();

                var intent = new Intent(this, typeof(itineraryAct));
                intent.PutExtra("name", name);
                StartActivity(intent);
                Finish();
            };


        }
    }
}