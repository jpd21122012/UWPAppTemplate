using UWPAppTemplate.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UWPAppTemplate.Views
{
    public sealed partial class CameraPage : Page
    {
        public CameraViewModel ViewModel { get; } = new CameraViewModel();

        public CameraPage()
        {
            InitializeComponent();
        }
    }
}
