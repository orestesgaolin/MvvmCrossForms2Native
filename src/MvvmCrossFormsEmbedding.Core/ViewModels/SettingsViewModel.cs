using System;
using MvvmCross.Forms.Views;
using MvvmCross.Navigation;
using MvvmCross.Commands;
using MvvmCrossFormsEmbedding.Core.Models;
using Xamarin.Forms;
using MvvmCross.ViewModels;

namespace MvvmCrossFormsEmbedding.Core.ViewModels
{
    public class SettingsViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public MvxAsyncCommand CloseCommand { get; private set; }

        public MvxObservableCollection<Person> AllPeople { get; } = new MvxObservableCollection<Person>();

        public SettingsViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            CloseCommand = new MvxAsyncCommand(async () => await _navigationService.Close(this));
            AllPeople.Add(new Person
            {
                FullName = "Jan Nowak",
                Department = "Tests",
                Color = new Color(243, 194, 110),
            });
            AllPeople.Add(new Person
            {
                FullName = "Andrzej Kowalski",
                Department = "HR",
                Color = new Color(111, 181, 235),
            });
            AllPeople.Add(new Person
            {
                FullName = "Anna Jankowska",
                Department = "Service Desk",
                Color = new Color(243, 194, 110),
            });
        }
    }
}
