// Detail Activity of our every mountain
using Android.App;
using Android.OS;
using Android.Widget;
using Akyat.Pinas.ORM;
using Android.Content;
using Android.Graphics;
using Akyat.Pinas.Activities;
using Square.Picasso;

namespace Akyat.Pinas
{
    [Activity(Label = "DetailActivity", Theme = "@style/Theme.NoTitle", ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize)]
    public class DetailActivity : Activity
    {
        private TextView tmtname, tmtloc, tjumpoff, tdesc, tbackground, titinerary, tpracticalities,tattire,
            tttb,tsga,tsgt,tnote, timgdesc00, timgdesc01, timgdesc02, timgdesc03, timgdesc04, timgdesc05, tviddesc;
        private ImageView mtimg0, mtimg1, mtimg2, mtimg3, mtimg4, mtimg5, videoimg;
        Context mContext;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.detailLayout);
            FindViews();
            Fonts();

            Android.Content.Intent i = this.Intent;
            string iname = i.Extras.GetString("MTNAME");
            string iimg0 = i.Extras.GetString("IMG0");
            string iimg1 = i.Extras.GetString("IMG1");
            string iimg2 = i.Extras.GetString("IMG2");
            string iimg3 = i.Extras.GetString("IMG3");
            string iimg4 = i.Extras.GetString("IMG4");
            string iimg5 = i.Extras.GetString("IMG5");
            string ilocation = i.Extras.GetString("LOCATION");
            string ijumpoff = i.Extras.GetString("JUMPOFF");
            string idescription = i.Extras.GetString("DESCRIPTION");
            string ibackground = i.Extras.GetString("BACKGROUND");
            string iitinerary = i.Extras.GetString("ITINERARY");
            string ipracticalities = i.Extras.GetString("PRACTICALITIES");
            string iattire = i.Extras.GetString("ATTIRE");
            string ittb = i.Extras.GetString("TTB");
            string inote = i.Extras.GetString("NOTE");
            string iimgdesc00 = i.Extras.GetString("IMGD0");
            string iimgdesc01 = i.Extras.GetString("IMGD1");
            string iimgdesc02 = i.Extras.GetString("IMGD2");
            string iimgdesc03 = i.Extras.GetString("IMGD3");
            string iimgdesc04 = i.Extras.GetString("IMGD4");
            string iimgdesc05 = i.Extras.GetString("IMGD5");
            string ividdesc = i.Extras.GetString("VIDD");

            var imageBitmap0 = ("https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + iimg0 + ".jpg");
            var imageBitmap1 = ("https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + iimg1 + ".jpg");
            var imageBitmap2 = ("https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + iimg2 + ".jpg");
            var imageBitmap3 = ("https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + iimg3 + ".jpg");
            var imageBitmap4 = ("https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + iimg4 + ".jpg");
            var imageBitmap5 = "https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + iimg5 + ".jpg";

            Picasso.With(this).Load(imageBitmap0).Into(mtimg0);
            Picasso.With(mContext).Load(imageBitmap1).Into(mtimg1);
            Picasso.With(mContext).Load(imageBitmap2).Into(mtimg2);
            Picasso.With(mContext).Load(imageBitmap3).Into(mtimg3);
            Picasso.With(mContext).Load(imageBitmap4).Into(mtimg4);
            Picasso.With(mContext).Load(imageBitmap5).Into(mtimg5);

            tmtname.Text = iname;
            tmtloc.Text = ilocation;
            tjumpoff.Text = ijumpoff;
            tdesc.Text = idescription;
            tbackground.Text = ibackground;
            titinerary.Text = iitinerary;
            tpracticalities.Text = ipracticalities;
            tattire.Text = iattire;
            tttb.Text = ittb;
            tnote.Text = inote;
            timgdesc00.Text = iimgdesc00;
            timgdesc01.Text = iimgdesc01;
            timgdesc02.Text = iimgdesc02;
            timgdesc03.Text = iimgdesc03;
            timgdesc04.Text = iimgdesc04;
            timgdesc05.Text = iimgdesc05;
            tviddesc.Text = ividdesc;

            Button btnItinerary = FindViewById<Button>(Resource.Id.btnItinerary);
            btnItinerary.Click += ((sender, e) =>
            {
                DBItineraryRepository dbr = new DBItineraryRepository();
                var result = dbr.CreateTable();
                var intent = new Intent(this, typeof(itineraryAct));
                intent.PutExtra("name", iname);
                StartActivity(intent);
                FadeInAnim();
            });

            mtimg0.Click += Mtimg0_Click;
            mtimg1.Click += Mtimg1_Click;
            mtimg2.Click += Mtimg2_Click;
            mtimg3.Click += Mtimg3_Click;
            mtimg4.Click += Mtimg4_Click;
            mtimg5.Click += Mtimg5_Click;
            videoimg.Click += Videoimg_Click;
        }

        private void Videoimg_Click(object sender, System.EventArgs e) //Click handler for our video fragment
        {
            Intent i = this.Intent;
           string vidS =  i.Extras.GetString("VV");

            if (vidS != null) {

                Toast.MakeText(this, "Please wait...", ToastLength.Short).Show();

                VidFragment(vidS);
            }
            else
            {
                Toast.MakeText(this,"Video not available", ToastLength.Short).Show();
            }
        }
        private void Mtimg0_Click(object sender, System.EventArgs e) //Enlarge image on click
        {
            Intent i = this.Intent;
            string iimg0 = i.Extras.GetString("IMG0"); 
            OpenFragment(iimg0);
        }
        private void Mtimg1_Click(object sender, System.EventArgs e)
        {
            Intent i = this.Intent;
            string iimg1 = i.Extras.GetString("IMG1");
            OpenFragment(iimg1);
        }
        private void Mtimg2_Click(object sender, System.EventArgs e)
        {
            Intent i = this.Intent;
            string iimg2 = i.Extras.GetString("IMG2");
            OpenFragment(iimg2);
        }
        private void Mtimg3_Click(object sender, System.EventArgs e)
        {
            Intent i = this.Intent;
            string iimg3 = i.Extras.GetString("IMG3");
            OpenFragment(iimg3);
        }
        private void Mtimg4_Click(object sender, System.EventArgs e)
        {
            Intent i = this.Intent;
            string iimg4 = i.Extras.GetString("IMG4");
            OpenFragment(iimg4);
        }
        private void Mtimg5_Click(object sender, System.EventArgs e)
        {
            Intent i = this.Intent;
            string iimg5 = i.Extras.GetString("IMG5");
            OpenFragment(iimg5);
        }
        public override void OnBackPressed()
        {
            string fromMap = Intent.GetStringExtra("imFromMap");
            if (fromMap == "OKAY") {
                var intent = new Intent(this, typeof(MountainMapAct));
                StartActivity(intent);
                FadeInAnim();
                intent.SetFlags(ActivityFlags.ClearTop);
                Finish();
            }
            else if (fromMap == null)
            {
                var intent = new Intent(this, typeof(MountainListAct));
                StartActivity(intent);
                OverridePendingTransition(Resource.Animation.slide_left, Resource.Animation.fade_out);
                intent.SetFlags(ActivityFlags.ClearTop);
                Finish();
            }
        }

        private void Fonts() //set fonts
        {
            Typeface tf = Typeface.CreateFromAsset(Assets, "REFSAN.TTF");
            tmtname.SetTypeface(tf, TypefaceStyle.Normal);
            tmtloc.SetTypeface(tf, TypefaceStyle.Normal);
            tjumpoff.SetTypeface(tf, TypefaceStyle.Normal);
            tdesc.SetTypeface(tf, TypefaceStyle.Normal);
            tbackground.SetTypeface(tf, TypefaceStyle.Normal);
            titinerary.SetTypeface(tf, TypefaceStyle.Normal);
            tpracticalities.SetTypeface(tf, TypefaceStyle.Normal);
            tattire.SetTypeface(tf, TypefaceStyle.Normal);
            tttb.SetTypeface(tf, TypefaceStyle.Normal);
            tsga.SetTypeface(tf, TypefaceStyle.Bold);
            tsgt.SetTypeface(tf, TypefaceStyle.Bold);
            tnote.SetTypeface(tf, TypefaceStyle.Normal);
            timgdesc01.SetTypeface(tf, TypefaceStyle.Normal);
            timgdesc02.SetTypeface(tf, TypefaceStyle.Normal);
            timgdesc03.SetTypeface(tf, TypefaceStyle.Normal);
            timgdesc04.SetTypeface(tf, TypefaceStyle.Normal);
            timgdesc05.SetTypeface(tf, TypefaceStyle.Normal);
            tviddesc.SetTypeface(tf, TypefaceStyle.Normal);
            timgdesc00.SetTypeface(tf, TypefaceStyle.Normal);
        }

        private void FindViews() //Hold views
        {
            tmtname = FindViewById<TextView>(Resource.Id.mtname);
            mtimg0 = FindViewById<ImageView>(Resource.Id.mtimg00); 
            mtimg1 = FindViewById<ImageView>(Resource.Id.mtimg01);
            mtimg2 = FindViewById<ImageView>(Resource.Id.mtimg02);
            mtimg3 = FindViewById<ImageView>(Resource.Id.mtimg03);
            mtimg4 = FindViewById<ImageView>(Resource.Id.mtimg04);
            mtimg5 = FindViewById<ImageView>(Resource.Id.mtimg05);
            tmtloc = FindViewById<TextView>(Resource.Id.locationtxt);
            tjumpoff = FindViewById<TextView>(Resource.Id.jumpofftxt);
            tdesc = FindViewById<TextView>(Resource.Id.descriptiontxt);
            tbackground = FindViewById<TextView>(Resource.Id.backgroundtxt);
            titinerary = FindViewById<TextView>(Resource.Id.itinerarytxt);
            tpracticalities = FindViewById<TextView>(Resource.Id.practicalitiestxt);
            tattire = FindViewById<TextView>(Resource.Id.attiretxt);
            tttb = FindViewById<TextView>(Resource.Id.ttbtxt);
            tsga = FindViewById<TextView>(Resource.Id.sgatxt);
            tsgt = FindViewById<TextView>(Resource.Id.sgttxt);
            tnote = FindViewById<TextView>(Resource.Id.notetxt);
            videoimg = FindViewById<ImageView>(Resource.Id.vvimg);
            timgdesc00 = FindViewById<TextView>(Resource.Id.imgdesc00);
            timgdesc01 = FindViewById<TextView>(Resource.Id.imgdesc01);
            timgdesc02 = FindViewById<TextView>(Resource.Id.imgdesc02);
            timgdesc03 = FindViewById<TextView>(Resource.Id.imgdesc03);
            timgdesc04 = FindViewById<TextView>(Resource.Id.imgdesc04);
            timgdesc05 = FindViewById<TextView>(Resource.Id.imgdesc05);
            tviddesc = FindViewById<TextView>(Resource.Id.viddesc);
        }

        private void OpenFragment(string img1) //open fragments of every image
        {
            Bundle b = new Bundle();
            b.PutString("IMG1", img1);
            MyDialogFragment fragment = new MyDialogFragment();
            fragment.Arguments = b;
            fragment.Show(this.FragmentManager, "dialog");
        }
        private void VidFragment(string vid) //open fragment that contains video
        {
            Bundle b = new Bundle();
            b.PutString("VID", vid);
            MyVideoFragment fragment = new MyVideoFragment();
            fragment.Arguments = b;
            fragment.Show(this.FragmentManager, "dialog");
        }

        private void FadeInAnim()
        {
            OverridePendingTransition(Resource.Animation.fade_in, Resource.Animation.fade_out);
        }
    }
}