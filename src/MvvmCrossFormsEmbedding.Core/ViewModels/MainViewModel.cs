using System;
using System.Collections.Generic;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace MvvmCrossFormsEmbedding.Core.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public MvxAsyncCommand GoToFormsPageCommand { get; private set; }
        public MvxAsyncCommand GoToNativePageCommand { get; private set; }

        public MainViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            GoToFormsPageCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<SettingsViewModel>());
            //GoToNativePage = new MvxAsyncCommand(async () => await _navigationService.Navigate<ItemViewModel>());
        }
    }
}
