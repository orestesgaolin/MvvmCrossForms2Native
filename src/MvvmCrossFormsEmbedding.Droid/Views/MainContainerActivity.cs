using Android.App;
using Android.OS;
using Android.Views;
using MvvmCrossFormsEmbedding.Core.ViewModels;
using Xamarin.Forms;

namespace MvvmCrossFormsEmbedding.Droid.Views
{
    [Activity(
        Theme = "@style/AppTheme",
        WindowSoftInputMode = SoftInput.AdjustResize | SoftInput.StateHidden)]
    public class MainContainerActivity : BaseActivity<MainContainerViewModel>
    {
        //public static MainContainerActivity Instance { get; private set; }
        protected override int ActivityLayoutId => Resource.Layout.activity_main_container;

		//protected override void OnCreate(Bundle bundle)
		//{
		//	base.OnCreate(bundle);
  //          Instance = this;
		//}
	}
}
