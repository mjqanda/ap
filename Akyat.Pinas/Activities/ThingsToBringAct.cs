using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Akyat.Pinas.ORM;
using System.IO;
using SQLite;

namespace Akyat.Pinas.Activities
{
    [Activity(Theme = "@style/Theme.NoTitle", Label = "T2BAct")]
    public class ThingsToBringAct : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.thingsToBringLayout);
            // Create your application here
            DBItineraryRepository dbr = new DBItineraryRepository();
      
            string name = Intent.GetStringExtra("name");

            // instantiate names and values
        
            var backpackValue = "0";
            var bootsValue = "0";
            var plasticbagValue = "0";
            var toiletriesValue = "0";
            var outdoorclothesValue = "0";
            var trailfoodValue = "0";
            var packedlunchValue = "0";
            var trailwaterValue = "0";
            var firstaidkitValue = "0";
            var survivalkitValue = "0";
            var messkitValue = "0";
            var drinkingcupValue = "0";
            var spoonforkValue = "0";
            var identificationValue = "0";
            var whistleValue = "0";
            var raingearValue = "0";
            var jacketValue = "0";
            var sunprotectionValue = "0";
            var flashlightValue = "0";
            var multitoolValue = "0";
            var mobilephoneValue = "0";
            var camerabatteriesValue = "0";
            var trekkingpoleValue = "0";
            var blanketValue = "0";
            var extraclothesValue = "0";
            var sandalsValue = "0";
            var campwaterValue = "0";
            var precookfoodValue = "0";
            var riceValue = "0";
            var tyingstringValue = "0";
            var stovefuelValue = "0";
            var lighterValue = "0";
            var matchesValue = "0";
            var boloValue = "0";
            var mapcompassValue = "0";
            var stoveValue = "0";
            var cooksetValue = "0";
            var flagValue = "0";
            var tentValue = "0";
            var groundsheetValue = "0";
            var ropeValue = "0";
            var trowelValue = "0";
            var othersValue = "";

            CheckBox cbbackpacks = FindViewById<CheckBox>(Resource.Id.cbBackpacks);
            CheckBox cbboots = FindViewById<CheckBox>(Resource.Id.cbBoots);
            CheckBox cbplasticbags = FindViewById<CheckBox>(Resource.Id.cbPlasticBags);
            CheckBox cbtoiletries = FindViewById<CheckBox>(Resource.Id.cbToiletries);
            CheckBox cboutdoorclothes = FindViewById<CheckBox>(Resource.Id.cbOutdoorClothes);
            CheckBox cbtrailfood = FindViewById<CheckBox>(Resource.Id.cbTrailFood);
            CheckBox cbpackedlunch = FindViewById<CheckBox>(Resource.Id.cbPackedLunch);
            CheckBox cbtrailwater = FindViewById<CheckBox>(Resource.Id.cbTrailWater);
            CheckBox cbfirstaidkit = FindViewById<CheckBox>(Resource.Id.cbFirstAidKit);
            CheckBox cbsurvivalkit = FindViewById<CheckBox>(Resource.Id.cbSurvivalKit);
            CheckBox cbmesskit = FindViewById<CheckBox>(Resource.Id.cbMessKit);
            CheckBox cbdrinkingcup = FindViewById<CheckBox>(Resource.Id.cbDrinkingCup);
            CheckBox cbspoonfork = FindViewById<CheckBox>(Resource.Id.cbSpoonFork);
            CheckBox cbidentification = FindViewById<CheckBox>(Resource.Id.cbIdentification);
            CheckBox cbwhistle = FindViewById<CheckBox>(Resource.Id.cbWhistle);
            CheckBox cbraingear = FindViewById<CheckBox>(Resource.Id.cbRainGear);
            CheckBox cbjacket = FindViewById<CheckBox>(Resource.Id.cbJacket);
            CheckBox cbsunprotection = FindViewById<CheckBox>(Resource.Id.cbSunProtection);
            CheckBox cbflashlight = FindViewById<CheckBox>(Resource.Id.cbFlashlight);
            CheckBox cbmultitool = FindViewById<CheckBox>(Resource.Id.cbMultitool);
            CheckBox cbmobilephone = FindViewById<CheckBox>(Resource.Id.cbMobilePhone);
            CheckBox cbcamerabatteries = FindViewById<CheckBox>(Resource.Id.cbCameraBatteries);
            CheckBox cbtrekkingpole = FindViewById<CheckBox>(Resource.Id.cbTrekkingPole);
            CheckBox cbblanket = FindViewById<CheckBox>(Resource.Id.cbBlanket);
            CheckBox cbextraclothes = FindViewById<CheckBox>(Resource.Id.cbExtraClothes);
            CheckBox cbsandals = FindViewById<CheckBox>(Resource.Id.cbSandals);
            CheckBox cbcampwater = FindViewById<CheckBox>(Resource.Id.cbCampWater);
            CheckBox cbprecookfood = FindViewById<CheckBox>(Resource.Id.cbPrecookedFood);
            CheckBox cbrice = FindViewById<CheckBox>(Resource.Id.cbRiceEggs);
            CheckBox cbtyingstring = FindViewById<CheckBox>(Resource.Id.cbTyingString);
            CheckBox cbstovefuel = FindViewById<CheckBox>(Resource.Id.cbStoveFuel);
            CheckBox cblighter = FindViewById<CheckBox>(Resource.Id.cbLighter);
            CheckBox cbmatches = FindViewById<CheckBox>(Resource.Id.cbMatches);
            CheckBox cbbolo = FindViewById<CheckBox>(Resource.Id.cbBolo);
            CheckBox cbmapcompass = FindViewById<CheckBox>(Resource.Id.cbMapCompass);
            CheckBox cbstove = FindViewById<CheckBox>(Resource.Id.cbStove);
            CheckBox cbcookset = FindViewById<CheckBox>(Resource.Id.cbCookset);
            CheckBox cbflag = FindViewById<CheckBox>(Resource.Id.cbFlag);
            CheckBox cbtent = FindViewById<CheckBox>(Resource.Id.cbTent);
            CheckBox cbgroundsheet = FindViewById<CheckBox>(Resource.Id.cbGroundsheet);
            CheckBox cbrope = FindViewById<CheckBox>(Resource.Id.cbRope);
            CheckBox cbtrowel = FindViewById<CheckBox>(Resource.Id.cbTrowel);

            EditText txtOthers = FindViewById<EditText>(Resource.Id.txtOthers);

            //getting the value of the checkbox from database

            try
            {
                string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "ormItinerary.db3");
                var db = new SQLiteConnection(dbPath);
                string outputValue = "";

                var item = db.Get<ChecklistClass>(name);

                backpackValue = item.backpackValue;
                bootsValue = item.bootsValue;
                plasticbagValue = item.plasticbagValue;
                toiletriesValue = item.toiletriesValue;
                outdoorclothesValue = item.outdoorclothesValue;
                trailfoodValue = item.trailfoodValue;
                packedlunchValue = item.packedlunchValue;
                trailwaterValue = item.trailwaterValue;
                firstaidkitValue = item.firstaidkitValue;
                survivalkitValue = item.survivalkitValue;
                messkitValue = item.messkitValue;
                drinkingcupValue = item.drinkingcupValue;
                spoonforkValue = item.spoonforkValue;
                identificationValue = item.identificationValue;
                whistleValue = item.whistleValue;
                raingearValue = item.raingearValue;
                jacketValue = item.jacketValue;
                sunprotectionValue = item.sunprotectionValue;
                flashlightValue = item.flashlightValue;
                multitoolValue = item.multitoolValue;
                mobilephoneValue = item.mobilephoneValue;
                camerabatteriesValue = item.camerabatteriesValue;
                trekkingpoleValue = item.trekkingpoleValue;
                blanketValue = item.blanketValue;
                extraclothesValue = item.extraclothesValue;
                sandalsValue = item.sandalsValue;
                campwaterValue = item.campwaterValue;
                precookfoodValue = item.precookfoodValue;
                riceValue = item.riceValue;
                tyingstringValue = item.tyingstringValue;
                stovefuelValue = item.stovefuelValue;
                lighterValue = item.lighterValue;
                matchesValue = item.matchesValue;
                boloValue = item.boloValue;
                mapcompassValue = item.mapcompassValue;
                stoveValue = item.stoveValue;
                cooksetValue = item.cooksetValue;
                flagValue = item.flagValue;
                tentValue = item.tentValue;
                groundsheetValue = item.groundsheetValue;
                ropeValue = item.ropeValue;
                trowelValue = item.trowelValue;
                othersValue = item.othersValue;

            }
            catch (Exception ex)
            {
                
            }

            //implementing the value

            if (backpackValue == "0")
            {
                cbbackpacks.Checked = false;
            }
            else if (backpackValue == "1")
            {
                cbbackpacks.Checked = true;
            }

            if (bootsValue == "0")
            {
                cbboots.Checked = false;
            }
            else if (bootsValue == "1")
            {
                cbboots.Checked = true;
            }

            if (plasticbagValue == "0")
            {
                cbplasticbags.Checked = false;
            }
            else if (plasticbagValue == "1")
            {
                cbplasticbags.Checked = true;
            }

            if (toiletriesValue == "0")
            {
                cbtoiletries.Checked = false;
            }
            else if (toiletriesValue == "1")
            {
                cbtoiletries.Checked = true;
            }

            if (outdoorclothesValue == "0")
            {
                cboutdoorclothes.Checked = false;
            }
            else if (outdoorclothesValue == "1")
            {
                cboutdoorclothes.Checked = true;
            }

            if (trailfoodValue == "0")
            {
                cbtrailfood.Checked = false;
            }
            else if (trailfoodValue == "1")
            {
                cbtrailfood.Checked = true;
            }

            if (packedlunchValue == "0")
            {
                cbpackedlunch.Checked = false;
            }
            else if (packedlunchValue == "1")
            {
                cbpackedlunch.Checked = true;
            }

            if (trailwaterValue == "0")
            {
                cbtrailwater.Checked = false;
            }
            else if (trailwaterValue == "1")
            {
                cbtrailwater.Checked = true;
            }

            if (firstaidkitValue == "0")
            {
                cbfirstaidkit.Checked = false;
            }
            else if (firstaidkitValue == "1")
            {
                cbfirstaidkit.Checked = true;
            }

            if (survivalkitValue == "0")
            {
                cbsurvivalkit.Checked = false;
            }
            else if (survivalkitValue == "1")
            {
                cbsurvivalkit.Checked = true;
            }

            if (messkitValue == "0")
            {
                cbmesskit.Checked = false;
            }
            else if (messkitValue == "1")
            {
                cbmesskit.Checked = true;
            }

            if (drinkingcupValue == "0")
            {
                cbdrinkingcup.Checked = false;
            }
            else if (drinkingcupValue == "1")
            {
                cbdrinkingcup.Checked = true;
            }

            if (spoonforkValue == "0")
            {
                cbspoonfork.Checked = false;
            }
            else if (spoonforkValue == "1")
            {
                cbspoonfork.Checked = true;
            }

            if (identificationValue == "0")
            {
                cbidentification.Checked = false;
            }
            else if (identificationValue == "1")
            {
                cbidentification.Checked = true;
            }

            if (whistleValue == "0")
            {
                cbwhistle.Checked = false;
            }
            else if (whistleValue == "1")
            {
                cbwhistle.Checked = true;
            }

            if (raingearValue == "0")
            {
                cbraingear.Checked = false;
            }
            else if (raingearValue == "1")
            {
                cbraingear.Checked = true;
            }

            if (jacketValue == "0")
            {
                cbjacket.Checked = false;
            }
            else if (jacketValue == "1")
            {
                cbjacket.Checked = true;
            }

            if (sunprotectionValue == "0")
            {
                cbsunprotection.Checked = false;
            }
            else if (sunprotectionValue == "1")
            {
                cbsunprotection.Checked = true;
            }

            if (flashlightValue == "0")
            {
                cbflashlight.Checked = false;
            }
            else if (flashlightValue == "1")
            {
                cbflashlight.Checked = true;
            }

            if (multitoolValue == "0")
            {
                cbmultitool.Checked = false;
            }
            else if (multitoolValue == "1")
            {
                cbmultitool.Checked = true;
            }

            if (mobilephoneValue == "0")
            {
                cbmobilephone.Checked = false;
            }
            else if (mobilephoneValue == "1")
            {
                cbmobilephone.Checked = true;
            }

            if (camerabatteriesValue == "0")
            {
                cbcamerabatteries.Checked = false;
            }
            else if (camerabatteriesValue == "1")
            {
                cbcamerabatteries.Checked = true;
            }

            if (trekkingpoleValue == "0")
            {
                cbtrekkingpole.Checked = false;
            }
            else if (trekkingpoleValue == "1")
            {
                cbtrekkingpole.Checked = true;
            }

            if (blanketValue == "0")
            {
                cbblanket.Checked = false;
            }
            else if (blanketValue == "1")
            {
                cbblanket.Checked = true;
            }

            if (extraclothesValue == "0")
            {
                cbextraclothes.Checked = false;
            }
            else if (extraclothesValue == "1")
            {
                cbextraclothes.Checked = true;
            }

            if (sandalsValue == "0")
            {
                cbsandals.Checked = false;
            }
            else if (sandalsValue == "1")
            {
                cbsandals.Checked = true;
            }

            if (campwaterValue == "0")
            {
                cbcampwater.Checked = false;
            }
            else if (campwaterValue == "1")
            {
                cbcampwater.Checked = true;
            }

            if (precookfoodValue == "0")
            {
                cbprecookfood.Checked = false;
            }
            else if (precookfoodValue == "1")
            {
                cbprecookfood.Checked = true;
            }

            if (riceValue == "0")
            {
                cbrice.Checked = false;
            }
            else if (riceValue == "1")
            {
                cbrice.Checked = true;
            }

            if (tyingstringValue == "0")
            {
                cbtyingstring.Checked = false;
            }
            else if (tyingstringValue == "1")
            {
                cbtyingstring.Checked = true;
            }

            if (stovefuelValue == "0")
            {
                cbstovefuel.Checked = false;
            }
            else if (stovefuelValue == "1")
            {
                cbstovefuel.Checked = true;
            }

            if (lighterValue == "0")
            {
                cblighter.Checked = false;
            }
            else if (lighterValue == "1")
            {
                cblighter.Checked = true;
            }

            if (matchesValue == "0")
            {
                cbmatches.Checked = false;
            }
            else if (matchesValue == "1")
            {
                cbmatches.Checked = true;
            }

            if (boloValue == "0")
            {
                cbbolo.Checked = false;
            }
            else if (boloValue == "1")
            {
                cbbolo.Checked = true;
            }

            if (mapcompassValue == "0")
            {
                cbmapcompass.Checked = false;
            }
            else if (mapcompassValue == "1")
            {
                cbmapcompass.Checked = true;
            }

            if (stoveValue == "0")
            {
                cbstove.Checked = false;
            }
            else if (stoveValue == "1")
            {
                cbstove.Checked = true;
            }

            if (cooksetValue == "0")
            {
                cbcookset.Checked = false;
            }
            else if (cooksetValue == "1")
            {
                cbcookset.Checked = true;
            }

            if (flagValue == "0")
            {
                cbflag.Checked = false;
            }
            else if (flagValue == "1")
            {
                cbflag.Checked = true;
            }

            if (tentValue == "0")
            {
                cbtent.Checked = false;
            }
            else if (tentValue == "1")
            {
                cbtent.Checked = true;
            }

            if (groundsheetValue == "0")
            {
                cbgroundsheet.Checked = false;
            }
            else if (groundsheetValue == "1")
            {
                cbgroundsheet.Checked = true;
            }

            if (ropeValue == "0")
            {
                cbrope.Checked = false;
            }
            else if (ropeValue == "1")
            {
                cbrope.Checked = true;
            }

            if (trowelValue == "0")
            {
                cbtrowel.Checked = false;
            }
            else if (trowelValue == "1")
            {
                cbtrowel.Checked = true;
            }

            txtOthers.Text = othersValue;



            //saving
            Button btnSave = FindViewById<Button>(Resource.Id.btnSave);
            btnSave.Click += (sender, e) =>
            {

                if (cbbackpacks.Checked == true)
                {
                    backpackValue = "1";
                }
                else if (cbbackpacks.Checked == false)
                {
                    backpackValue = "0";
                }

                if (cbboots.Checked == true)
                {
                    bootsValue = "1";
                }
                else if (cbboots.Checked == false)
                {
                    bootsValue = "0";
                }

                if (cbplasticbags.Checked == true)
                {
                    plasticbagValue = "1";
                }
                else if (cbplasticbags.Checked == false)
                {
                    plasticbagValue = "0";
                }

                if (cbtoiletries.Checked == true)
                {
                    toiletriesValue = "1";
                }
                else if (cbtoiletries.Checked == false)
                {
                    toiletriesValue = "0";
                }

                if (cboutdoorclothes.Checked == true)
                {
                    outdoorclothesValue = "1";
                }
                else if (cboutdoorclothes.Checked == false)
                {
                    outdoorclothesValue = "0";
                }

                if (cbtrailfood.Checked == true)
                {
                    trailfoodValue = "1";
                }
                else if (cbtrailfood.Checked == false)
                {
                    trailfoodValue = "0";
                }

                if (cbpackedlunch.Checked == true)
                {
                    packedlunchValue = "1";
                }
                else if (cbpackedlunch.Checked == false)
                {
                    packedlunchValue = "0";
                }

                if (cbtrailwater.Checked == true)
                {
                    trailwaterValue = "1";
                }
                else if (cbtrailwater.Checked == false)
                {
                    trailwaterValue = "0";
                }

                if (cbfirstaidkit.Checked == true)
                {
                    firstaidkitValue = "1";
                }
                else if (cbfirstaidkit.Checked == false)
                {
                    firstaidkitValue = "0";
                }

                if (cbsurvivalkit.Checked == true)
                {
                    survivalkitValue = "1";
                }
                else if (cbsurvivalkit.Checked == false)
                {
                    survivalkitValue = "0";
                }

                if (cbmesskit.Checked == true)
                {
                    messkitValue = "1";
                }
                else if (cbmesskit.Checked == false)
                {
                    messkitValue = "0";
                }

                if (cbdrinkingcup.Checked == true)
                {
                    drinkingcupValue = "1";
                }
                else if (cbdrinkingcup.Checked == false)
                {
                    drinkingcupValue = "0";
                }

                if (cbspoonfork.Checked == true)
                {
                    spoonforkValue = "1";
                }
                else if (cbspoonfork.Checked == false)
                {
                    spoonforkValue = "0";
                }

                if (cbidentification.Checked == true)
                {
                    identificationValue = "1";
                }
                else if (cbidentification.Checked == false)
                {
                    identificationValue = "0";
                }

                if (cbwhistle.Checked == true)
                {
                    whistleValue = "1";
                }
                else if (cbwhistle.Checked == false)
                {
                    whistleValue = "0";
                }

                if (cbraingear.Checked == true)
                {
                    raingearValue = "1";
                }
                else if (cbraingear.Checked == false)
                {
                    raingearValue = "0";
                }

                if (cbjacket.Checked == true)
                {
                    jacketValue = "1";
                }
                else if (cbjacket.Checked == false)
                {
                    jacketValue = "0";
                }

                if (cbsunprotection.Checked == true)
                {
                    sunprotectionValue = "1";
                }
                else if (cbsunprotection.Checked == false)
                {
                    sunprotectionValue = "0";
                }

                if (cbflashlight.Checked == true)
                {
                    flashlightValue = "1";
                }
                else if (cbflashlight.Checked == false)
                {
                    flashlightValue = "0";
                }

                if (cbmultitool.Checked == true)
                {
                    multitoolValue = "1";
                }
                else if (cbmultitool.Checked == false)
                {
                    multitoolValue = "0";
                }

                if (cbmobilephone.Checked == true)
                {
                    mobilephoneValue = "1";
                }
                else if (cbmobilephone.Checked == false)
                {
                    mobilephoneValue = "0";
                }

                if (cbcamerabatteries.Checked == true)
                {
                    camerabatteriesValue = "1";
                }
                else if (cbcamerabatteries.Checked == false)
                {
                    camerabatteriesValue = "0";
                }

                if (cbtrekkingpole.Checked == true)
                {
                    trekkingpoleValue = "1";
                }
                else if (cbtrekkingpole.Checked == false)
                {
                    trekkingpoleValue = "0";
                }

                if (cbblanket.Checked == true)
                {
                    blanketValue = "1";
                }
                else if (cbblanket.Checked == false)
                {
                    blanketValue = "0";
                }

                if (cbextraclothes.Checked == true)
                {
                    extraclothesValue = "1";
                }
                else if (cbextraclothes.Checked == false)
                {
                    extraclothesValue = "0";
                }

                if (cbsandals.Checked == true)
                {
                    sandalsValue = "1";
                }
                else if (cbsandals.Checked == false)
                {
                    sandalsValue = "0";
                }

                if (cbcampwater.Checked == true)
                {
                    campwaterValue = "1";
                }
                else if (cbcampwater.Checked == false)
                {
                    campwaterValue = "0";
                }

                if (cbprecookfood.Checked == true)
                {
                    precookfoodValue = "1";
                }
                else if (cbprecookfood.Checked == false)
                {
                    precookfoodValue = "0";
                }


                if (cbrice.Checked == true)
                {
                    riceValue = "1";
                }
                else if (cbrice.Checked == false)
                {
                    riceValue = "0";
                }


                if (cbtyingstring.Checked == true)
                {
                    tyingstringValue = "1";
                }
                else if (cbtyingstring.Checked == false)
                {
                    tyingstringValue = "0";
                }


                if (cbstovefuel.Checked == true)
                {
                    stovefuelValue = "1";
                }
                else if (cbstovefuel.Checked == false)
                {
                    stovefuelValue = "0";
                }


                if (cblighter.Checked == true)
                {
                    lighterValue = "1";
                }
                else if (cblighter.Checked == false)
                {
                    lighterValue = "0";
                }


                if (cbmatches.Checked == true)
                {
                    matchesValue = "1";
                }
                else if (cbmatches.Checked == false)
                {
                    matchesValue = "0";
                }


                if (cbbolo.Checked == true)
                {
                    boloValue = "1";
                }
                else if (cbbolo.Checked == false)
                {
                    boloValue = "0";
                }


                if (cbmapcompass.Checked == true)
                {
                    mapcompassValue = "1";
                }
                else if (cbmapcompass.Checked == false)
                {
                    mapcompassValue = "0";
                }


                if (cbstove.Checked == true)
                {
                    stoveValue = "1";
                }
                else if (cbstove.Checked == false)
                {
                    stoveValue = "0";
                }


                if (cbcookset.Checked == true)
                {
                    cooksetValue = "1";
                }
                else if (cbcookset.Checked == false)
                {
                    cooksetValue = "0";
                }


                if (cbflag.Checked == true)
                {
                    flagValue = "1";
                }
                else if (cbflag.Checked == false)
                {
                    flagValue = "0";
                }


                if (cbtent.Checked == true)
                {
                    tentValue = "1";
                }
                else if (cbtent.Checked == false)
                {
                    tentValue = "0";
                }


                if (cbgroundsheet.Checked == true)
                {
                    groundsheetValue = "1";
                }
                else if (cbgroundsheet.Checked == false)
                {
                    groundsheetValue = "0";
                }


                if (cbrope.Checked == true)
                {
                    ropeValue = "1";
                }
                else if (cbrope.Checked == false)
                {
                    ropeValue = "0";
                }


                if (cbtrowel.Checked == true)
                {
                    trowelValue = "1";
                }
                else if (cbtrowel.Checked == false)
                {
                    trowelValue = "0";
                }

                var result = dbr.InsertRecordChecklist(name, backpackValue, bootsValue,plasticbagValue,

                toiletriesValue,
                outdoorclothesValue,
                trailfoodValue,
                packedlunchValue,
                trailwaterValue,
                firstaidkitValue,
                survivalkitValue,
                messkitValue,
                drinkingcupValue,
                spoonforkValue,
                identificationValue,
                whistleValue,
                raingearValue,
                jacketValue,
                sunprotectionValue,
                flashlightValue,
                multitoolValue,
                mobilephoneValue,
                camerabatteriesValue,
                trekkingpoleValue,
                blanketValue,
                extraclothesValue,
                sandalsValue,
                campwaterValue,
                precookfoodValue,
                riceValue,
                tyingstringValue,
                stovefuelValue,
                lighterValue,
                matchesValue,
                boloValue,
                mapcompassValue,
                stoveValue,
                cooksetValue,
                flagValue,
                tentValue,
                groundsheetValue,
                ropeValue,
                trowelValue,
                txtOthers.Text
                    );

                Toast.MakeText(this, result, ToastLength.Short).Show();
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", name);
                SetResult(Result.Ok, intent);
                Finish();
                OverridePendingTransition(Resource.Animation.fade_in, Resource.Animation.fade_out);
            };
            
        }

        public override void OnBackPressed()
        {
            Finish();
            OverridePendingTransition(Resource.Animation.slide_left, Resource.Animation.fade_out);
        }

     }
}