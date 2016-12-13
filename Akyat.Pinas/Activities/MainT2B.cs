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
                
            }

            txtList.Text = output;

            ImageButton add = FindViewById<ImageButton>(Resource.Id.imageButtonAdd);
            add.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(ThingsToBringAct));
                StartActivityForResult(intent, 1);
            };


        }
        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {


            //when regester activity retrun data, it will be execute 

            if (requestCode == 1 && resultCode == Result.Ok)
            {

                TextView txtList = FindViewById<TextView>(Resource.Id.txtList);
               
                try
                {

                    DBItineraryRepository dbr = new DBItineraryRepository();
                    string result = dbr.GetRecordPapel();
                  string  output = result;
                    txtList.Text = output;
                }
                catch (Exception ex)
                {
                    Toast.MakeText(this, ex.Message, ToastLength.Short).Show();
                }

            }
        }
    }
}