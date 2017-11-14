using System;
using Akyat.Pinas.Models;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace Akyat.Pinas.Activities
{
    [Activity(Label = "FirstAidMenu")]
    public class FirstAidMenu : Activity
    {
        private FirstAid mFirstAid = new FirstAid();
        private SnakeBite mSnakeBite = new SnakeBite();
        protected MountainsService mountainService;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            RequestWindowFeature(WindowFeatures.NoTitle);
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.firstaidmenuLayout);
            

            // Create your application here
            Button BandageBtn = FindViewById<Button>(Resource.Id.bandagebtn);
            Button SnakebiteBtn = FindViewById<Button>(Resource.Id.snakebitebtn);
            

            BandageBtn.Click += BandageBtn_Click;
            SnakebiteBtn.Click += SnakebiteBtn_Click;
        }

        private void SnakebiteBtn_Click(object sender, EventArgs e)
        {
            mountainService = new MountainsService();
            mSnakeBite = mountainService.GetSnakeBiteData();
            var intent = new Intent(this, typeof(SnakeBiteAct));
            intent.PutExtra("TITLE", mSnakeBite.Title);
            intent.PutExtra("TITLEDESC", mSnakeBite.TitleDesc);
            intent.PutExtra("Description1", mSnakeBite.Description1);
            intent.PutExtra("Description2", mSnakeBite.Description2);
            intent.PutExtra("Description3", mSnakeBite.Description3);
            intent.PutExtra("Description4", mSnakeBite.Description4);
            intent.PutExtra("Description5", mSnakeBite.Description5);
            intent.PutExtra("Description6", mSnakeBite.Description6);
            intent.PutExtra("Description7", mSnakeBite.Description7);
            intent.PutExtra("Description8", mSnakeBite.Description8);
            intent.PutExtra("Description9", mSnakeBite.Description9);
            intent.PutExtra("Description10", mSnakeBite.Description10);
            StartActivity(intent);


            OverridePendingTransition(Resource.Animation.slide_right, Resource.Animation.fade_out);

        }

        private void BandageBtn_Click(object sender, EventArgs e)
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