using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace kakao_leaves.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Astronomy Picture of the Day";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            Preparepage();
        }

        private async void Preparepage()
        {
            string url = await CallApodApi();

            AstroImage = new Uri(url);
        }

        private async Task<string> CallApodApi()
        {
            string url = string.Empty;

            client = new HttpClient
            {
                BaseAddress = new Uri("https://api.nasa.gov/planetary/apod")
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("?api_key=DEMO_KEY").Result;
            if (response.IsSuccessStatusCode)
            {
                var body = response.Content.ReadAsStringAsync().Result;
                JObject Ject = JObject.Parse(body);
                if (Ject["media_type"].ToString() == "image")
                {
                    url = Ject["hdurl"].ToString();
                }
                else
                {
                    url = "https://apod.nasa.gov/apod/image/2202/Chamaeleon_RobertEder.jpg";
                }
            }
            return url;
        }

        public ICommand OpenWebCommand { get; }

        public Uri AstroImage { get; set; }

        public HttpClient client;
    }
}