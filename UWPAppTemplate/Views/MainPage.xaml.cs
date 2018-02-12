using System;

using UWPAppTemplate.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UWPAppTemplate.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
