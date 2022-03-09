using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace kakao_leaves.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            astroImage = new Uri($"https://apod.nasa.gov/apod/image/2203/FlowerRock_Curiosity_1561.jpg");
        }

        public ICommand OpenWebCommand { get; }

        public Uri astroImage { get; set; }
    }
}