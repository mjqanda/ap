using System;
using System.Collections.Generic;
using Android.Content;
using Android.Views;
using Android.Widget;
using Android.Graphics;
using Akyat.Pinas.Utility;

namespace Akyat.Pinas
{
    public class MountainsAdapter : BaseAdapter<Mountain>
    {
        private Context mContext;
        private int mRowLayout;
        private List<Mountain> mtList;
    
        public MountainsAdapter(Context context, int rowLayout, List<Mountain> mList):base()
        {
            mContext = context;
            mRowLayout = rowLayout;
            mtList = mList;
        }

        public override int Count => mtList.Count;

        public override Mountain this[int position] => mtList[position];


        public override long GetItemId(int position)
        {
            return position;
        }

        public  void Update(List<Mountain> mLists)
        {
            mtList.Clear();
            mtList.AddRange(mLists);
            NotifyDataSetChanged();
        }
  
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = mtList[position];
            Typeface tf = Typeface.CreateFromAsset(mContext.Assets, "REFSAN.TTF");
            View row = convertView;
            var imageBitmap = ImageHelper.GetImageBitmapFromUrl("https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + item.MtImg00 +".jpg");
            
            //added txt to every mountain
            if (row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(mRowLayout, parent, false);
                //convertView = context.LayoutInflater.Inflate(Resource.Layout.ml_model, null);
            }
            TextView mtnametxt = row.FindViewById<TextView>(Resource.Id.mtnametxt);
            TextView Masltxt = row.FindViewById<TextView>(Resource.Id.masltxt);
            TextView Difficultytxt = row.FindViewById<TextView>(Resource.Id.difficultytxt);
            row.FindViewById<ImageView>(Resource.Id.mtimg).SetImageBitmap(imageBitmap);

            mtnametxt.Text = "Mt. " + item.MtName;
            Masltxt.Text = item.Masl + " MASL";
            Difficultytxt.Text = "Difficulty: " + item.Difficulty + "/9";
           

            mtnametxt.SetTypeface(tf, TypefaceStyle.Bold);
            Masltxt.SetTypeface(tf, TypefaceStyle.Bold);
            Difficultytxt.SetTypeface(tf, TypefaceStyle.Bold);

            NotifyDataSetChanged();
            return row;
        }
    }
}