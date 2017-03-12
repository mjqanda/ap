using System.Collections.Generic;
using Akyat.Pinas.Models;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using Geolocator.Plugin.Abstractions;

namespace Akyat.Pinas.Activities
{
    [Activity( Label = "LeaveNoTraceAct", NoHistory = true)]
    public class LeaveNoTraceAct : Activity
    {
        TextView vtitle,vdesc, vdesc1, vdesc11, vdesc2, vdesc22, vdesc3, vdesc33, vdesc4, vdesc44, vdesc5, vdesc55, vdesc6, vdesc66, vdesc7, vdesc77, vdesc8, vdesc88;
        ImageView vicon1, vicon2, vicon3, vicon4, vicon5, vicon6, vicon7, vicon8;
        private List<LeaveNoTrace> lnt;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            lnt = MountainsService.GetLeaveNoTraceData();
            base.OnCreate(savedInstanceState);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.leaveNoTrace);
            FindViews();

        }

        public override void OnBackPressed()
        {
            Finish();
            OverridePendingTransition(Resource.Animation.slide_left, Resource.Animation.fade_out);
        }

        private void FindViews()
        {
            vtitle = FindViewById<TextView>(Resource.Id.title);
            vdesc = FindViewById<TextView>(Resource.Id.desc);
            vdesc1 = FindViewById<TextView>(Resource.Id.lntdesc1);
            vdesc11 = FindViewById<TextView>(Resource.Id.lntdesc11);

            vdesc2 = FindViewById<TextView>(Resource.Id.lntdesc2);
            vdesc22 = FindViewById<TextView>(Resource.Id.lntdesc22);

            vdesc3 = FindViewById<TextView>(Resource.Id.lntdesc3);
            vdesc33 = FindViewById<TextView>(Resource.Id.lntdesc33);

            vdesc4 = FindViewById<TextView>(Resource.Id.lntdesc4);
            vdesc44 = FindViewById<TextView>(Resource.Id.lntdesc44);

            vdesc5 = FindViewById<TextView>(Resource.Id.lntdesc5);
            vdesc55 = FindViewById<TextView>(Resource.Id.lntdesc55);

            vdesc6 = FindViewById<TextView>(Resource.Id.lntdesc6);
            vdesc66 = FindViewById<TextView>(Resource.Id.lntdesc66);

            vdesc7 = FindViewById<TextView>(Resource.Id.lntdesc7);
            vdesc77 = FindViewById<TextView>(Resource.Id.lntdesc77);

            vdesc8 = FindViewById<TextView>(Resource.Id.lntdesc8);
            vdesc88 = FindViewById<TextView>(Resource.Id.lntdesc88);

            vicon1 = FindViewById<ImageView>(Resource.Id.icon1);
            vicon2 = FindViewById<ImageView>(Resource.Id.icon2);
            vicon3 = FindViewById<ImageView>(Resource.Id.icon3);
            vicon4 = FindViewById<ImageView>(Resource.Id.icon4);
            vicon5 = FindViewById<ImageView>(Resource.Id.icon5);
            vicon6 = FindViewById<ImageView>(Resource.Id.icon6);
            vicon7 = FindViewById<ImageView>(Resource.Id.icon7);
            vicon8 = FindViewById<ImageView>(Resource.Id.icon8);
        }
    }
}