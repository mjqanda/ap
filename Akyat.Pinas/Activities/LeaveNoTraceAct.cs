using System.Collections.Generic;
using Akyat.Pinas.Models;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using Square.Picasso;

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
            base.OnCreate(savedInstanceState);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.leaveNoTrace);
            FindViews();

            Android.Content.Intent i = this.Intent;


            string lnttitle = i.Extras.GetString("Title");
            string desc = i.Extras.GetString("Desc");
            string desc1 = i.Extras.GetString("Desc1");
            string desc11 = i.Extras.GetString("Desc11");
            string desc2 = i.Extras.GetString("Desc2");
            string desc22 = i.Extras.GetString("Desc22");
            string desc3 = i.Extras.GetString("Desc3");
            string desc33 = i.Extras.GetString("Desc33");
            string desc4 = i.Extras.GetString("Desc4");
            string desc44 = i.Extras.GetString("Desc44");
            string desc5 = i.Extras.GetString("Desc5");
            string desc55 = i.Extras.GetString("Desc55");
            string desc6 = i.Extras.GetString("Desc6");
            string desc66 = i.Extras.GetString("Desc66");
            string desc7 = i.Extras.GetString("Desc7");
            string desc77 = i.Extras.GetString("Desc77");
            string desc8 = i.Extras.GetString("Desc8");
            string desc88 = i.Extras.GetString("Desc88");

            string icon1 = i.Extras.GetString("Icon1");
            string icon2 = i.Extras.GetString("Icon2");
            string icon3 = i.Extras.GetString("Icon3");
            string icon4 = i.Extras.GetString("Icon4");
            string icon5 = i.Extras.GetString("Icon5");
            string icon6 = i.Extras.GetString("Icon6");
            string icon7 = i.Extras.GetString("Icon7");
            string icon8 = i.Extras.GetString("Icon8");

            var bmicon1 = ("https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + icon1 + ".png");
            var bmicon2 = ("https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + icon2 + ".png");
            var bmicon3 = ("https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + icon3 + ".png");
            var bmicon4 = ("https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + icon4 + ".png");
            var bmicon5 = ("https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + icon5 + ".png");
            var bmicon6 = ("https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + icon6 + ".png");
            var bmicon7 = ("https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + icon7 + ".png");
            var bmicon8 = ("https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + icon8 + ".png");
            
            vtitle.Text = lnttitle;
            vdesc.Text = desc;
            vdesc1.Text = desc1;
            vdesc11.Text = desc11;
            vdesc2.Text = desc2;
            vdesc22.Text = desc22;
            vdesc3.Text = desc3;
            vdesc33.Text = desc33;
            vdesc4.Text = desc4;
            vdesc44.Text = desc44;
            vdesc5.Text = desc5;
            vdesc55.Text = desc55;
            vdesc6.Text = desc6;
            vdesc66.Text = desc66;
            vdesc7.Text = desc7;
            vdesc77.Text = desc77;
            vdesc8.Text = desc8;
            vdesc88.Text = desc88;

            Picasso.With(this).Load(bmicon1).Into(vicon1);
            Picasso.With(this).Load(bmicon2).Into(vicon2);
            Picasso.With(this).Load(bmicon3).Into(vicon3);
            Picasso.With(this).Load(bmicon4).Into(vicon4);
            Picasso.With(this).Load(bmicon5).Into(vicon5);
            Picasso.With(this).Load(bmicon6).Into(vicon6);
            Picasso.With(this).Load(bmicon7).Into(vicon7);
            Picasso.With(this).Load(bmicon8).Into(vicon8);

        }

        public override void OnBackPressed()
        {
            Finish();
            OverridePendingTransition(Resource.Animation.slide_left, Resource.Animation.fade_out);
        }

        private void FindViews()
        {
            vtitle = FindViewById<TextView>(Resource.Id.lnttitle);
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