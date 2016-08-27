using Android.App;
using Android.OS;

namespace Akyat.Pinas.MountainsActivities
{
    [Activity(Theme = "@style/Theme.NoTitle", Label = "talamitamAct")]
    public class talamitamAct : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.talamitamLayout);
            // Create your application here


        }
    }
}