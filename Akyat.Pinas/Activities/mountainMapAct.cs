using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
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

        Location _currentLocation;
        LocationManager _locationManager;

        private List<Mountain> mMountains;
        protected MountainsService mountainsRepository;

        string _locationProvider;
        String _locationText;

        Double latitude, longitude;

        Marker markerAltoPeak, markerApo, markerArayat, markerDULANGDULANG, markerHamiguitan, markerKanlaon, markerKitanglad, markerLubog;
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

        Mountain mt = null;
        Marker markerBanoi;
        Marker markerBatolusong;

        Marker markerCandalaga;
        Marker markerMarami;
        Marker markerNapulak;
        Marker markerRomelo;
        Marker markerTalomo;
        Marker markerTresMarias;
        Marker markerVictoria;
        Marker markerWhitePeak;

        Marker marker;

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

                mountainsRepository = new MountainsService();
                mMountains = mountainsRepository.GetAllMountains();

                foreach (Mountain item in mMountains)
                {
                   marker  = map.AddMarker(new MarkerOptions()
                   .SetPosition(new LatLng(item.Lat, item.Lng))
                   .SetTitle(item.MtName)
                   .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));
                }
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

            }

            MapFragment mapFrag = (MapFragment)FragmentManager.FindFragmentById(Resource.Id.map);
            GoogleMap map = mapFrag.Map;
            map.SetOnInfoWindowClickListener(this);

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

                mountainsRepository = new MountainsService();
                mMountains = mountainsRepository.GetAllMountains();

                foreach (Mountain item in mMountains)
                {

             marker = map.AddMarker(new MarkerOptions()
             .SetPosition(new LatLng(item.Lat, item.Lng))
             .SetTitle(item.MtName)
             .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow)));

                }
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
            if (marker.Equals(marker))
            {
                foreach (Mountain item in mMountains)
                {
                   
                    if (marker.Title == item.MtName)
                    { 
                    var intent = new Intent(this, typeof(MountainListAct));
                    intent.PutExtra("mtDataPos", mMountains.IndexOf(item));
                    StartActivity(intent);
                    Finish();

                    }
                }
            }
        }

        public override void OnBackPressed()
        {
            var intent = new Intent(this, typeof(MainMenuAct));
            StartActivity(intent);
            OverridePendingTransition(Resource.Animation.fade_in, Resource.Animation.fade_out);
            intent.SetFlags(ActivityFlags.ClearTop);
            Finish();
        }
    }
}