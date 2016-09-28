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
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Akyat.Pinas.ORM;

namespace Akyat.Pinas.Activities
{
    [Activity(Theme = "@style/Theme.NoTitle", Label = "MountainMapAct")]
    public class MountainMapAct : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.mountainMap);
            //settings database getting records
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

           



            // Create your application here

            // position
            LatLng location = new LatLng(13, 122);
            CameraPosition.Builder builder = CameraPosition.InvokeBuilder();
            builder.Target(location);
            builder.Zoom(6);
            CameraPosition cameraPosition = builder.Build();
            CameraUpdate cameraUpdate = CameraUpdateFactory.NewCameraPosition(cameraPosition);

            //mountainMarkers
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

            MarkerOptions markerDaraitan = new MarkerOptions();
            markerDaraitan.SetPosition(new LatLng(14.6167, 121.4));
            markerDaraitan.SetTitle("Mt. Daraitan");
            markerDaraitan.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

            MarkerOptions markerAyaas = new MarkerOptions();
            markerAyaas.SetPosition(new LatLng(14.7511000, 121.2090));
            markerAyaas.SetTitle("Mt. Ayaas");
            markerAyaas.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

            MarkerOptions markerBanahaw = new MarkerOptions();
            markerBanahaw.SetPosition(new LatLng(14.7591, 121.0233));
            markerBanahaw.SetTitle("Mt. Banahaw");
            markerBanahaw.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

            MarkerOptions markerBalagbag = new MarkerOptions();
            markerBalagbag.SetPosition(new LatLng(14.824, 121.1796));
            markerBalagbag.SetTitle("Mt. Balagbag");
            markerBalagbag.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));

            MarkerOptions markerDaguldol = new MarkerOptions();
            markerDaguldol.SetPosition(new LatLng(13.7572, 121.0581));
            markerDaguldol.SetTitle("Mt. Daguldol");
            markerDaguldol.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));


            MapFragment mapFrag = (MapFragment)FragmentManager.FindFragmentById(Resource.Id.map);
            GoogleMap map = mapFrag.Map;
            
            

            if (map != null)
            {


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

                map.AddMarker(markerTalamitam);
                map.AddMarker(markerBatulao);
                map.AddMarker(markerMakiling);
                map.AddMarker(markerUlap);
                map.AddMarker(markerCristobal);
                map.AddMarker(markerAyaas);
                map.AddMarker(markerBalagbag);
                map.AddMarker(markerBanahaw);
                map.AddMarker(markerDaguldol);
                map.AddMarker(markerDaraitan);
            }

        }
    }
}