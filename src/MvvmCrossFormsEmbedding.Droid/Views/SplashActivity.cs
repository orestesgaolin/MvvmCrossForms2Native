using Android.App;
using Android.OS;
using MvvmCross;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Forms.Core;
using MvvmCross.Forms.Platforms.Android.Presenters;
using MvvmCross.Presenters;
using Xamarin.Forms;

namespace MvvmCrossFormsEmbedding.Droid.Views
{
    [Activity(
        NoHistory = true,
        MainLauncher = true,
        Label = "@string/app_name",
        Theme = "@style/AppTheme.Splash",
        Icon = "@mipmap/ic_launcher",
        RoundIcon = "@mipmap/ic_launcher_round")]
    public class SplashActivity : MvxSplashScreenAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Forms.Init(this, bundle);

            var mvxFormsApp = new MyMvxFormsApplication();
            MvxFormsAndroidViewPresenter presenter = Mvx.Resolve<IMvxViewPresenter>() as MvxFormsAndroidViewPresenter;
            //presenter.FormsApplication = mvxFormsApp;
        }
    }

    public class MyMvxFormsApplication : MvxFormsApplication
    {
    }
}
