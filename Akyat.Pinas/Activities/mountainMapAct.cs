using System;



using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Akyat.Pinas.ORM;

using Android.Locations;
using Android.Util;
using System.Collections.Generic;
using System.Linq;
using static Android.Gms.Maps.GoogleMap;

namespace Akyat.Pinas.Activities
{
    [Activity(Theme = "@style/Theme.NoTitle", Label = "MountainMapAct")]
    public class MountainMapAct : Activity, ILocationListener ,IOnInfoWindowClickListener
    {
        static readonly string TAG = "X:" + typeof(MountainMapAct).Name;
        TextView _addressText;
        Location _currentLocation;
        LocationManager _locationManager;

        string _locationProvider;
        String _locationText;

 Double latitude;
   Double longitude;


        


        public void OnLocationChanged(Location location)
        {
            _currentLocation = location;



            if (_currentLocation == null)
            {
                Toast.MakeText(this,"current location not available", ToastLength.Short).Show();
            }
            else
            {
                _locationText = string.Format("{0:f6},{1:f6}", _currentLocation.Latitude, _currentLocation.Longitude);
                latitude = _currentLocation.Latitude;
            longitude = _currentLocation.Longitude;

                MapFragment mapFrag = (MapFragment)FragmentManager.FindFragmentById(Resource.Id.map);
                GoogleMap map = mapFrag.Map;
                map.SetOnInfoWindowClickListener(this);

                MarkerOptions markerAltoPeak = new MarkerOptions();
                markerAltoPeak.SetPosition(new LatLng(11.1061, 124.7097));
                markerAltoPeak.SetTitle("Mt. AltoPeak");
                markerAltoPeak.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));



                MarkerOptions markerApo = new MarkerOptions();
                markerApo.SetPosition(new LatLng(7.030, 125.1633));
                markerApo.SetTitle("Mt. Apo");
                markerApo.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

                MarkerOptions markerArayat = new MarkerOptions();
                markerArayat.SetPosition(new LatLng(15.20, 120.742));
                markerArayat.SetTitle("Mt. Arayat");
                markerArayat.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));



                MarkerOptions markerDULANGDULANG = new MarkerOptions();
                markerDULANGDULANG.SetPosition(new LatLng(8.09798, 124.9605));
                markerDULANGDULANG.SetTitle("Mt. DULANGDULANG");
                markerDULANGDULANG.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));




                MarkerOptions markerBINACAYAN = new MarkerOptions();
                markerBINACAYAN.SetPosition(new LatLng(14.43305, 121.11261));
                markerBINACAYAN.SetTitle("Mt. Binacayan");
                markerBINACAYAN.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

                MarkerOptions markerCANDALAGA = new MarkerOptions();
                markerCANDALAGA.SetPosition(new LatLng(7.210, 126.438));
                markerCANDALAGA.SetTitle("Mt. Candalaga");
                markerCANDALAGA.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

                MarkerOptions markerHibokHibok = new MarkerOptions();
                markerHibokHibok.SetPosition(new LatLng(9.122, 124.405));
                markerHibokHibok.SetTitle("Mt. Hibok Hibok");
                markerHibokHibok.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

                MarkerOptions markerKalatungan = new MarkerOptions();
                markerKalatungan.SetPosition(new LatLng(7.5718, 124.4809));
                markerKalatungan.SetTitle("Mt. Kalatungan");
                markerKalatungan.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

                MarkerOptions markerGuitingGuiting = new MarkerOptions();
                markerGuitingGuiting.SetPosition(new LatLng(12.2450, 122.3244));
                markerGuitingGuiting.SetTitle("Mt. GuitingGuiting");
                markerGuitingGuiting.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

                MarkerOptions markerHalcon = new MarkerOptions();
                markerHalcon.SetPosition(new LatLng(13.15749, 120.59703));
                markerHalcon.SetTitle("Mt. Halcon");
                markerHalcon.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

                MarkerOptions markerHamiguitan = new MarkerOptions();
                markerHamiguitan.SetPosition(new LatLng(6.745, 126.174));
                markerHamiguitan.SetTitle("Mt. Hamiguitan");
                markerHamiguitan.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

                MarkerOptions markerKanlaon = new MarkerOptions();
                markerKanlaon.SetPosition(new LatLng(10.2444, 123.755));
                markerKanlaon.SetTitle("Mt. Kanlaon");
                markerKanlaon.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

                MarkerOptions markerKitanglad = new MarkerOptions();
                markerKitanglad.SetPosition(new LatLng(8.82, 124.470));
                markerKitanglad.SetTitle("Mt. Kitanglad");
                markerKitanglad.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));
               
                MarkerOptions markerLubog = new MarkerOptions();
                markerLubog.SetPosition(new LatLng(14.50104, 121.14129));
                markerLubog.SetTitle("Mt. Lubog");
                markerLubog.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

                MarkerOptions markerMaculot = new MarkerOptions();
                markerMaculot.SetPosition(new LatLng(13.55, 121));
                markerMaculot.SetTitle("Mt. Maculot");
                markerMaculot.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

                MarkerOptions markerMadjaas = new MarkerOptions();
                markerMadjaas.SetPosition(new LatLng(11.38932, 122.1619));
                markerMadjaas.SetTitle("Mt. Madjaas");
                markerMadjaas.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

                MarkerOptions markerMatalingajan = new MarkerOptions();
                markerMatalingajan.SetPosition(new LatLng(8.48, 117.40));
                markerMatalingajan.SetTitle("Mt. Matalingajan");
                markerMatalingajan.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

                MarkerOptions markerManabuPeak = new MarkerOptions();
                markerManabuPeak.SetPosition(new LatLng(13.9777, 121.2413));
                markerManabuPeak.SetTitle("Mt. Manabu Peak");
                markerManabuPeak.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));




                MarkerOptions markerMatutum = new MarkerOptions();
                markerMatutum.SetPosition(new LatLng(6.22, 125.065));
                markerMatutum.SetTitle("Mt. Matutum");
                markerMatutum.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

                MarkerOptions markerOsmenaPeak = new MarkerOptions();
                markerOsmenaPeak.SetPosition(new LatLng(09.49209, 123.26541));
                markerOsmenaPeak.SetTitle("Mt. Osmena Peak");
                markerOsmenaPeak.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));


                MarkerOptions markerPamitinan = new MarkerOptions();
                markerPamitinan.SetPosition(new LatLng(14.43517, 121.11292));
                markerPamitinan.SetTitle("Mt. Pamitinan");
                markerPamitinan.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

                MarkerOptions markerPicoDeLoro = new MarkerOptions();
                markerPicoDeLoro.SetPosition(new LatLng(14.12855, 120.38785));
                markerPicoDeLoro.SetTitle("Mt. Pico De Loro");
                markerPicoDeLoro.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

                MarkerOptions markerPulag = new MarkerOptions();
                markerPulag.SetPosition(new LatLng(16.3458, 120.5315));
                markerPulag.SetTitle("Mt. Pulag");
                markerPulag.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));
                MarkerOptions markerTaalVolcano = new MarkerOptions();
                markerTaalVolcano.SetPosition(new LatLng(14.00, 120.591));
                markerTaalVolcano.SetTitle("Mt. Taal Volcano");
                markerTaalVolcano.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));
                MarkerOptions markerTarakRidge = new MarkerOptions();
                markerTarakRidge.SetPosition(new LatLng(14.30357, 120.30));
                markerTarakRidge.SetTitle("Mt. Tarak Ridge");
                markerTarakRidge.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));
                MarkerOptions markerTayakHill = new MarkerOptions();
                markerTayakHill.SetPosition(new LatLng(14.0688, 121.420));
                markerTayakHill.SetTitle("Mt. Tayak Hill");
                markerTayakHill.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

                MarkerOptions markerTalamitam = new MarkerOptions();
                markerTalamitam.SetPosition(new LatLng(14.1078900, 120.7597300));
                markerTalamitam.SetTitle("Mt. Talamitam");
                markerTalamitam.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));


                MarkerOptions markerBatulao = new MarkerOptions();
                markerBatulao.SetPosition(new LatLng(14.0408, 120.8011));
                markerBatulao.SetTitle("Mt. Batulao");
                markerBatulao.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

                MarkerOptions markerMakiling = new MarkerOptions();
                markerMakiling.SetPosition(new LatLng(14.13, 121.2));
                markerMakiling.SetTitle("Mt. Makiling");
                markerMakiling.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

                MarkerOptions markerCristobal = new MarkerOptions();
                markerCristobal.SetPosition(new LatLng(14.0635, 121.4113));
                markerCristobal.SetTitle("Mt. Cristobal");
                markerCristobal.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

                MarkerOptions markerUlap = new MarkerOptions();
                markerUlap.SetPosition(new LatLng(16.29, 120.6309));
                markerUlap.SetTitle("Mt. Ulap");
                markerUlap.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));




                MarkerOptions yourLocation = new MarkerOptions();
                yourLocation.SetPosition(new LatLng(latitude, longitude));
                yourLocation.SetTitle("Your Location");
                yourLocation.SetSnippet(_locationText);

                yourLocation.SetIcon(BitmapDescriptorFactory.FromResource(Resource.Drawable.findlocation));


                map.Clear();
                    
                    map.AddMarker(yourLocation);




                    map.AddMarker(markerMaculot);
                    map.AddMarker(markerMadjaas);
                    map.AddMarker(markerMatalingajan);
                    map.AddMarker(markerManabuPeak);
                    map.AddMarker(markerMatutum);
                    map.AddMarker(markerOsmenaPeak);
                    map.AddMarker(markerAltoPeak);
                    map.AddMarker(markerApo);
                    map.AddMarker(markerArayat);
                    map.AddMarker(markerDULANGDULANG);
                    map.AddMarker(markerBINACAYAN);
                    map.AddMarker(markerCANDALAGA);
                    map.AddMarker(markerHibokHibok);
                    map.AddMarker(markerKalatungan);
                    map.AddMarker(markerGuitingGuiting);
                    map.AddMarker(markerHalcon);
                    map.AddMarker(markerHamiguitan);
                    map.AddMarker(markerKanlaon);
                    map.AddMarker(markerKitanglad);
                    map.AddMarker(markerPamitinan);

                    map.AddMarker(markerPicoDeLoro);
                    map.AddMarker(markerPulag);
                    map.AddMarker(markerTaalVolcano);
                    map.AddMarker(markerTarakRidge);
                    map.AddMarker(markerTayakHill);

                    map.AddMarker(markerLubog);
                    map.AddMarker(markerTalamitam);
                    map.AddMarker(markerBatulao);
                    map.AddMarker(markerMakiling);
                    map.AddMarker(markerUlap);
                    map.AddMarker(markerCristobal);

                }



            }
          
          
        
      

        public void OnProviderDisabled(string provider)
        {
            throw new NotImplementedException();
        }

        public void OnProviderEnabled(string provider)
        {
            throw new NotImplementedException();
        }

        public void OnStatusChanged(string provider, [GeneratedEnum] Availability status, Bundle extras)
        {
            
        }
        protected override void OnResume()
        {
            base.OnResume();
            _locationManager.RequestLocationUpdates(_locationProvider, 0, 0, this);
        }
        protected override void OnPause()
        {
            base.OnPause();
            _locationManager.RemoveUpdates(this);
        }


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.mountainMap);
            //settings database getting records

            InitializeLocationManager();

        


            DBItineraryRepository dbr = new DBItineraryRepository();
            
            var terrain = "terrain";
            var terrainValue = "1";
            var normal = "normal";
            var normalValue = "0";
            var satellite = "satellite";
            var satelliteValue = "0";
            var hybrid = "toiletries";
            var hybridValue = "0";

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
                Toast.MakeText(this, ex.Message, ToastLength.Short).Show();
            }


            MapFragment mapFrag = (MapFragment)FragmentManager.FindFragmentById(Resource.Id.map);
            GoogleMap map = mapFrag.Map;
            map.SetOnInfoWindowClickListener(this);

            // Create your application here

            // position
            LatLng locations = new LatLng(13, 122);
            CameraPosition.Builder builder = CameraPosition.InvokeBuilder();
            builder.Target(locations);
            builder.Zoom(6);
            CameraPosition cameraPosition = builder.Build();
            CameraUpdate cameraUpdate = CameraUpdateFactory.NewCameraPosition(cameraPosition);
           
            //mountainMarkers
            MarkerOptions markerAltoPeak = new MarkerOptions();
            markerAltoPeak.SetPosition(new LatLng(11.1061, 124.7097));
            markerAltoPeak.SetTitle("Mt. AltoPeak");
            markerAltoPeak.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

          

            MarkerOptions markerApo = new MarkerOptions();
            markerApo.SetPosition(new LatLng(7.030, 125.1633));
            markerApo.SetTitle("Mt. Apo");
            markerApo.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

            MarkerOptions markerArayat = new MarkerOptions();
            markerArayat.SetPosition(new LatLng(15.20, 120.742));
            markerArayat.SetTitle("Mt. Arayat");
            markerArayat.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

          

            MarkerOptions markerDULANGDULANG = new MarkerOptions();
            markerDULANGDULANG.SetPosition(new LatLng(8.09798, 124.9605));
            markerDULANGDULANG.SetTitle("Mt. DULANGDULANG");
            markerDULANGDULANG.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

           


            MarkerOptions markerBINACAYAN = new MarkerOptions();
            markerBINACAYAN.SetPosition(new LatLng(14.43305, 121.11261));
            markerBINACAYAN.SetTitle("Mt. Binacayan");
            markerBINACAYAN.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

            MarkerOptions markerCANDALAGA = new MarkerOptions();
            markerCANDALAGA.SetPosition(new LatLng(7.210, 126.438));
            markerCANDALAGA.SetTitle("Mt. Candalaga");
            markerCANDALAGA.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

            MarkerOptions markerHibokHibok = new MarkerOptions();
            markerHibokHibok.SetPosition(new LatLng(9.122, 124.405));
            markerHibokHibok.SetTitle("Mt. Hibok Hibok");
            markerHibokHibok.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

            MarkerOptions markerKalatungan = new MarkerOptions();
            markerKalatungan.SetPosition(new LatLng(7.5718, 124.4809));
            markerKalatungan.SetTitle("Mt. Kalatungan");
            markerKalatungan.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

            MarkerOptions markerGuitingGuiting = new MarkerOptions();
            markerGuitingGuiting.SetPosition(new LatLng(12.2450,  122.3244));
            markerGuitingGuiting.SetTitle("Mt. GuitingGuiting");
            markerGuitingGuiting.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

            MarkerOptions markerHalcon = new MarkerOptions();
            markerHalcon.SetPosition(new LatLng(13.15749 , 120.59703));
            markerHalcon.SetTitle("Mt. Halcon");
            markerHalcon.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

            MarkerOptions markerHamiguitan = new MarkerOptions();
            markerHamiguitan.SetPosition(new LatLng(6.745 , 126.174));
            markerHamiguitan.SetTitle("Mt. Hamiguitan");
            markerHamiguitan.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

            MarkerOptions markerKanlaon = new MarkerOptions();
            markerKanlaon.SetPosition(new LatLng(10.2444 , 123.755));
            markerKanlaon.SetTitle("Mt. Kanlaon");
            markerKanlaon.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

            MarkerOptions markerKitanglad = new MarkerOptions();
            markerKitanglad.SetPosition(new LatLng(8.82 , 124.470));
            markerKitanglad.SetTitle("Mt. Kitanglad");
            markerKitanglad.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

            MarkerOptions markerLubog = new MarkerOptions();
            markerLubog.SetPosition(new LatLng(14.50104 , 121.14129));
            markerLubog.SetTitle("Mt. Lubog");
            markerLubog.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));
          
            MarkerOptions markerMaculot = new MarkerOptions();
            markerMaculot.SetPosition(new LatLng(13.55, 121));
            markerMaculot.SetTitle("Mt. Maculot");
            markerMaculot.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

            MarkerOptions markerMadjaas = new MarkerOptions();
            markerMadjaas.SetPosition(new LatLng(11.38932, 122.1619));
            markerMadjaas.SetTitle("Mt. Madjaas");
            markerMadjaas.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

            MarkerOptions markerMatalingajan = new MarkerOptions();
            markerMatalingajan.SetPosition(new LatLng(8.48 ,117.40));
            markerMatalingajan.SetTitle("Mt. Matalingajan");
            markerMatalingajan.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

            MarkerOptions markerManabuPeak = new MarkerOptions();
            markerManabuPeak.SetPosition(new LatLng(13.9777 , 121.2413));
            markerManabuPeak.SetTitle("Mt. Manabu Peak");
            markerManabuPeak.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));
           
           
         

            MarkerOptions markerMatutum = new MarkerOptions();
            markerMatutum.SetPosition(new LatLng(6.22 , 125.065));
            markerMatutum.SetTitle("Mt. Matutum");
            markerMatutum.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

            MarkerOptions markerOsmenaPeak = new MarkerOptions();
            markerOsmenaPeak.SetPosition(new LatLng(09.49209, 123.26541));
            markerOsmenaPeak.SetTitle("Mt. Osmena Peak");
            markerOsmenaPeak.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));


            MarkerOptions markerPamitinan = new MarkerOptions();
            markerPamitinan.SetPosition(new LatLng(14.43517, 121.11292));
            markerPamitinan.SetTitle("Mt. Pamitinan");
            markerPamitinan.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

            MarkerOptions markerPicoDeLoro = new MarkerOptions();
            markerPicoDeLoro.SetPosition(new LatLng(14.12855 , 120.38785));
            markerPicoDeLoro.SetTitle("Mt. Pico De Loro");
            markerPicoDeLoro.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

            MarkerOptions markerPulag = new MarkerOptions();
            markerPulag.SetPosition(new LatLng(16.3458 , 120.5315));
            markerPulag.SetTitle("Mt. Pulag");
            markerPulag.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));
            MarkerOptions markerTaalVolcano = new MarkerOptions();
            markerTaalVolcano.SetPosition(new LatLng(14.00 , 120.591));
            markerTaalVolcano.SetTitle("Mt. Taal Volcano");
            markerTaalVolcano.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));
            MarkerOptions markerTarakRidge = new MarkerOptions();
            markerTarakRidge.SetPosition(new LatLng(14.30357 , 120.30));
            markerTarakRidge.SetTitle("Mt. Tarak Ridge");
            markerTarakRidge.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));
            MarkerOptions markerTayakHill = new MarkerOptions();
            markerTayakHill.SetPosition(new LatLng(14.0688 , 121.420));
            markerTayakHill.SetTitle("Mt. Tayak Hill");
            markerTayakHill.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));
           
            MarkerOptions markerTalamitam = new MarkerOptions();
            markerTalamitam.SetPosition(new LatLng(14.1078900, 120.7597300));
            markerTalamitam.SetTitle("Mt. Talamitam");
            markerTalamitam.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));
           

            MarkerOptions markerBatulao = new MarkerOptions();
            markerBatulao.SetPosition(new LatLng(14.0408, 120.8011));
            markerBatulao.SetTitle("Mt. Batulao");
            markerBatulao.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

            MarkerOptions markerMakiling = new MarkerOptions();
            markerMakiling.SetPosition(new LatLng(14.13, 121.2));
            markerMakiling.SetTitle("Mt. Makiling");
            markerMakiling.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

            MarkerOptions markerCristobal = new MarkerOptions();
            markerCristobal.SetPosition(new LatLng(14.0635, 121.4113));
            markerCristobal.SetTitle("Mt. Cristobal");
            markerCristobal.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

            MarkerOptions markerUlap = new MarkerOptions();
            markerUlap.SetPosition(new LatLng(16.29, 120.6309));
            markerUlap.SetTitle("Mt. Ulap");
            markerUlap.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));




            MarkerOptions yourLocation = new MarkerOptions();
            yourLocation.SetPosition(new LatLng(latitude, longitude));
            yourLocation.SetTitle("Your Location");
            yourLocation.SetSnippet(_locationText);
            yourLocation.SetIcon(BitmapDescriptorFactory.FromResource(Resource.Drawable.findlocation));


            //   MarkerOptions markerDaraitan = new MarkerOptions();
            //   markerDaraitan.SetPosition(new LatLng(14.6167, 121.4));
            //    markerDaraitan.SetTitle("Mt. Daraitan");
            //    markerDaraitan.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

            //    MarkerOptions markerAyaas = new MarkerOptions();
            //    markerAyaas.SetPosition(new LatLng(14.7511000, 121.2090));
            //    markerAyaas.SetTitle("Mt. Ayaas");
            //    markerAyaas.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));
            //
            //MarkerOptions markerBanahaw = new MarkerOptions();
            //      markerBanahaw.SetPosition(new LatLng(14.7591, 121.0233));
            //      markerBanahaw.SetTitle("Mt. Banahaw");
            //      markerBanahaw.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

            //     MarkerOptions markerBalagbag = new MarkerOptions();
            //    markerBalagbag.SetPosition(new LatLng(14.824, 121.1796));
            //    markerBalagbag.SetTitle("Mt. Balagbag");
            //    markerBalagbag.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

            //MarkerOptions markerDaguldol = new MarkerOptions();
            //   markerDaguldol.SetPosition(new LatLng(13.7572, 121.0581));
            //    markerDaguldol.SetTitle("Mt. Daguldol");
            //  markerDaguldol.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

        


            


            if (map != null)
            {


                map.Clear();
                map.MapType = GoogleMap.MapTypeTerrain;

                if (terrainValue == "1")
                {
                    map.MapType = GoogleMap.MapTypeTerrain;
                }
                else if (normalValue == "1")
                {
                    map.MapType = GoogleMap.MapTypeNormal;
                }
                else if (satelliteValue == "1")
                {
                    map.MapType = GoogleMap.MapTypeSatellite;
                }
                else if (hybridValue == "1")
                {
                    map.MapType = GoogleMap.MapTypeHybrid;
                }
               
                map.UiSettings.ZoomControlsEnabled = true;
                map.UiSettings.CompassEnabled = true;
                map.MoveCamera(cameraUpdate);

                map.AddMarker(yourLocation);



                map.AddMarker(markerMaculot);
                map.AddMarker(markerMadjaas);
                map.AddMarker(markerMatalingajan);
                map.AddMarker(markerManabuPeak);
                map.AddMarker(markerMatutum);
                map.AddMarker(markerOsmenaPeak);
                map.AddMarker(markerAltoPeak);
                map.AddMarker(markerApo);
                map.AddMarker(markerArayat);
                map.AddMarker(markerDULANGDULANG);
                map.AddMarker(markerBINACAYAN);
                map.AddMarker(markerCANDALAGA);
                map.AddMarker(markerHibokHibok);
                map.AddMarker(markerKalatungan);
                map.AddMarker(markerGuitingGuiting);
                map.AddMarker(markerHalcon);
                map.AddMarker(markerHamiguitan);
                map.AddMarker(markerKanlaon);
                map.AddMarker(markerKitanglad);
                map.AddMarker(markerPamitinan);
              
                map.AddMarker(markerPicoDeLoro);
                map.AddMarker(markerPulag);
                map.AddMarker(markerTaalVolcano);
                map.AddMarker(markerTarakRidge);
                map.AddMarker(markerTayakHill);
                
                map.AddMarker(markerLubog);
                map.AddMarker(markerTalamitam);
                map.AddMarker(markerBatulao);
                map.AddMarker(markerMakiling);
                map.AddMarker(markerUlap);
                map.AddMarker(markerCristobal);
              
            }




         

    }


        void IOnInfoWindowClickListener.OnInfoWindowClick(Marker marker)
        {
            var intent = new Intent(this, typeof(MountainListAct));
            intent.PutExtra("mtName", "ALTO PEAK");
            StartActivity(intent);
            

        }

       


        void InitializeLocationManager()
        {
            _locationManager = (LocationManager)GetSystemService(LocationService);
            Criteria criteriaForLocationService = new Criteria
            {
                Accuracy = Accuracy.Fine
            };
            IList<string> acceptableLocationProviders = _locationManager.GetProviders(criteriaForLocationService, true);

            if (acceptableLocationProviders.Any())
            {
                _locationProvider = acceptableLocationProviders.First();
            }
            else
            {
                _locationProvider = string.Empty;
            }
            Log.Debug(TAG, "Using " + _locationProvider + ".");
        }

        
    }
}