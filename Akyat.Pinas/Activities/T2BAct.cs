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
    [Activity(Theme = "@style/Theme.NoTitle", Label = "T2BAct")]
    public class T2BAct : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.T2BLayout);
            // Create your application here
            DBItineraryRepository dbr = new DBItineraryRepository();
            // instantiate names and values
            var backpack = "backpack";
            var backpackValue = "0";
            var boots = "boots";
            var bootsValue = "0";
            var plasticbag = "plasticbag";
            var plasticbagValue = "0";
            var toiletries = "toiletries";
             var toiletriesValue = "0";
            var outdoorclothes = "outdoorclothes";
             var outdoorclothesValue = "0";
            var trailfood = "trailfood";
            var trailfoodValue = "0";
            var packedlunch = "packedlunch";
             var packedlunchValue = "0";
            var trailwater = "trailwater";
            var trailwaterValue = "0";
            var firstaidkit = "firstaidkit";
            var firstaidkitValue = "0";
            var survivalkit = "survivalkit";
             var survivalkitValue = "0";
            var messkit = "messkit";
            var messkitValue = "0";
            var drinkingcup = "drinkingcup";
            var drinkingcupValue = "0";
            var spoonfork = "spoonfork";
             var spoonforkValue = "0";
            var identification = "identification";
            var identificationValue = "0";
            var whistle = "whistle";
            var whistleValue = "0";
            var raingear = "raingear";
            var raingearValue = "0";
            var jacket = "jacket";
            var jacketValue = "0";
            var sunprotection = "sunprotection";
            var sunprotectionValue = "0";
            var flashlight = "flashlight";
             var flashlightValue = "0";
            var multitool = "multitool";
            var multitoolValue = "0";
            var mobilephone = "mobilephone";
            var mobilephoneValue = "0";
            var camerabatteries = "camera";
            var camerabatteriesValue = "0";
            var trekkingpole = "trekkingpole";
            var trekkingpoleValue = "0";
           
            var blanket = "blanket";
             var blanketValue = "0";
            var extraclothes = "extraclothes";
            var extraclothesValue = "0";
            var sandals = "sandals";
            var sandalsValue = "0";
            var campwater = "campwater";
            var campwaterValue = "0";
            var precookfood = "precookfood";
             var precookfoodValue = "0";
            var rice = "rice";
            var riceValue = "0";
            var tyingstring = "tyingstring";
            var tyingstringValue = "0";
            var stovefuel = "stovefuel";
            var stovefuelValue = "0";
            var lighter = "lighter";
            var lighterValue = "0";
            var matches = "matches";
            var matchesValue = "0";
            var bolo = "bolo";
            var boloValue = "0";
            var mapcompass = "mapcompass";
            var mapcompassValue = "0";
            var stove = "stove";
             var stoveValue = "0";
            var cookset = "cookset";
            var cooksetValue = "0";
            var flag = "flag";
            var flagValue = "0";
            var tent = "tent";
            var tentValue = "0";
            var groundsheet = "groundsheet";
            var groundsheetValue = "0";
            var rope = "rope";
                var ropeValue = "0";
            var trowel = "trowel";
            var trowelValue = "0";

            CheckBox cbbackpack = FindViewById<CheckBox>(Resource.Id.cbBackpack);
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
            CheckBox cbtrowel = FindViewById<CheckBox>(Resource.Id.cbBackpack);













            //getting the value of the checkbox from database

            try
            {
              var backpackResult = dbr.GetRecordChecklist(backpack);
                  backpackValue = backpackResult;
                var bootsResult = dbr.GetRecordChecklist(boots);
                bootsValue = bootsResult;
                var plasticbagResult = dbr.GetRecordChecklist(plasticbag);
                plasticbagValue = plasticbagResult;
                var toiletriesResult = dbr.GetRecordChecklist(toiletries);
                toiletriesValue = toiletriesResult;
                var outdoorclothesResult = dbr.GetRecordChecklist(outdoorclothes);
                outdoorclothesValue = outdoorclothesResult;
                var trailfoodResult = dbr.GetRecordChecklist(trailfood);
                trailfoodValue = trailfoodResult;
                var firstaidkitResult = dbr.GetRecordChecklist(firstaidkit);
                firstaidkitValue = firstaidkitResult;
                var survivalkitResult = dbr.GetRecordChecklist(survivalkit);
                 survivalkitValue = survivalkitResult;
                var messkitResult = dbr.GetRecordChecklist(messkit);
                messkitValue = messkitResult;
                var drinkingcupResult = dbr.GetRecordChecklist(drinkingcup);
                drinkingcupValue = drinkingcupResult;
                var spoonforkResult = dbr.GetRecordChecklist(spoonfork);
                spoonforkValue = spoonforkResult;
                var identificationResult = dbr.GetRecordChecklist(identification);
                identificationValue = identificationResult;
                var whistleResult = dbr.GetRecordChecklist(whistle);
                whistleValue = whistleResult;
                var raingearResult = dbr.GetRecordChecklist(raingear);
                raingearValue = raingearResult;
                var jacketResult = dbr.GetRecordChecklist(jacket);
               jacketValue =jacketResult;
                var packedlunchResult = dbr.GetRecordChecklist(packedlunch);
                packedlunchValue = packedlunchResult;
                var trailwaterResult = dbr.GetRecordChecklist(trailwater);
                trailwaterValue = trailwaterResult;
                var sunprotectionResult = dbr.GetRecordChecklist(sunprotection);
                sunprotectionValue = sunprotectionResult;
                var flashlightResult = dbr.GetRecordChecklist(flashlight);
                flashlightValue = flashlightResult;
                var multitoolResult = dbr.GetRecordChecklist(multitool);
                multitoolValue = multitoolResult;
                var mobilephoneResult = dbr.GetRecordChecklist(mobilephone);
                mobilephoneValue = mobilephoneResult;
                var trekkingpoleResult = dbr.GetRecordChecklist(trekkingpole);
                trekkingpoleValue = trekkingpoleResult;
               
                var blanketResult = dbr.GetRecordChecklist(blanket);
                blanketValue = blanketResult;
                var camerabatteriesResult = dbr.GetRecordChecklist(camerabatteries);
                camerabatteriesValue = camerabatteriesResult;
                var extraclothesResult = dbr.GetRecordChecklist(extraclothes);
                extraclothesValue = extraclothesResult;
                var sandalsResult = dbr.GetRecordChecklist(sandals);
                sandalsValue = sandalsResult;
                var campwaterResult = dbr.GetRecordChecklist(campwater);
                campwaterValue = campwaterResult;
                var precookfoodResult = dbr.GetRecordChecklist(precookfood);
                precookfoodValue = precookfoodResult;
                var riceResult = dbr.GetRecordChecklist(rice);
                riceValue = riceResult;
                var tyingstringResult = dbr.GetRecordChecklist(tyingstring);
                tyingstringValue = tyingstringResult;
                var stovefuelResult = dbr.GetRecordChecklist(stovefuel);
                stovefuelValue = stovefuelResult;
                var lighterResult = dbr.GetRecordChecklist(lighter);
                lighterValue = lighterResult;
                var matchesResult = dbr.GetRecordChecklist(matches);
                matchesValue = matchesResult;
                var boloResult = dbr.GetRecordChecklist(bolo);
                boloValue = boloResult;
                var mapcompassResult = dbr.GetRecordChecklist(mapcompass);
                mapcompassValue = mapcompassResult;
                var stoveResult = dbr.GetRecordChecklist(stove);
                stoveValue = stoveResult;
                var cooksetResult = dbr.GetRecordChecklist(cookset);
                cooksetValue = cooksetResult;
                var flagResult = dbr.GetRecordChecklist(flag);
                flagValue = flagResult;
                var tentResult = dbr.GetRecordChecklist(tent);
                tentValue = tentResult;
                var groundsheetResult = dbr.GetRecordChecklist(groundsheet);
                groundsheetValue = groundsheetResult;
                var ropeResult = dbr.GetRecordChecklist(rope);
                ropeValue = ropeResult;
                var trowelResult = dbr.GetRecordChecklist(trowel);
                trowelValue = trowelResult;


            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.Message, ToastLength.Short).Show();
            }

            //implementing the value
            if (backpackValue == "0")
            {
                cbbackpack.Checked = false ;
            }
            else if (backpackValue == "1")
            {
                cbbackpack.Checked = true;
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





            //saving
            Button btnSave = FindViewById<Button>(Resource.Id.btnSave);
            btnSave.Click += (sender, e) =>
            {

                if (cbbackpack.Checked == true)
                {
                    backpackValue = "1";
                }
                else if (cbbackpack.Checked == false)
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

                var result = dbr.InsertRecordChecklist(backpack, backpackValue);
                             dbr.InsertRecordChecklist(boots, bootsValue);
                             dbr.InsertRecordChecklist(plasticbag, plasticbagValue);
                dbr.InsertRecordChecklist(toiletries, toiletriesValue);
                dbr.InsertRecordChecklist(outdoorclothes, outdoorclothesValue);
                dbr.InsertRecordChecklist(trailfood, trailfoodValue);
                dbr.InsertRecordChecklist(packedlunch, packedlunchValue);
                dbr.InsertRecordChecklist(trailwater, trailwaterValue);
                dbr.InsertRecordChecklist(firstaidkit, firstaidkitValue);
                dbr.InsertRecordChecklist(survivalkit, survivalkitValue);
                dbr.InsertRecordChecklist(messkit, messkitValue);
                dbr.InsertRecordChecklist(drinkingcup, drinkingcupValue);
                dbr.InsertRecordChecklist(spoonfork, spoonforkValue);
                dbr.InsertRecordChecklist(identification, identificationValue);
                dbr.InsertRecordChecklist(whistle, whistleValue);
                dbr.InsertRecordChecklist(raingear, raingearValue);
                dbr.InsertRecordChecklist(jacket, jacketValue);
                dbr.InsertRecordChecklist(sunprotection, sunprotectionValue);
                dbr.InsertRecordChecklist(flashlight, flashlightValue);
                dbr.InsertRecordChecklist(multitool, multitoolValue);
                dbr.InsertRecordChecklist(mobilephone, mobilephoneValue);
                dbr.InsertRecordChecklist(camerabatteries, camerabatteriesValue);
                dbr.InsertRecordChecklist(trekkingpole, trekkingpoleValue);
                dbr.InsertRecordChecklist(blanket, blanketValue);
                dbr.InsertRecordChecklist(extraclothes, extraclothesValue);
                dbr.InsertRecordChecklist(sandals, sandalsValue);
                dbr.InsertRecordChecklist(campwater, campwaterValue);
                dbr.InsertRecordChecklist(precookfood, precookfoodValue);
                dbr.InsertRecordChecklist(rice, riceValue);
                dbr.InsertRecordChecklist(tyingstring, tyingstringValue);
                dbr.InsertRecordChecklist(stovefuel, stovefuelValue);
                dbr.InsertRecordChecklist(lighter, lighterValue);
                dbr.InsertRecordChecklist(matches, matchesValue);
                dbr.InsertRecordChecklist(bolo, boloValue);
                dbr.InsertRecordChecklist(mapcompass, mapcompassValue);
                dbr.InsertRecordChecklist(stove, stoveValue);
                dbr.InsertRecordChecklist(cookset, cooksetValue);
                dbr.InsertRecordChecklist(flag, flagValue);
                dbr.InsertRecordChecklist(tent, tentValue);
                dbr.InsertRecordChecklist(groundsheet, groundsheetValue);
                dbr.InsertRecordChecklist(rope, ropeValue);
                dbr.InsertRecordChecklist(trowel, trowelValue);



                Toast.MakeText(this, result, ToastLength.Short).Show();
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
                Finish();
            };
            
        }
    }
}