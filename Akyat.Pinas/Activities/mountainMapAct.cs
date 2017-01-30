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
using CameraPosition = Android.Gms.Maps.Model.CameraPosition;

namespace Akyat.Pinas.Activities
{
    [Activity(Theme = "@style/Theme.NoTitle", Label = "MountainMapAct")]
    public class MountainMapAct : Activity, ILocationListener, IOnInfoWindowClickListener
    {
        static readonly string TAG = "X:" + typeof(MountainMapAct).Name;
        TextView _addressText;
        Location _currentLocation;
        LocationManager _locationManager;

        string _locationProvider;
        String _locationText;

        Double latitude;
        Double longitude;

        Marker markerApo;
        Marker markerArayat;
        Marker markerDULANGDULANG;
        Marker markerHamiguitan;
        Marker markerKanlaon;
        Marker markerKitanglad;
        Marker markerLubog;
        Marker markerMaculot;
        Marker markerMadjaas;
        Marker yourLocation;
        Marker markerOsmenaPeak;
        Marker markerPamitinan;
        Marker markerPicoDeLoro;
        Marker markerPulag;
        Marker markerTaalVolcano;
        Marker markerBatulao;
        Marker markerTarakRidge;
        Marker markerTayakHill;
        Marker markerTalamitam;
        Marker markerCristobal;
        Marker markerUlap;
        Marker markerMakiling;
        Marker markerMatalingajan;
        Marker markerManabuPeak;
        Marker markerMatutum;
                Marker markerBINACAYAN;
        Marker markerCANDALAGA;
        Marker markerHibokHibok;
                      Marker markerKalatungan;
                     Marker markerGuitingGuiting;
                      Marker markerHalcon;
        Marker markerAltoPeak;




        public void OnLocationChanged(Location location)
        {
            _currentLocation = location;



            if (_currentLocation == null)
            {
                Toast.MakeText(this, "current location not available", ToastLength.Short).Show();
            }
            else
            {
                _locationText = string.Format("{0:f6},{1:f6}", _currentLocation.Latitude, _currentLocation.Longitude);
                latitude = _currentLocation.Latitude;
                longitude = _currentLocation.Longitude;

                MapFragment mapFrag = (MapFragment)FragmentManager.FindFragmentById(Resource.Id.map);
                GoogleMap map = mapFrag.Map;
                map.Clear();

                map.SetOnInfoWindowClickListener(this);


                markerAltoPeak = map.AddMarker(new MarkerOptions()
   
.SetPosition(new LatLng(11.1061, 124.7097))
             .SetTitle("Mt. AltoPeak")
         .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));



            markerApo =  map.AddMarker(new MarkerOptions()
                .SetPosition(new LatLng(7.030, 125.1633))
             .SetTitle("Mt. Apo")
        .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));


                markerArayat= map.AddMarker(new MarkerOptions()
     .SetPosition(new LatLng(15.20, 120.742))
             .SetTitle("Mt. Arayat")
                .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));



           
                markerDULANGDULANG = map.AddMarker(new MarkerOptions()
              .SetPosition(new LatLng(8.09798, 124.9605))
              .SetTitle("Mt. DULANGDULANG")
              .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));



              
            markerBINACAYAN = map.AddMarker(new MarkerOptions()
            .SetPosition(new LatLng(14.43305, 121.11261))
              .SetTitle("Mt. Binacayan")
              .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

               markerCANDALAGA = map.AddMarker(new MarkerOptions()
            .SetPosition(new LatLng(7.210, 126.438))
             .SetTitle("Mt. Candalaga")
             .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

             markerHibokHibok = map.AddMarker(new MarkerOptions()
               .SetPosition(new LatLng(9.122, 124.405)) 
              .SetTitle("Mt. Hibok Hibok") 
               .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

                markerKalatungan = map.AddMarker(new MarkerOptions()
               .SetPosition(new LatLng(7.5718, 124.4809))
                .SetTitle("Mt. Kalatungan")
                .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

              markerGuitingGuiting = map.AddMarker(new MarkerOptions()
               .SetPosition(new LatLng(12.2450, 122.3244))
                .SetTitle("Mt. GuitingGuiting")
               .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));
  markerHalcon = map.AddMarker(new MarkerOptions()
              .SetPosition(new LatLng(13.15749, 120.59703))
               .SetTitle("Mt. Halcon")
              .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

             markerHamiguitan = map.AddMarker(new MarkerOptions()
                .SetPosition(new LatLng(6.745, 126.174))
             .SetTitle("Mt. Hamiguitan")
              .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

               


             markerKanlaon = map.AddMarker(new MarkerOptions()
              .SetPosition(new LatLng(10.2444, 123.755))
       .SetTitle("Mt. Kanlaon")
      .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

               markerKitanglad = map.AddMarker(new MarkerOptions()
.SetPosition(new LatLng(8.82, 124.470))
              .SetTitle("Mt. Kitanglad")
               .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

              markerLubog = map.AddMarker(new MarkerOptions()
        .SetPosition(new LatLng(14.50104, 121.14129))
               .SetTitle("Mt. Lubog")
  .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

                 markerMaculot = map.AddMarker(new MarkerOptions()
             .SetPosition(new LatLng(13.55, 121))
               .SetTitle("Mt. Maculot")
               .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

               markerMadjaas = map.AddMarker(new MarkerOptions()
                .SetPosition(new LatLng(11.38932, 122.1619))
               .SetTitle("Mt. Madjaas")
                .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

               markerMatalingajan = map.AddMarker(new MarkerOptions()
                .SetPosition(new LatLng(8.48, 117.40))
              .SetTitle("Mt. Matalingajan")
              .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));
 markerManabuPeak = map.AddMarker(new MarkerOptions()
                .SetPosition(new LatLng(13.9777, 121.2413))
                .SetTitle("Mt. Manabu Peak")
               .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));


 markerMatutum = map.AddMarker(new MarkerOptions()
             .SetPosition(new LatLng(6.22, 125.065))
              .SetTitle("Mt. Matutum")
                .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

             markerOsmenaPeak = map.AddMarker(new MarkerOptions()
             .SetPosition(new LatLng(09.49209, 123.26541))
                .SetTitle("Mt. Osmena Peak")
              .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

             
                markerPamitinan = map.AddMarker(new MarkerOptions()
               .SetPosition(new LatLng(14.43517, 121.11292))
             .SetTitle("Mt. Pamitinan")
               .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

              markerPicoDeLoro = map.AddMarker(new MarkerOptions()
              .SetPosition(new LatLng(14.12855, 120.38785))
                .SetTitle("Mt. Pico De Loro")
             .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

              markerPulag = map.AddMarker(new MarkerOptions()
               .SetPosition(new LatLng(16.3458, 120.5315))
               .SetTitle("Mt. Pulag")
               .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));
             markerTaalVolcano = map.AddMarker(new MarkerOptions()
                .SetPosition(new LatLng(14.00, 120.591))
                .SetTitle("Mt. Taal Volcano")
         .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));
                markerTarakRidge = map.AddMarker(new MarkerOptions()
               .SetPosition(new LatLng(14.30357, 120.30))
                .SetTitle("Mt. Tarak Ridge")
               .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));
              markerTayakHill = map.AddMarker(new MarkerOptions()
              .SetPosition(new LatLng(14.0688, 121.420))
               .SetTitle("Mt. Tayak Hill")
               .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

              markerTalamitam = map.AddMarker(new MarkerOptions()
               .SetPosition(new LatLng(14.1078900, 120.7597300))
            .SetTitle("Mt. Talamitam")
                .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));


               markerBatulao = map.AddMarker(new MarkerOptions()
              .SetPosition(new LatLng(14.0408, 120.8011))
              .SetTitle("Mt. Batulao")
                .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

               markerMakiling = map.AddMarker(new MarkerOptions()
       .SetPosition(new LatLng(14.13, 121.2))
             .SetTitle("Mt. Makiling")
             .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

              markerCristobal = map.AddMarker(new MarkerOptions()
               .SetPosition(new LatLng(14.0635, 121.4113))
               .SetTitle("Mt. Cristobal")
               .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

               markerUlap = map.AddMarker(new MarkerOptions()
                .SetPosition(new LatLng(16.29, 120.6309))
              .SetTitle("Mt. Ulap")
                .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));




                Marker yourLocation = map.AddMarker(new MarkerOptions()
              .SetPosition(new LatLng(latitude, longitude))
               .SetTitle("Your Location")
               .SetSnippet(_locationText)
  .SetIcon(BitmapDescriptorFactory.FromResource(Resource.Drawable.findlocation)));
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


                markerApo = map.AddMarker(new MarkerOptions()
                    .SetPosition(new LatLng(7.030, 125.1633))
                 .SetTitle("Mt. Apo")
            .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));


                markerArayat = map.AddMarker(new MarkerOptions()
     .SetPosition(new LatLng(15.20, 120.742))
             .SetTitle("Mt. Arayat")
                .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));




                markerDULANGDULANG = map.AddMarker(new MarkerOptions()
              .SetPosition(new LatLng(8.09798, 124.9605))
              .SetTitle("Mt. DULANGDULANG")
              .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));




                markerBINACAYAN = map.AddMarker(new MarkerOptions()
                .SetPosition(new LatLng(14.43305, 121.11261))
                  .SetTitle("Mt. Binacayan")
                  .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

                markerCANDALAGA = map.AddMarker(new MarkerOptions()
             .SetPosition(new LatLng(7.210, 126.438))
              .SetTitle("Mt. Candalaga")
              .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

                markerHibokHibok = map.AddMarker(new MarkerOptions()
                  .SetPosition(new LatLng(9.122, 124.405))
                 .SetTitle("Mt. Hibok Hibok")
                  .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

                markerKalatungan = map.AddMarker(new MarkerOptions()
               .SetPosition(new LatLng(7.5718, 124.4809))
                .SetTitle("Mt. Kalatungan")
                .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

                markerGuitingGuiting = map.AddMarker(new MarkerOptions()
                 .SetPosition(new LatLng(12.2450, 122.3244))
                  .SetTitle("Mt. GuitingGuiting")
                 .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));
                markerHalcon = map.AddMarker(new MarkerOptions()
                            .SetPosition(new LatLng(13.15749, 120.59703))
                             .SetTitle("Mt. Halcon")
                            .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

                markerHamiguitan = map.AddMarker(new MarkerOptions()
                   .SetPosition(new LatLng(6.745, 126.174))
                .SetTitle("Mt. Hamiguitan")
                 .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));




                markerKanlaon = map.AddMarker(new MarkerOptions()
                 .SetPosition(new LatLng(10.2444, 123.755))
          .SetTitle("Mt. Kanlaon")
         .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

                markerKitanglad = map.AddMarker(new MarkerOptions()
 .SetPosition(new LatLng(8.82, 124.470))
               .SetTitle("Mt. Kitanglad")
                .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

                markerLubog = map.AddMarker(new MarkerOptions()
          .SetPosition(new LatLng(14.50104, 121.14129))
                 .SetTitle("Mt. Lubog")
    .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

                markerMaculot = map.AddMarker(new MarkerOptions()
            .SetPosition(new LatLng(13.55, 121))
              .SetTitle("Mt. Maculot")
              .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

                markerMadjaas = map.AddMarker(new MarkerOptions()
                 .SetPosition(new LatLng(11.38932, 122.1619))
                .SetTitle("Mt. Madjaas")
                 .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

                markerMatalingajan = map.AddMarker(new MarkerOptions()
                 .SetPosition(new LatLng(8.48, 117.40))
               .SetTitle("Mt. Matalingajan")
               .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));
                markerManabuPeak = map.AddMarker(new MarkerOptions()
                               .SetPosition(new LatLng(13.9777, 121.2413))
                               .SetTitle("Mt. Manabu Peak")
                              .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));


                markerMatutum = map.AddMarker(new MarkerOptions()
                            .SetPosition(new LatLng(6.22, 125.065))
                             .SetTitle("Mt. Matutum")
                               .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

                markerOsmenaPeak = map.AddMarker(new MarkerOptions()
                .SetPosition(new LatLng(09.49209, 123.26541))
                   .SetTitle("Mt. Osmena Peak")
                 .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));


               markerPamitinan = map.AddMarker(new MarkerOptions()
               .SetPosition(new LatLng(14.43517, 121.11292))
             .SetTitle("Mt. Pamitinan")
               .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

              markerPicoDeLoro = map.AddMarker(new MarkerOptions()
              .SetPosition(new LatLng(14.12855, 120.38785))
                .SetTitle("Mt. Pico De Loro")
             .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

                markerPulag = map.AddMarker(new MarkerOptions()
               .SetPosition(new LatLng(16.3458, 120.5315))
               .SetTitle("Mt. Pulag")
               .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));
                markerTaalVolcano = map.AddMarker(new MarkerOptions()
                .SetPosition(new LatLng(14.00, 120.591))
                .SetTitle("Mt. Taal Volcano")
         .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));
               markerTarakRidge = map.AddMarker(new MarkerOptions()
               .SetPosition(new LatLng(14.30357, 120.30))
                .SetTitle("Mt. Tarak Ridge")
               .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));
               markerTayakHill = map.AddMarker(new MarkerOptions()
              .SetPosition(new LatLng(14.0688, 121.420))
               .SetTitle("Mt. Tayak Hill")
               .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

                 markerTalamitam = map.AddMarker(new MarkerOptions()
               .SetPosition(new LatLng(14.1078900, 120.7597300))
            .SetTitle("Mt. Talamitam")
                .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));


                markerBatulao = map.AddMarker(new MarkerOptions()
              .SetPosition(new LatLng(14.0408, 120.8011))
              .SetTitle("Mt. Batulao")
                .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

                markerMakiling = map.AddMarker(new MarkerOptions()
       .SetPosition(new LatLng(14.13, 121.2))
             .SetTitle("Mt. Makiling")
             .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

                markerCristobal = map.AddMarker(new MarkerOptions()
               .SetPosition(new LatLng(14.0635, 121.4113))
               .SetTitle("Mt. Cristobal")
               .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

                markerUlap = map.AddMarker(new MarkerOptions()
                .SetPosition(new LatLng(16.29, 120.6309))
              .SetTitle("Mt. Ulap")
                .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));




                 yourLocation = map.AddMarker(new MarkerOptions()
              .SetPosition(new LatLng(latitude, longitude))
               .SetTitle("Your Location")
               .SetSnippet(_locationText)
  .SetIcon(BitmapDescriptorFactory.FromResource(Resource.Drawable.findlocation)));



            }






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

        public void OnInfoWindowClick(Marker marker)
        {

            if (marker.Equals(markerAltoPeak))
            {

                var intent = new Intent(this, typeof(MountainListAct));
                intent.PutExtra("mtDataPos", 0);
                StartActivity(intent);

            }

          else  if (marker.Equals(markerApo))
            {

                var intent = new Intent(this, typeof(MountainListAct));
                intent.PutExtra("mtDataPos", 1);
                StartActivity(intent);

            }
            else if (marker.Equals(markerArayat))
            {

                var intent = new Intent(this, typeof(MountainListAct));
                intent.PutExtra("mtDataPos", 2);
                StartActivity(intent);

            }
            else if (marker.Equals(markerDULANGDULANG))
            {

                var intent = new Intent(this, typeof(MountainListAct));
                intent.PutExtra("mtDataPos", 9);
                StartActivity(intent);

            }
            else if (marker.Equals(markerGuitingGuiting))
            {

                var intent = new Intent(this, typeof(MountainListAct));
                intent.PutExtra("mtDataPos", 10);
                StartActivity(intent);

            }
            else if (marker.Equals(markerHalcon))
            {

                var intent = new Intent(this, typeof(MountainListAct));
                intent.PutExtra("mtDataPos", 11);
                StartActivity(intent);

            }
            else if (marker.Equals(markerHamiguitan))
            {

                var intent = new Intent(this, typeof(MountainListAct));
                intent.PutExtra("mtDataPos", 12);
                StartActivity(intent);

            }

            else if (marker.Equals(markerHibokHibok))
            {

                var intent = new Intent(this, typeof(MountainListAct));
                intent.PutExtra("mtDataPos", 13);
                StartActivity(intent);

            }
            else if (marker.Equals(markerKalatungan))
            {

                var intent = new Intent(this, typeof(MountainListAct));
                intent.PutExtra("mtDataPos", 14);
                StartActivity(intent);

            }
            else if (marker.Equals(markerKanlaon))
            {

                var intent = new Intent(this, typeof(MountainListAct));
                intent.PutExtra("mtDataPos", 15);
                StartActivity(intent);

            }

            else if (marker.Equals(markerKitanglad))
            {

                var intent = new Intent(this, typeof(MountainListAct));
                intent.PutExtra("mtDataPos", 16);
                StartActivity(intent);

            }
            else if (marker.Equals(markerLubog))
            {

                var intent = new Intent(this, typeof(MountainListAct));
                intent.PutExtra("mtDataPos", 17);
                StartActivity(intent);

            }
            else if (marker.Equals(markerMaculot))
            {

                var intent = new Intent(this, typeof(MountainListAct));
                intent.PutExtra("mtDataPos", 18);
                StartActivity(intent);

            }
            else if (marker.Equals(markerMadjaas))
            {

                var intent = new Intent(this, typeof(MountainListAct));
                intent.PutExtra("mtDataPos", 19);
                StartActivity(intent);

            }
            else if (marker.Equals(markerMakiling))
            {

                var intent = new Intent(this, typeof(MountainListAct));
                intent.PutExtra("mtDataPos", 20);
                StartActivity(intent);

            }
            else if (marker.Equals(markerManabuPeak))
            {

                var intent = new Intent(this, typeof(MountainListAct));
                intent.PutExtra("mtDataPos", 21);
                StartActivity(intent);

            }
            else if (marker.Equals(markerMatalingajan))
            {

                var intent = new Intent(this, typeof(MountainListAct));
                intent.PutExtra("mtDataPos", 22);
                StartActivity(intent);

            }
            else if (marker.Equals(markerMatutum))
            {

                var intent = new Intent(this, typeof(MountainListAct));
                intent.PutExtra("mtDataPos", 24);
                StartActivity(intent);

            }
            else if (marker.Equals(markerOsmenaPeak))
            {

                var intent = new Intent(this, typeof(MountainListAct));
                intent.PutExtra("mtDataPos", 26);
                StartActivity(intent);

            }
            else if (marker.Equals(markerPamitinan))
            {

                var intent = new Intent(this, typeof(MountainListAct));
                intent.PutExtra("mtDataPos", 27);
                StartActivity(intent);

            }

            else if (marker.Equals(markerPicoDeLoro))
            {

                var intent = new Intent(this, typeof(MountainListAct));
                intent.PutExtra("mtDataPos", 28);
                StartActivity(intent);

            }

            else if (marker.Equals(markerPulag))
            {

                var intent = new Intent(this, typeof(MountainListAct));
                intent.PutExtra("mtDataPos", 29);
                StartActivity(intent);

            }
            else if (marker.Equals(markerTaalVolcano))
            {

                var intent = new Intent(this, typeof(MountainListAct));
                intent.PutExtra("mtDataPos", 31);
                StartActivity(intent);

            }
            else if (marker.Equals(markerTalamitam))
            {

                var intent = new Intent(this, typeof(MountainListAct));
                intent.PutExtra("mtDataPos", 32);
                StartActivity(intent);

            }
            else if (marker.Equals(markerTarakRidge))
            {

                var intent = new Intent(this, typeof(MountainListAct));
                intent.PutExtra("mtDataPos", 34);
                StartActivity(intent);

            }
            else if (marker.Equals(markerCANDALAGA))
            {
                var intent = new Intent(this, typeof(MountainListAct));
                intent.PutExtra("mtDataPos", 7);
                StartActivity(intent);
            }

            else if (marker.Equals(markerCristobal))
            {

                var intent = new Intent(this, typeof(MountainListAct));
                intent.PutExtra("mtDataPos", 8);
                StartActivity(intent);
            }
           
            else if (marker.Equals(markerBatulao))
            {
                var intent = new Intent(this, typeof(MountainListAct));
                intent.PutExtra("mtDataPos", 5);
                StartActivity(intent);
            }
            else if (marker.Equals(markerBINACAYAN))
            {
                var intent = new Intent(this, typeof(MountainListAct));
                intent.PutExtra("mtDataPos", 6);
                StartActivity(intent);

            }
            else if (marker.Equals(markerTayakHill))
            {

                var intent = new Intent(this, typeof(MountainListAct));
                intent.PutExtra("mtDataPos",35);
                StartActivity(intent);

            }
            else if (marker.Equals(markerUlap))
            {

                var intent = new Intent(this, typeof(MountainListAct));
                intent.PutExtra("mtDataPos", 37);
                StartActivity(intent);
            }

        }
    }
}