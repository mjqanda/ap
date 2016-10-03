using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics;

namespace Akyat.Pinas
{
    class MountainsAdapter : BaseAdapter<Mountain>
    {
        private Context mContext;
        private int mRowLayout;
        private List<Mountain> mtList;
        Activity context;


        public MountainsAdapter(Context context, int rowLayout, List<Mountain> mList)
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

        public void src(List<Mountain> mLists)
        {
            
            mtList.AddRange(mLists);
            NotifyDataSetChanged();
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            Typeface tf = Typeface.CreateFromAsset(mContext.Assets, "REFSAN.TTF");
            View row = convertView;
            //added txt to every mountain
            if (row == null)
            {
               row = LayoutInflater.From(mContext).Inflate(mRowLayout, parent, false);
               // convertView = context.LayoutInflater.Inflate(Resource.Layout.ml_model, null);
            }
            TextView mtnametxt = row.FindViewById<TextView>(Resource.Id.mtnametxt);
            mtnametxt.Text = "Mt. "+mtList[position].MtName;
                
            TextView Masltxt = row.FindViewById<TextView>(Resource.Id.masltxt);
            Masltxt.Text = mtList[position].Masl+" MASL";

            TextView Difficultytxt = row.FindViewById<TextView>(Resource.Id.difficultytxt);
            Difficultytxt.Text =  "Difficulty: "+mtList[position].Difficulty+"/9";

            ImageView Mtimg = row.FindViewById<ImageView>(Resource.Id.mtimg);
            Mtimg.SetImageResource(mtList[position].MtImg00);
            
            mtnametxt.SetTypeface(tf, TypefaceStyle.Bold);
            Masltxt.SetTypeface(tf, TypefaceStyle.Bold);
            Difficultytxt.SetTypeface(tf, TypefaceStyle.Bold);
            
            return row;
        }
    }
}