using Android.App;
using Android.OS;
using Android.Widget;
using MvvmCrossFormsEmbedding.Core.ViewModels;
using Xamarin.Forms;
using MvvmCross.Forms.Platforms.Android.Views;
using MvvmCrossFormsEmbedding.Core.Views;
using Xamarin.Forms.Platform.Android;

namespace MvvmCrossFormsEmbedding.Droid.Views
{
    [Activity(Theme = "@style/AppTheme",
              Label = "SettingsActivity")]
    public class SettingsActivity : MvxFormsAppCompatActivity<SettingsViewModel>
    {
        public static SettingsActivity Instance { get; private set; }

        protected override void OnCreate(Bundle bundle)
        {
			Forms.Init(this, null);
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.activity_settings);
            var toolbar = FindViewById<Toolbar>(Resource.Id.layout_toolbar);
            SupportActionBar.Title = "Settings";
            Instance = this;

            // #1 Initialize

            //// #2 Use it
            var frag = new SettingsView().CreateFragment(this);

            var ft = FragmentManager.BeginTransaction();
            ft.Replace(Resource.Id.fragment_frame_layout, frag, "main");
            ft.Commit();
        }
    }
}
