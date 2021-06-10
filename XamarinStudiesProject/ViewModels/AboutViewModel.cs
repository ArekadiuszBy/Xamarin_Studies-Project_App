using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamarinTestApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Informacje";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://github.com/ArekadiuszBy"));
        }

        public ICommand OpenWebCommand { get; }
    }
}