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
    [Activity(Label = "ItiAndTtbActivity")]
    public class ItiAndTtbActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.itineraryAndTtbLayout);


     Button btnTTB = FindViewById<Button>(Resource.Id.btnTTB);
           Button btnITI = FindViewById<Button>(Resource.Id.btnITI);

            
            btnTTB.Click += (sender, e) =>
            {
                DBItineraryRepository dbr = new DBItineraryRepository();
                var resultTable = dbr.CreateTableChecklist();
                
                var intent = new Intent(this, typeof(MainT2B));

                intent.PutExtra("button", "ttb");
                StartActivity(intent);
                OverridePendingTransition(Resource.Animation.slide_right, Resource.Animation.fade_out);

            };
            btnITI.Click += (sender, e) =>
            {

                DBItineraryRepository dbr = new DBItineraryRepository();
                var result = dbr.CreateTable();
                var intent = new Intent(this, typeof(MainT2B));
                intent.PutExtra("button", "iti");
                StartActivity(intent);
                OverridePendingTransition(Resource.Animation.slide_right, Resource.Animation.fade_out);
            };



        }
        private void FadeInAnim()
        {
            OverridePendingTransition(Resource.Animation.fade_in, Resource.Animation.fade_out);
        }
    }
}