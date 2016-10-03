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

            TextView txtItinerary = FindViewById<TextView>(Resource.Id.txtItineraryRecord);
            try { 
            DBItineraryRepository dbr = new DBItineraryRepository();
                var result = dbr.GetRecord(name);

                txtItinerary.Text = result;

            }
            catch (Exception ex)
            {
                Toast.MakeText(this,ex.Message , ToastLength.Short).Show();
            }

            Button btnAddIti = FindViewById<Button>(Resource.Id.btnAddIti);
            btnAddIti.Click += ((sender, e) =>
            {
                
                var intent = new Intent(this, typeof(AddItineraryAct));
                intent.PutExtra("editThis", txtItinerary.Text);
                intent.PutExtra("name", name);
                StartActivityForResult(intent, 1);

            });



            txtItinerary.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(AddItineraryAct));
                intent.PutExtra("editThis", txtItinerary.Text);
                intent.PutExtra("name", name);
                StartActivityForResult(intent, 1);

            };
           



    }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {


            //when regester activity retrun data, it will be execute 

            if (requestCode == 1 && resultCode == Result.Ok)
            {

                TextView txtItinerary = FindViewById<TextView>(Resource.Id.txtItineraryRecord);
                string name = data.GetStringExtra("name");
                try
                {

                    DBItineraryRepository dbr = new DBItineraryRepository();
                    var result = dbr.GetRecord(name);

                    txtItinerary.Text = result;

                }
                catch (Exception ex)
                {
                    Toast.MakeText(this, ex.Message, ToastLength.Short).Show();
                }
            }
        }
    }
}