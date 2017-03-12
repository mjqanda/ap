using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Akyat.Pinas.Models;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Square.Picasso;

namespace Akyat.Pinas.Adapters
{
    public class FirstAidAdapter : BaseAdapter<FirstAid>
    {
        private Context mContext;
        private int mRowLayout;
        private List<FirstAid> fstAid;

        public FirstAidAdapter(Context context, int rowLayout, List<FirstAid> fAid) : base()
        {
            mContext = context;
            mRowLayout = rowLayout;
            fstAid = fAid;
        }

        public override int Count => fstAid.Count;

        public override FirstAid this[int position] => fstAid[position];


        public override long GetItemId(int position)
        {
            return position;
        }
      

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = fstAid[position];
            Typeface tf = Typeface.CreateFromAsset(mContext.Assets, "REFSAN.TTF");
            View row = convertView;
            var img001BM = "https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + item.Img001 + ".jpg";
            var img002BM = "https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + item.Img002 + ".jpg";
            var img003BM = "https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + item.Img003 + ".jpg";
            var img004BM = "https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + item.Img004 + ".jpg";
            var img005BM = "https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + item.Img005 + ".jpg";

            var img011BM = "https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + item.Img011 + ".jpg";
            var img012BM = "https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + item.Img012 + ".jpg";
            var img013BM = "https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + item.Img013 + ".jpg";
            var img014BM = "https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + item.Img014 + ".jpg";
            var img015BM = "https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + item.Img015 + ".jpg";

            var img021BM = "https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + item.Img021 + ".jpg";
            var img022BM = "https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + item.Img022 + ".jpg";
            var img023BM = "https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + item.Img023 + ".jpg";
            var img024BM = "https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + item.Img024 + ".jpg";
            var img025BM = "https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + item.Img025 + ".jpg";

            if (row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(mRowLayout, parent, false);
               //convertView = this.LayoutInflater.Inflate(Resource.Layout.ml_model, null);
            }
            row.FindViewById<TextView>(Resource.Id.fatitle).Text = item.Title;

            row.FindViewById<TextView>(Resource.Id.desc00).Text = item.Desc00;
            row.FindViewById<TextView>(Resource.Id.desc001).Text = item.Desc001;
            row.FindViewById<TextView>(Resource.Id.desc002).Text = item.Desc002;
            row.FindViewById<TextView>(Resource.Id.desc003).Text = item.Desc003;
            row.FindViewById<TextView>(Resource.Id.desc004).Text = item.Desc004;
            row.FindViewById<TextView>(Resource.Id.desc005).Text = item.Desc005;
            row.FindViewById<TextView>(Resource.Id.desc006).Text = item.Desc006;

            row.FindViewById<TextView>(Resource.Id.desc01).Text = item.Desc01;
            row.FindViewById<TextView>(Resource.Id.desc011).Text = item.Desc011;
            row.FindViewById<TextView>(Resource.Id.desc012).Text = item.Desc012;
            row.FindViewById<TextView>(Resource.Id.desc013).Text = item.Desc013;
            row.FindViewById<TextView>(Resource.Id.desc014).Text = item.Desc014;
            row.FindViewById<TextView>(Resource.Id.desc015).Text = item.Desc015;

            row.FindViewById<TextView>(Resource.Id.desc02).Text = item.Desc02;
            row.FindViewById<TextView>(Resource.Id.desc021).Text = item.Desc021;
            row.FindViewById<TextView>(Resource.Id.desc022).Text = item.Desc022;
            row.FindViewById<TextView>(Resource.Id.desc023).Text = item.Desc023;
            row.FindViewById<TextView>(Resource.Id.desc024).Text = item.Desc024;
            row.FindViewById<TextView>(Resource.Id.desc025).Text = item.Desc025;

            ImageView vimg001 = row.FindViewById<ImageView>(Resource.Id.img001);
            ImageView vimg002 = row.FindViewById<ImageView>(Resource.Id.img002);
            ImageView vimg003 = row.FindViewById<ImageView>(Resource.Id.img003);
            ImageView vimg004 = row.FindViewById<ImageView>(Resource.Id.img004);
            ImageView vimg005 = row.FindViewById<ImageView>(Resource.Id.img005);

            ImageView vimg011 = row.FindViewById<ImageView>(Resource.Id.img011);
            ImageView vimg012 = row.FindViewById<ImageView>(Resource.Id.img012);
            ImageView vimg013 = row.FindViewById<ImageView>(Resource.Id.img013);
            ImageView vimg014 = row.FindViewById<ImageView>(Resource.Id.img014);
            ImageView vimg015 = row.FindViewById<ImageView>(Resource.Id.img015);

            ImageView vimg021 = row.FindViewById<ImageView>(Resource.Id.img021);
            ImageView vimg022 = row.FindViewById<ImageView>(Resource.Id.img022);
            ImageView vimg023 = row.FindViewById<ImageView>(Resource.Id.img023);
            ImageView vimg024 = row.FindViewById<ImageView>(Resource.Id.img024);
            ImageView vimg025 = row.FindViewById<ImageView>(Resource.Id.img025);


            Picasso.With(mContext).Load(img001BM).Into(vimg001);
            Picasso.With(mContext).Load(img002BM).Into(vimg002);
            Picasso.With(mContext).Load(img003BM).Into(vimg003);
            Picasso.With(mContext).Load(img004BM).Into(vimg004);
            Picasso.With(mContext).Load(img005BM).Into(vimg005);

            Picasso.With(mContext).Load(img011BM).Into(vimg011);
            Picasso.With(mContext).Load(img012BM).Into(vimg012);
            Picasso.With(mContext).Load(img013BM).Into(vimg013);
            Picasso.With(mContext).Load(img014BM).Into(vimg014);
            Picasso.With(mContext).Load(img015BM).Into(vimg015);

            Picasso.With(mContext).Load(img021BM).Into(vimg021);
            Picasso.With(mContext).Load(img022BM).Into(vimg022);
            Picasso.With(mContext).Load(img023BM).Into(vimg023);
            Picasso.With(mContext).Load(img024BM).Into(vimg024);
            Picasso.With(mContext).Load(img025BM).Into(vimg025);



            //mtnametxt.SetTypeface(tf, TypefaceStyle.Bold);
            //Masltxt.SetTypeface(tf, TypefaceStyle.Bold);
            //Difficultytxt.SetTypeface(tf, TypefaceStyle.Bold);
            //Picasso.With(mContext).Load(imageBitmap).Into(Img);


            NotifyDataSetChanged();
            return convertView;
        }
    }
}