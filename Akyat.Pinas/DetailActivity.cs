using System;
using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Widget;
using Akyat.Pinas;
using Akyat.Pinas.ORM;
using Android.Content;
using Android.Graphics;
using Akyat.Pinas.Activities;

namespace Akyat.Pinas
{
    [Activity(Label = "DetailActivity", Theme = "@style/Theme.NoTitle", ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize)]
    public class DetailActivity : Activity
    {
        private TextView tmtname, tmtloc, tjumpoff, tdesc, tbackground, titinerary, tpracticalities,tattire,tttb,tsga,tsgt,tnote;
        private ImageView mtimg0, mtimg1, mtimg2, mtimg3, mtimg4, mtimg5, videoimg;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.detailLayout);

            FindViews();
            Fonts();

            Android.Content.Intent i = this.Intent;
            string iname = i.Extras.GetString("MTNAME");
            int iimg0 = i.Extras.GetInt("IMG0");
            int iimg1 = i.Extras.GetInt("IMG1");
            int iimg2 = i.Extras.GetInt("IMG2");
            int iimg3 = i.Extras.GetInt("IMG3");
            int iimg4 = i.Extras.GetInt("IMG4");
            int iimg5 = i.Extras.GetInt("IMG5");
            string ilocation = i.Extras.GetString("LOCATION");
            string ijumpoff = i.Extras.GetString("JUMPOFF");
            string idescription = i.Extras.GetString("DESCRIPTION");
            string ibackground = i.Extras.GetString("BACKGROUND");
            string iitinerary = i.Extras.GetString("ITINERARY");
            string ipracticalities = i.Extras.GetString("PRACTICALITIES");
            string iattire = i.Extras.GetString("ATTIRE");
            string ittb = i.Extras.GetString("TTB");
            string inote = i.Extras.GetString("NOTE");

            tmtname.Text = iname;
            mtimg0.SetImageResource(iimg0);
            mtimg1.SetImageResource(iimg1);
            mtimg2.SetImageResource(iimg2);
            mtimg3.SetImageResource(iimg3);
            mtimg4.SetImageResource(iimg4);
            mtimg5.SetImageResource(iimg5);
            tmtloc.Text = ilocation;
            tjumpoff.Text = ijumpoff;
            tdesc.Text = idescription;
            tbackground.Text = ibackground;
            titinerary.Text = iitinerary;
            tpracticalities.Text = ipracticalities;
            tattire.Text = iattire;
            tttb.Text = ittb;
            tnote.Text = inote;

            Button btnItinerary = FindViewById<Button>(Resource.Id.btnItinerary);
            btnItinerary.Click += ((sender, e) =>
            {
                DBItineraryRepository dbr = new DBItineraryRepository();
                var result = dbr.CreateTable();
                var intent = new Intent(this, typeof(itineraryAct));
                intent.PutExtra("name", iname);
                StartActivity(intent);
            });

            mtimg0.Click += Mtimg0_Click;
            mtimg1.Click += Mtimg1_Click;
            mtimg2.Click += Mtimg2_Click;
            mtimg3.Click += Mtimg3_Click;
            mtimg4.Click += Mtimg4_Click;
            mtimg5.Click += Mtimg5_Click;
            videoimg.Click += Videoimg_Click;
        }

        private void Videoimg_Click(object sender, System.EventArgs e)
        {
            Intent i = this.Intent;
           string vidS =  i.Extras.GetString("VV");

            if (vidS != null) { 
                
            VidFragment(vidS);
            }
            else
            {
                Toast.MakeText(this,"Video not available", ToastLength.Short).Show();
            }
        }
        private void Mtimg0_Click(object sender, System.EventArgs e)
        {
            Intent i = this.Intent;
            int iimg0 = i.Extras.GetInt("IMG0");
            OpenFragment(iimg0);
        }
        private void Mtimg1_Click(object sender, System.EventArgs e)
        {
            Intent i = this.Intent;
            int iimg1 = i.Extras.GetInt("IMG1");
            OpenFragment(iimg1);
        }
        private void Mtimg2_Click(object sender, System.EventArgs e)
        {
            Intent i = this.Intent;
            int iimg2 = i.Extras.GetInt("IMG2");
            OpenFragment(iimg2);
        }
        private void Mtimg3_Click(object sender, System.EventArgs e)
        {
            Intent i = this.Intent;
            int iimg3 = i.Extras.GetInt("IMG3");
            OpenFragment(iimg3);
        }
        private void Mtimg4_Click(object sender, System.EventArgs e)
        {
            Intent i = this.Intent;
            int iimg4 = i.Extras.GetInt("IMG4");
            OpenFragment(iimg4);
        }
        private void Mtimg5_Click(object sender, System.EventArgs e)
        {
            Intent i = this.Intent;
            int iimg5 = i.Extras.GetInt("IMG5");
            OpenFragment(iimg5);
        }
        public override void OnBackPressed()
        {
            string fromMap = Intent.GetStringExtra("imFromMap");
            if (fromMap == "OKAY") {
                var intent = new Intent(this, typeof(MountainMapAct));
                StartActivity(intent);
                intent.SetFlags(ActivityFlags.ClearTop);
                Finish();
            }
            else if (fromMap == null)
            {
                var intent = new Intent(this, typeof(MountainListAct));
                StartActivity(intent);
                intent.SetFlags(ActivityFlags.ClearTop);
                Finish();
            }
        }

        private void Fonts()
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
        }

        private void FindViews()
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
        }

        private void OpenFragment(int img1)
        {
            Bundle b = new Bundle();
            b.PutInt("IMG1", img1);
            MyDialogFragment fragment = new MyDialogFragment();
            fragment.Arguments = b;
            fragment.Show(this.FragmentManager, "dialog");
        }
        private void VidFragment(string vid)
        {
            Bundle b = new Bundle();
            b.PutString("VID", vid);
            MyVideoFragment fragment = new MyVideoFragment();
            fragment.Arguments = b;
            fragment.Show(this.FragmentManager, "dialog");
        }
    }
}