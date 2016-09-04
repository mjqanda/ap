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


namespace Akyat.Pinas.Activities
{
    [Activity(Theme = "@style/Theme.NoTitle", Label = "mountainMapAct")]
    public class mountainMapAct : Activity
    {
        

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.mountainMap);

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

            MarkerOptions markerBatulao = new MarkerOptions();
            markerBatulao.SetPosition(new LatLng(14.0408, 120.8011));
            markerBatulao.SetTitle("Mt. Batulao");

            MarkerOptions markerMakiling = new MarkerOptions();
            markerMakiling.SetPosition(new LatLng(14.13, 121.2));
            markerMakiling.SetTitle("Mt. Makiling");

            MarkerOptions markerCristobal = new MarkerOptions();
            markerCristobal.SetPosition(new LatLng(14.0635, 121.4113));
            markerCristobal.SetTitle("Mt. Cristobal");

            MarkerOptions markerUlap = new MarkerOptions();
            markerUlap.SetPosition(new LatLng(16.29, 120.6309));
            markerUlap.SetTitle("Mt. Ulap");


            MapFragment mapFrag = (MapFragment)FragmentManager.FindFragmentById(Resource.Id.map);
            GoogleMap map = mapFrag.Map;

            
            if (map != null)
            {
                map.MapType = GoogleMap.MapTypeTerrain;
                map.UiSettings.ZoomControlsEnabled = true;
                map.UiSettings.CompassEnabled = true;
                map.MoveCamera(cameraUpdate);
                markerBatulao.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));
                markerMakiling.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));
                markerTalamitam.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));
                markerUlap.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));
                markerCristobal.SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow));
                map.AddMarker(markerTalamitam);
                map.AddMarker(markerBatulao);
                map.AddMarker(markerMakiling);
                map.AddMarker(markerUlap);
                map.AddMarker(markerCristobal);
            }

        }
    }
}