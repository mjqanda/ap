using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Akyat.Pinas.Models;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Akyat.Pinas.Activities
{
    [Activity(Label = "EssentialsAct")]
    public class EssentialsAct : Activity
    {
     //   List<FirstAid> fa;
        private LeaveNoTrace mLnt = new LeaveNoTrace();
        protected MountainsService mountainService;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            

            base.OnCreate(savedInstanceState);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.essentials);
            
            Button btnLnt = FindViewById<Button>(Resource.Id.lntBtn);
            Button btnFirstaid = FindViewById<Button>(Resource.Id.firstaidBtn);

            btnLnt.Click += BtnLnt_Click;
            btnFirstaid.Click += BtnFirstaid_Click;

        }

        private void BtnLnt_Click(object sender, EventArgs e)
        {
            mountainService = new MountainsService();
            mLnt = mountainService.GetLeaveNoTraceData();
            var intent = new Intent(this, typeof(LeaveNoTraceAct));

            intent.PutExtra("Title", mLnt.Title);
            intent.PutExtra("Desc", mLnt.Desc);
            intent.PutExtra("Desc1", mLnt.Desc1);
            intent.PutExtra("Desc11", mLnt.Desc11);
            intent.PutExtra("Desc2", mLnt.Desc2);
            intent.PutExtra("Desc22", mLnt.Desc22);
            intent.PutExtra("Desc3", mLnt.Desc3);
            intent.PutExtra("Desc33", mLnt.Desc33);
            intent.PutExtra("Desc4", mLnt.Desc4);
            intent.PutExtra("Desc44", mLnt.Desc44);
            intent.PutExtra("Desc5", mLnt.Desc5);
            intent.PutExtra("Desc55", mLnt.Desc55);
            intent.PutExtra("Desc6", mLnt.Desc6);
            intent.PutExtra("Desc66", mLnt.Desc66);
            intent.PutExtra("Desc7", mLnt.Desc7);
            intent.PutExtra("Desc77", mLnt.Desc77);
            intent.PutExtra("Desc8", mLnt.Desc8);
            intent.PutExtra("Desc88", mLnt.Desc88);

            intent.PutExtra("Icon1", mLnt.Icon1);
            intent.PutExtra("Icon2", mLnt.Icon2);
            intent.PutExtra("Icon3", mLnt.Icon3);
            intent.PutExtra("Icon4", mLnt.Icon4);
            intent.PutExtra("Icon5", mLnt.Icon5);
            intent.PutExtra("Icon6", mLnt.Icon6);
            intent.PutExtra("Icon7", mLnt.Icon7);
            intent.PutExtra("Icon8", mLnt.Icon8);

            StartActivity(intent);
            OverridePendingTransition(Resource.Animation.slide_right, Resource.Animation.fade_out);
        }

        private void BtnFirstaid_Click(object sender, EventArgs e)
        {
            
            var intent = new Intent(this, typeof(FirstAidMenu));
            StartActivity(intent);
            OverridePendingTransition(Resource.Animation.slide_right, Resource.Animation.fade_out);
        }

        public override void OnBackPressed()
        {
            Finish();
            OverridePendingTransition(Resource.Animation.slide_left, Resource.Animation.fade_out);
        }

    }
    
}