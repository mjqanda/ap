using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace Akyat.Pinas.Activities
{
    public class VideoFragment : DialogFragment
    {
        VideoView videof;
        public static MyDialogFragment newInstance()
        {
            MyDialogFragment f = new MyDialogFragment();
            return f;
        }
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetStyle(DialogFragmentStyle.NoTitle, Android.Resource.Style.ThemeBlackNoTitleBarFullScreen);
            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            //          return base.OnCreateView(inflater, container, savedInstanceState);
            View v = inflater.Inflate(Resource.Layout.video_fragment,container, false);

            videof = v.FindViewById<VideoView>(Resource.Id.videoView);

            string vid = Arguments.GetString("VID");
           

            videof.SetVideoPath(vid);
            
            //videof.SetImageResource(image);

            return v;
        }
    }
}