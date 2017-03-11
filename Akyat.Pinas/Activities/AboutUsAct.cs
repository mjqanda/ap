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
using Square.Picasso;

namespace Akyat.Pinas.Activities
{
    [Activity(Theme = "@style/Theme.NoTitle",Label = "AboutUsAct", NoHistory = true)]
    public class AboutUsAct : Activity
    {
      //  Context mContext = this;
        private const string ImgUrl = "https://ia601506.us.archive.org/35/items/mj_anda_yahoo_Pics/aboutus.jpg";
        protected override void OnCreate(Bundle savedInstanceState)
        {
            RequestWindowFeature(WindowFeatures.NoTitle);
           
            SetContentView(Resource.Layout.aboutUsLayout);
            ImageView Img = FindViewById<ImageView>(Resource.Id.aboutusImg);
            base.OnCreate(savedInstanceState);
            
            Picasso.With(this).Load(ImgUrl).Into(Img);
            Img.Click += Buttoo_Click;

        }

        private void Buttoo_Click(object sender, EventArgs e)
        {
            Finish();
            OverridePendingTransition(Resource.Animation.fade_in, Resource.Animation.fade_out);
        }

        public override void OnBackPressed()
        {
            Finish();
            OverridePendingTransition(Resource.Animation.fade_in, Resource.Animation.fade_out);
            
        }
    }
}