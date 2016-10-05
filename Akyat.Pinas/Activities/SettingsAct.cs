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
    [Activity(Theme = "@style/Theme.NoTitle", Label = "SettingsAct")]
    public class SettingsAct : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.settingsLayout);

            // Create your application here
            DBItineraryRepository dbr = new DBItineraryRepository();

            var terrain = "terrain";
            var terrainValue = "1";
            var normal = "normal";
            var normalValue = "0";
            var satellite = "satellite";
            var satelliteValue = "0";
            var hybrid = "toiletries";
            var hybridValue = "0";

            RadioButton rbTerrain = FindViewById<RadioButton>(Resource.Id.rbTerrain);
            RadioButton rbNormal = FindViewById<RadioButton>(Resource.Id.rbNormal);
            RadioButton rbSatellite = FindViewById<RadioButton>(Resource.Id.rbSatellite);
            RadioButton rbHybrid = FindViewById<RadioButton>(Resource.Id.rbHybrid);
            Button aboutbuttonn = FindViewById<Button>(Resource.Id.btnAbout);

            aboutbuttonn.Click += Aboutbuttonn_Click;    
            //CheckBox cbsounds = FindViewById<CheckBox>(Resource.Id.sound);

            //cbsounds.Click += (o,e) => {
            //    if (cbsounds.Checked)
            //        Toast.MakeText(this, "All Sounds Enabled!", ToastLength.Short).Show();
            //    else
            //        Toast.MakeText(this, "All Sounds Disabled", ToastLength.Short).Show();
            //};
            //getting record from database
            try
            {
                var terrainResult = dbr.GetRecordSettings(terrain);
                terrainValue = terrainResult;
                var normalResult = dbr.GetRecordSettings(normal);
                normalValue = normalResult;
                var satelliteResult = dbr.GetRecordSettings(satellite);
                satelliteValue = satelliteResult;
                var hybridResult = dbr.GetRecordSettings(hybrid);
                hybridValue = hybridResult;

            }
            catch (Exception ex)
            {
                
            }


            //implementing the value
            if (terrainValue == "1")
            {
                rbTerrain.Checked = true;
                rbNormal.Checked = false;
                rbSatellite.Checked = false;
                rbHybrid.Checked = false;
            }
            else if (normalValue == "1")
            {
                rbNormal.Checked = true;
            }
            else if (satelliteValue == "1")
            {
                rbSatellite.Checked = true;
            }
            else if (hybridValue == "1")
            {
                rbHybrid.Checked = true;
            }


            //saving
            Button btnSave = FindViewById<Button>(Resource.Id.btnSave);
            btnSave.Click += (sender, e) =>
            {

                if (rbTerrain.Checked == true)
                {
                    terrainValue = "1";
                    normalValue = "0";
                    hybridValue = "0";
                    satelliteValue = "0";
                }
                else if (rbNormal.Checked == true)
                {
                    terrainValue = "0";
                    normalValue = "1";
                    hybridValue = "0";
                    satelliteValue = "0";
                }
                else if (rbSatellite.Checked == true)
                {
                    terrainValue = "0";
                    normalValue = "0";
                    hybridValue = "0";
                    satelliteValue = "1";
                }
                else if (rbHybrid.Checked == true)
                {
                    terrainValue = "0";
                    normalValue = "0";
                    hybridValue = "1";
                    satelliteValue = "0";
                }


                var result = dbr.InsertRecordSettings(terrain, terrainValue);
                dbr.InsertRecordSettings(normal, normalValue);
                dbr.InsertRecordSettings(satellite, satelliteValue);
                dbr.InsertRecordSettings(hybrid, hybridValue);

                Toast.MakeText(this, result, ToastLength.Short).Show();
                
                Finish();
            };
        }

        private void Aboutbuttonn_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(AboutUsAct));
        }
    }
}