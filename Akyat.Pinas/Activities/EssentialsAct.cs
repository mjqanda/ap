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
        private FirstAid mFirstAid = new FirstAid();
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
            mountainService = new MountainsService();
            mFirstAid = mountainService.GetFirstAidData();
            var intent = new Intent(this, typeof(FirstAidAct));
            intent.PutExtra("TITLE", mFirstAid.Title);
            intent.PutExtra("Desc00", mFirstAid.Desc00);
            intent.PutExtra("Img001", mFirstAid.Img001);
            intent.PutExtra("Desc001", mFirstAid.Desc001);
            intent.PutExtra("Img002", mFirstAid.Img002);
            intent.PutExtra("Desc002", mFirstAid.Desc002);
            intent.PutExtra("Img003", mFirstAid.Img003);
            intent.PutExtra("Desc003", mFirstAid.Desc003);
            intent.PutExtra("Img004", mFirstAid.Img004);
            intent.PutExtra("Desc004", mFirstAid.Desc004);
            intent.PutExtra("Img005", mFirstAid.Img005);
            intent.PutExtra("Desc005", mFirstAid.Desc005);
            intent.PutExtra("Img006", mFirstAid.Img006);
            intent.PutExtra("Desc006", mFirstAid.Desc006);


            intent.PutExtra("Desc01", mFirstAid.Desc01);
            intent.PutExtra("Img011", mFirstAid.Img011);
            intent.PutExtra("Desc011", mFirstAid.Desc011);
            intent.PutExtra("Img012", mFirstAid.Img012);
            intent.PutExtra("Desc012", mFirstAid.Desc012);
            intent.PutExtra("Img013", mFirstAid.Img013);
            intent.PutExtra("Desc013", mFirstAid.Desc013);
            intent.PutExtra("Img014", mFirstAid.Img014);
            intent.PutExtra("Desc014", mFirstAid.Desc014);
            intent.PutExtra("Img015", mFirstAid.Img015);
            intent.PutExtra("Desc015", mFirstAid.Desc015);


            intent.PutExtra("Desc02", mFirstAid.Desc02);
            intent.PutExtra("Img021", mFirstAid.Img021);
            intent.PutExtra("Desc021", mFirstAid.Desc021);
            intent.PutExtra("Img022", mFirstAid.Img022);
            intent.PutExtra("Desc022", mFirstAid.Desc022);
            intent.PutExtra("Img023", mFirstAid.Img023);
            intent.PutExtra("Desc023", mFirstAid.Desc023);
            intent.PutExtra("Img024", mFirstAid.Img024);
            intent.PutExtra("Desc024", mFirstAid.Desc024);
            intent.PutExtra("Img025", mFirstAid.Img025);
            intent.PutExtra("Desc025", mFirstAid.Desc025);

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