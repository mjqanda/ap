using Android.App;
using Android.OS;

namespace Akyat.Pinas.MountainsActivities
{
    [Activity(Theme = "@style/Theme.NoTitle", Label = "cristobalAct")]
    public class cristobalAct : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.cristobalLayout);
            // Create your application here
        }
    }
}