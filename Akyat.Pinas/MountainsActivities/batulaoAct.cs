using Android.App;
using Android.OS;

namespace Akyat.Pinas.MountainsActivities
{
    [Activity(Theme = "@style/Theme.NoTitle", Label = "batulaoAct")]
    public class batulaoAct : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.batulaoLayout);
            // Create your application here
        }
    }
}