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
using Org.Apache.Http.Impl.IO;
using Square.Picasso;

namespace Akyat.Pinas.Activities
{
    [Activity(Label = "FirstAidAct")]
    public class FirstAidAct : Activity
    {
        TextView title, vdesc00, vdesc001, vdesc002, vdesc003, vdesc004, vdesc005, vdesc006,
            vdesc01, vdesc011, vdesc012, vdesc013, vdesc014, vdesc015,
            vdesc02, vdesc021, vdesc022, vdesc023, vdesc024, vdesc025;
        ImageView vimg001, vimg002, vimg003, vimg004, vimg005, vimg006,
            vimg011, vimg012, vimg013, vimg014, vimg015,
            vimg021, vimg022, vimg023, vimg024, vimg025;
      

        protected override void OnCreate(Bundle savedInstanceState)
        {
            
            base.OnCreate(savedInstanceState);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.firstaidModel);
            ViewHolder();
           
            Android.Content.Intent i = this.Intent;


            string FAtitle = i.Extras.GetString("TITLE");
            string desc00 = i.Extras.GetString("Desc00");
            string desc001 = i.Extras.GetString("Desc001");
            string desc002 = i.Extras.GetString("Desc002");
            string desc003 = i.Extras.GetString("Desc003");
            string desc004 = i.Extras.GetString("Desc004");
            string desc005 = i.Extras.GetString("Desc005");
            string desc006 = i.Extras.GetString("Desc006");

            string desc01 = i.Extras.GetString("Desc01");
            string desc011 = i.Extras.GetString("Desc011");
            string desc012 = i.Extras.GetString("Desc012");
            string desc013 = i.Extras.GetString("Desc013");
            string desc014 = i.Extras.GetString("Desc014");
            string desc015 = i.Extras.GetString("Desc015");

            string desc02 = i.Extras.GetString("Desc02");
            string desc021 = i.Extras.GetString("Desc021");
            string desc022 = i.Extras.GetString("Desc022");
            string desc023 = i.Extras.GetString("Desc023");
            string desc024 = i.Extras.GetString("Desc024");
            string desc025 = i.Extras.GetString("Desc025");

            string img001 = i.Extras.GetString("Img001");
            string img002 = i.Extras.GetString("Img002");
            string img003 = i.Extras.GetString("Img003");
            string img004 = i.Extras.GetString("Img004");
            string img005 = i.Extras.GetString("Img005");
            string img006 = i.Extras.GetString("Img006");

            string img011 = i.Extras.GetString("Img011");
            string img012 = i.Extras.GetString("Img012");
            string img013 = i.Extras.GetString("Img013");
            string img014 = i.Extras.GetString("Img014");
            string img015 = i.Extras.GetString("Img015");
          

            string img021 = i.Extras.GetString("Img021");
            string img022 = i.Extras.GetString("Img022");
            string img023 = i.Extras.GetString("Img023");
            string img024 = i.Extras.GetString("Img024");
            string img025 = i.Extras.GetString("Img025");


            title.Text = FAtitle;

            vdesc00.Text = desc00;
            vdesc001.Text = desc001;
            vdesc002.Text = desc002;
            vdesc003.Text = desc003;
            vdesc004.Text = desc004;
            vdesc005.Text = desc005;
            vdesc006.Text = desc006;

            vdesc01.Text = desc01;
            vdesc011.Text = desc011;
            vdesc012.Text = desc012;
            vdesc013.Text = desc013;
            vdesc014.Text = desc014;
            vdesc015.Text = desc015;
            
            vdesc02.Text = desc02;
            vdesc021.Text = desc021;
            vdesc022.Text = desc022;
            vdesc023.Text = desc023;
            vdesc024.Text = desc024;
            vdesc025.Text = desc025;

            var bmimg001 = ("https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + img001 + ".png");
            var bmimg002 = ("https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + img002 + ".png");
            var bmimg003 = ("https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + img003 + ".png");
            var bmimg004 = ("https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + img004 + ".png");
            var bmimg005 = ("https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + img005 + ".png");
            var bmimg006 = ("https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + img006 + ".png");

            var bmimg011 = ("https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + img011 + ".png");
            var bmimg012 = ("https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + img012 + ".png");
            var bmimg013 = ("https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + img013 + ".png");
            var bmimg014 = ("https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + img014 + ".png");
            var bmimg015 = ("https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + img015 + ".png");

            var bmimg021 = ("https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + img021 + ".png");
            var bmimg022 = ("https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + img022 + ".png");
            var bmimg023 = ("https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + img023 + ".png");
            var bmimg024 = ("https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + img024 + ".png");
            var bmimg025 = ("https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + img025 + ".png");
            

            Picasso.With(this).Load(bmimg001).Into(vimg001);
            Picasso.With(this).Load(bmimg002).Into(vimg002);
            Picasso.With(this).Load(bmimg003).Into(vimg003);
            Picasso.With(this).Load(bmimg004).Into(vimg004);
            Picasso.With(this).Load(bmimg005).Into(vimg005);
            Picasso.With(this).Load(bmimg006).Into(vimg006);

            Picasso.With(this).Load(bmimg011).Into(vimg011);
            Picasso.With(this).Load(bmimg012).Into(vimg012);
            Picasso.With(this).Load(bmimg013).Into(vimg013);
            Picasso.With(this).Load(bmimg014).Into(vimg014);
            Picasso.With(this).Load(bmimg015).Into(vimg015);

            Picasso.With(this).Load(bmimg021).Into(vimg021);
            Picasso.With(this).Load(bmimg022).Into(vimg022);
            Picasso.With(this).Load(bmimg023).Into(vimg023);
            Picasso.With(this).Load(bmimg024).Into(vimg024);
            Picasso.With(this).Load(bmimg025).Into(vimg025);

        }
        public override void OnBackPressed()
        {
            Finish();
            OverridePendingTransition(Resource.Animation.slide_left, Resource.Animation.fade_out);
        }

        private void ViewHolder()
        {
            title = FindViewById<TextView>(Resource.Id.fatitle);

            vdesc00 = FindViewById<TextView>(Resource.Id.desc00);
            vdesc001 = FindViewById<TextView>(Resource.Id.desc001);
            vdesc002 = FindViewById<TextView>(Resource.Id.desc002);
            vdesc003 = FindViewById<TextView>(Resource.Id.desc003);
            vdesc004 = FindViewById<TextView>(Resource.Id.desc004);
            vdesc005 = FindViewById<TextView>(Resource.Id.desc005);
            vdesc006 = FindViewById<TextView>(Resource.Id.desc006);

            vdesc01 = FindViewById<TextView>(Resource.Id.desc01);
            vdesc011 = FindViewById<TextView>(Resource.Id.desc011);
            vdesc012 = FindViewById<TextView>(Resource.Id.desc012);
            vdesc013 = FindViewById<TextView>(Resource.Id.desc013);
            vdesc014 = FindViewById<TextView>(Resource.Id.desc014);
            vdesc015 = FindViewById<TextView>(Resource.Id.desc015);

            vdesc02 = FindViewById<TextView>(Resource.Id.desc02);
            vdesc021 = FindViewById<TextView>(Resource.Id.desc021);
            vdesc022 = FindViewById<TextView>(Resource.Id.desc022);
            vdesc023 = FindViewById<TextView>(Resource.Id.desc023);
            vdesc024 = FindViewById<TextView>(Resource.Id.desc024);
            vdesc025 = FindViewById<TextView>(Resource.Id.desc025);

            vimg001 = FindViewById<ImageView>(Resource.Id.img001);
            vimg002 = FindViewById<ImageView>(Resource.Id.img002);
            vimg003 = FindViewById<ImageView>(Resource.Id.img003);
            vimg004 = FindViewById<ImageView>(Resource.Id.img004);
            vimg005 = FindViewById<ImageView>(Resource.Id.img005);
            vimg006 = FindViewById<ImageView>(Resource.Id.img006);

            vimg011 = FindViewById<ImageView>(Resource.Id.img011);
            vimg012 = FindViewById<ImageView>(Resource.Id.img012);
            vimg013 = FindViewById<ImageView>(Resource.Id.img013);
            vimg014 = FindViewById<ImageView>(Resource.Id.img014);
            vimg015 = FindViewById<ImageView>(Resource.Id.img015);

            vimg021 = FindViewById<ImageView>(Resource.Id.img021);
            vimg022 = FindViewById<ImageView>(Resource.Id.img022);
            vimg023 = FindViewById<ImageView>(Resource.Id.img023);
            vimg024 = FindViewById<ImageView>(Resource.Id.img024);
            vimg025 = FindViewById<ImageView>(Resource.Id.img025);
        }
    }
}