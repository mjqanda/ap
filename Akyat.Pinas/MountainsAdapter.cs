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


        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            //added txt to every mountain
            var masl = " MASL"; var diff = "Difficulty: "; var mt = "Mt. "; var over = "/9";
            if (row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(mRowLayout, parent, false);
            }
            TextView mtnametxt = row.FindViewById<TextView>(Resource.Id.mtnametxt);
            mtnametxt.Text = mt+mtList[position].MtName;
                
            TextView Masltxt = row.FindViewById<TextView>(Resource.Id.masltxt);
            Masltxt.Text = mtList[position].Masl+masl;

            TextView Difficultytxt = row.FindViewById<TextView>(Resource.Id.difficultytxt);
            Difficultytxt.Text =  diff+mtList[position].Difficulty+over;

            ImageView Mtimg = row.FindViewById<ImageView>(Resource.Id.mtimg);
            Mtimg.SetImageResource(mtList[position].MtImg);

            mtnametxt.SetTextColor(Color.Black);
            Masltxt.SetTextColor(Color.Black);
            Difficultytxt.SetTextColor(Color.Black);
            return row;
        }
    }
}