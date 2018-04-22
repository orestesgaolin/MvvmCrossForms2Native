
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using MvvmCrossFormsEmbedding.Core.ViewModels;
using Xamarin.Forms.Xaml;
using MvvmCross.Forms.Views;
using MvvmCross.Binding.BindingContext;

namespace MvvmCrossFormsEmbedding.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsView : MvxContentPage<SettingsViewModel>
    {
        public SettingsView()
        {
            InitializeComponent();
        }
    }
}
