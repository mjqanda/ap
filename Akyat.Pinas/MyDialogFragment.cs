using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using Square.Picasso;

namespace Akyat.Pinas
{
    [Activity(Label = "MyDialogFragment")]
    public class MyDialogFragment : DialogFragment
    {
        ImageView imgf;
        Context mContext;
        public static MyDialogFragment newInstance()
        {
            MyDialogFragment f = new MyDialogFragment();
            return f;
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetStyle(DialogFragmentStyle.NoTitle, Android.Resource.Style.ThemeBlackNoTitleBarFullScreen);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View v = inflater.Inflate(Resource.Layout.fragment_dialog, container, false);
            imgf = v.FindViewById<ImageView>(Resource.Id.imageFragment);
            string image = this.Arguments.GetString("IMG1");
            var imageBitmap0 = ("https://ia801506.us.archive.org/35/items/mj_anda_yahoo_Pics/" + image + ".jpg");
            Picasso.With(mContext).Load(imageBitmap0).Into(imgf);
            return v;
        }
    }
}