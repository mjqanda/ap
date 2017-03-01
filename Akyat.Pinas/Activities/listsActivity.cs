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
using System.IO;
using SQLite;

namespace Akyat.Pinas.Activities
{
    [Activity(Theme = "@style/Theme.NoTitle",Label = "listsActivity")]
    public class listsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.listsLayout);
            // Create your application here
            

         string name = Intent.GetStringExtra("name");

            TextView tv = FindViewById<TextView>(Resource.Id.txtLists);
            DBItineraryRepository dbr = new DBItineraryRepository();
      
            string outputValue = "";
            string othersValue = "";

            try { 

            string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "ormItinerary.db3");
            var db = new SQLiteConnection(dbPath);
           

            var items = db.Get<ChecklistClass>(name);

                if (items.backpackValue == "1")
                {
                    outputValue += "Backpack" + "\n";
                }
                
                if (items.bootsValue == "1")
                {
                    outputValue += "Boots" + "\n";
                }

                if (items.plasticbagValue == "1")
                {
                    outputValue += "Plastic Bag and Trashbag" + "\n";
                }

                if (items.toiletriesValue == "1")
                {
                    outputValue += "Toiletries" + "\n";
                }
                if (items.outdoorclothesValue == "1")
                {
                    outputValue += "Outdoor clothes" + "\n";
                }
                if (items.trailfoodValue == "1")
                {
                    outputValue += "Trail food" + "\n";
                }
                if (items.packedlunchValue == "1")
                {
                    outputValue += "Packed lunch" + "\n";
                }
                if (items.trailwaterValue == "1")
                {
                    outputValue += "Trail water and sports drink" + "\n";
                }
                if (items.firstaidkitValue == "1")
                {
                    outputValue += "First aid kit" + "\n";
                }
                if (items.survivalkitValue == "1")
                {
                    outputValue += "Survival kit" + "\n";
                }
                if (items.messkitValue == "1")
                {
                    outputValue += "Mess kit" + "\n";
                }
                if (items.drinkingcupValue == "1")
                {
                    outputValue += "Drinking cup" + "\n";
                }
                if (items.spoonforkValue == "1")
                {
                    outputValue += "Spoon and fork" + "\n";
                }
                if (items.identificationValue == "1")
                {
                    outputValue += "Dog tag / Identification" + "\n";
                }
                if (items.whistleValue == "1")
                {
                    outputValue += "Whistle" + "\n";
                }
                if (items.raingearValue == "1")
                {
                    outputValue += "Rain gear" + "\n";
                }
                if (items.jacketValue == "1")
                {
                    outputValue += "Windbreaker / Jacket" + "\n";
                }
                if (items.sunprotectionValue == "1")
                {
                    outputValue += "Sun protection" + "\n";
                }
                if (items.flashlightValue == "1")
                {
                    outputValue += "Headlamp / Flashlight" + "\n";
                }
                if (items.multitoolValue == "1")
                {
                    outputValue += "Folding knife / Multitool" + "\n";
                }
                if (items.mobilephoneValue == "1")
                {
                    outputValue += "Mobile phone" + "\n";
                }
                if (items.camerabatteriesValue == "1")
                {
                    outputValue += "Camera and Batteries" + "\n";
                }
                if (items.trekkingpoleValue == "1")
                {
                    outputValue += "Trekking pole" + "\n";
                }
                if (items.blanketValue == "1")
                {
                    outputValue += "Sleeping bag / Blanket" + "\n";
                }
                if (items.extraclothesValue == "1")
                {
                    outputValue += "Extra clothes" + "\n";
                }
                if (items.sandalsValue == "1")
                {
                    outputValue += "Sandals / Slippers" + "\n";
                }
                if (items.campwaterValue == "1")
                {
                    outputValue += "Camp water / Container" + "\n";
                }
                if (items.precookfoodValue == "1")
                {
                    outputValue += "Pre-cooked food" + "\n";
                }
                if (items.riceValue == "1")
                {
                    outputValue += "Rice and eggs" + "\n";
                }
                if (items.tyingstringValue == "1")
                {
                    outputValue += "Tying strings" + "\n";
                }
                if (items.stovefuelValue == "1")
                {
                    outputValue += "Stove fuel" + "\n";
                }
                if (items.lighterValue == "1")
                {
                    outputValue += "Lighter" + "\n";
                }
                if (items.matchesValue == "1")
                {
                    outputValue += "Matches" + "\n";
                }
                if (items.boloValue == "1")
                {
                    outputValue += "Bolo" + "\n";
                }
                if (items.mapcompassValue == "1")
                {
                    outputValue += "Map and Compass" + "\n";
                }
                if (items.stoveValue == "1")
                {
                    outputValue += "Stove" + "\n";
                }
                if (items.cooksetValue == "1")
                {
                    outputValue += "Cook set" + "\n";
                }
                if (items.flagValue == "1")
                {
                    outputValue += "Club flag" + "\n";
                }
                if (items.tentValue == "1")
                {
                    outputValue += "Tent" + "\n";
                }
                if (items.groundsheetValue == "1")
                {
                    outputValue += "Groundsheet" + "\n";
                }
                if (items.ropeValue == "1")
                {
                    outputValue += "Rope" + "\n";
                }
                if (items.trowelValue == "1")
                {
                    outputValue += "Towel" + "\n";
                }
                 othersValue = items.othersValue;
            }
            catch
            {

            }

            
            tv.Text = outputValue;
            TextView others = FindViewById<TextView>(Resource.Id.txtOthers);
            others.Text = othersValue;

            ImageButton add = FindViewById<ImageButton>(Resource.Id.imageButtonAdd);
            add.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(ThingsToBringAct));
                intent.PutExtra("name", name);
                StartActivityForResult(intent,1);
                OverridePendingTransition(Resource.Animation.slide_right, Resource.Animation.fade_out);
            };
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            var i = new Intent();

           string name = Intent.GetStringExtra("name");
            
            //when regester activity retrun data, it will be execute 

            if (requestCode == 1 && resultCode == Result.Ok)
            {
                TextView tv = FindViewById<TextView>(Resource.Id.txtLists);
                DBItineraryRepository dbr = new DBItineraryRepository();
                string outputValue = "";
                string othersValue = "";
                //    TextView txtList = FindViewById<TextView>(Resource.Id.txtList);
                try
                {
                    string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "ormItinerary.db3");
                    var db = new SQLiteConnection(dbPath);
                    
                    var items = db.Get<ChecklistClass>(name);
                    if (items.backpackValue == "1")
                    {
                        outputValue += "Backpack" + "\n";
                    }

                    if (items.bootsValue == "1")
                    {
                        outputValue += "Boots" + "\n";
                    }

                    if (items.plasticbagValue == "1")
                    {
                        outputValue += "Plastic Bag and Trashbag" + "\n";
                    }

                    if (items.toiletriesValue == "1")
                    {
                        outputValue += "Toiletries" + "\n";
                    }
                    if (items.outdoorclothesValue == "1")
                    {
                        outputValue += "Outdoor clothes" + "\n";
                    }
                    if (items.trailfoodValue == "1")
                    {
                        outputValue += "Trail food" + "\n";
                    }
                    if (items.packedlunchValue == "1")
                    {
                        outputValue += "Packed lunch" + "\n";
                    }
                    if (items.trailwaterValue == "1")
                    {
                        outputValue += "Trail water and sports drink" + "\n";
                    }
                    if (items.firstaidkitValue == "1")
                    {
                        outputValue += "First aid kit" + "\n";
                    }
                    if (items.survivalkitValue == "1")
                    {
                        outputValue += "Survival kit" + "\n";
                    }
                    if (items.messkitValue == "1")
                    {
                        outputValue += "Mess kit" + "\n";
                    }
                    if (items.drinkingcupValue == "1")
                    {
                        outputValue += "Drinking cup" + "\n";
                    }
                    if (items.spoonforkValue == "1")
                    {
                        outputValue += "Spoon and fork" + "\n";
                    }
                    if (items.identificationValue == "1")
                    {
                        outputValue += "Dog tag / Identification" + "\n";
                    }
                    if (items.whistleValue == "1")
                    {
                        outputValue += "Whistle" + "\n";
                    }
                    if (items.raingearValue == "1")
                    {
                        outputValue += "Rain gear" + "\n";
                    }
                    if (items.jacketValue == "1")
                    {
                        outputValue += "Windbreaker / Jacket" + "\n";
                    }
                    if (items.sunprotectionValue == "1")
                    {
                        outputValue += "Sun protection" + "\n";
                    }
                    if (items.flashlightValue == "1")
                    {
                        outputValue += "Headlamp / Flashlight" + "\n";
                    }
                    if (items.multitoolValue == "1")
                    {
                        outputValue += "Folding knife / Multitool" + "\n";
                    }
                    if (items.mobilephoneValue == "1")
                    {
                        outputValue += "Mobile phone" + "\n";
                    }
                    if (items.camerabatteriesValue == "1")
                    {
                        outputValue += "Camera and Batteries" + "\n";
                    }
                    if (items.trekkingpoleValue == "1")
                    {
                        outputValue += "Trekking pole" + "\n";
                    }
                    if (items.blanketValue == "1")
                    {
                        outputValue += "Sleeping bag / Blanket" + "\n";
                    }
                    if (items.extraclothesValue == "1")
                    {
                        outputValue += "Extra clothes" + "\n";
                    }
                    if (items.sandalsValue == "1")
                    {
                        outputValue += "Sandals / Slippers" + "\n";
                    }
                    if (items.campwaterValue == "1")
                    {
                        outputValue += "Camp water / Container" + "\n";
                    }
                    if (items.precookfoodValue == "1")
                    {
                        outputValue += "Pre-cooked food" + "\n";
                    }
                    if (items.riceValue == "1")
                    {
                        outputValue += "Rice and eggs" + "\n";
                    }
                    if (items.tyingstringValue == "1")
                    {
                        outputValue += "Tying strings" + "\n";
                    }
                    if (items.stovefuelValue == "1")
                    {
                        outputValue += "Stove fuel" + "\n";
                    }
                    if (items.lighterValue == "1")
                    {
                        outputValue += "Lighter" + "\n";
                    }
                    if (items.matchesValue == "1")
                    {
                        outputValue += "Matches" + "\n";
                    }
                    if (items.boloValue == "1")
                    {
                        outputValue += "Bolo" + "\n";
                    }
                    if (items.mapcompassValue == "1")
                    {
                        outputValue += "Map and Compass" + "\n";
                    }
                    if (items.stoveValue == "1")
                    {
                        outputValue += "Stove" + "\n";
                    }
                    if (items.cooksetValue == "1")
                    {
                        outputValue += "Cook set" + "\n";
                    }
                    if (items.flagValue == "1")
                    {
                        outputValue += "Club flag" + "\n";
                    }
                    if (items.tentValue == "1")
                    {
                        outputValue += "Tent" + "\n";
                    }
                    if (items.groundsheetValue == "1")
                    {
                        outputValue += "Groundsheet" + "\n";
                    }
                    if (items.ropeValue == "1")
                    {
                        outputValue += "Rope" + "\n";
                    }
                    if (items.trowelValue == "1")
                    {
                        outputValue += "Towel" + "\n";
                    }

                    othersValue = items.othersValue;
                }
                catch
                {
                    
                }
                tv.Text = outputValue;
                TextView others = FindViewById<TextView>(Resource.Id.txtOthers);
                others.Text = othersValue;
            }
        }
        public override void OnBackPressed()
        {
            Finish();
            OverridePendingTransition(Resource.Animation.slide_left, Resource.Animation.fade_out);
        }
    }
}