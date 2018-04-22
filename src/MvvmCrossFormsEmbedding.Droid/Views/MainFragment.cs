using Android.OS;
using Android.Views;
using MvvmCrossFormsEmbedding.Core.ViewModels;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Binding.BindingContext;

namespace MvvmCrossFormsEmbedding.Droid.Views
{
    [MvxFragmentPresentation(typeof(MainContainerViewModel), Resource.Id.content_frame)]
    public class MainFragment : BaseFragment<MainViewModel>
    {
        protected override int FragmentLayoutId => Resource.Layout.fragment_main;

        //public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        //{
        //    base.OnCreateView(inflater, container, savedInstanceState);

        //    var view = this.BindingInflate(Resource.Layout.fragment_main, null);
        //    return view;
        //}
    }
}
