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
using Android.Graphics;

namespace Akyat.Pinas
{
    class MountainsAdapter:BaseAdapter<Mountain>
    {
        private Context mContext;
        private int mRowLayout;
        public List<Mountain> mtList;

        // private int[] mAlternatingColors;
        public MountainsAdapter(Context context, int rowLayout, List<Mountain> mountains)
        {
            mContext = context;
            mRowLayout = rowLayout;
            mtList = mountains;
        }

        public override int Count
        {
            get { return mtList.Count; }
        }

        public override Mountain this[int position]
        {
            get { return mtList[position]; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;

         //   if (row == null)
          //  {
                row = LayoutInflater.From(mContext).Inflate(mRowLayout, parent, false);
           // }

           // row.SetBackgroundColor(GetColorFromInteger(mAlternatingColors[position % mAlternatingColors.Length]));


            TextView Mtnametxt = row.FindViewById<TextView>(Resource.Id.mtnametxt);
            Mtnametxt.Text = mtList[position].MtName;

            TextView Masltxt = row.FindViewById<TextView>(Resource.Id.masltxt);
            Masltxt.Text = mtList[position].MASL;

            TextView Difficultytxt = row.FindViewById<TextView>(Resource.Id.difficultytxt);
            Difficultytxt.Text = mtList[position].Difficulty;

            ImageView Mtimg = row.FindViewById<ImageView>(Resource.Id.mtimg);
            Mtimg.SetImageResource(mtList[position].ImgResourceId);

            //if ((position % 2) == 1)
            //{
           //Green background, set text white
            Mtnametxt.SetTextColor(Color.Black);
            Masltxt.SetTextColor(Color.Black);
            Difficultytxt.SetTextColor(Color.Black);
            //}

            //else
            //{
            //    //White background, set text black
            //    Mtnametxt.SetTextColor(Color.Black);
            //    Masltxt.SetTextColor(Color.Black);
            //    Difficultytxt.SetTextColor(Color.Black);
            //}

            return row;
        }

        //private Color GetColorFromInteger(int color)
        //{
        //    return Color.Rgb(Color.GetRedComponent(color), Color.GetGreenComponent(color), Color.GetBlueComponent(color));
        //}
    }
}