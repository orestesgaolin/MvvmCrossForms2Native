using MvvmCross;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Platforms.Android.Presenters;
using MvvmCross.Presenters;
using MvvmCrossFormsEmbedding.Core;
using MvvmCross.Forms.Platforms.Android.Presenters;
using MvvmCrossFormsEmbedding.Droid.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace MvvmCrossFormsEmbedding.Droid
{
    public class Setup : MvxAppCompatSetup<App>
    {
        protected override IMvxAndroidViewPresenter CreateViewPresenter()
        {
            base.CreateViewPresenter();
            var presenter = new MvxFormsAndroidViewPresenter(GetViewAssemblies(), new MyMvxFormsApplication());
            Mvx.RegisterSingleton<IMvxViewPresenter>(presenter);

            return presenter;
        }

    }
}
