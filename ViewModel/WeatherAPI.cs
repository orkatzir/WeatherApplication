using System.Net.Http;
using System.Threading.Tasks;
using Weather.Model;
namespace Weather.ViewModel
{
    class WeatherAPI
    {
        public const string API_KEY = "UE8o0ALLQM6xbAQeoaVuxWaVgTIlcRlM";
        public const string BASE_URL = "http://dataservice.accuweather.com/forecasts/v1/daily/5day/{0}?apikey={1}&metric=true";

        public static async Task<AccuWeather> GetWeatherInformationAsync(string locationKey)
        {
            AccuWeather result = new AccuWeather();

            string url = string.Format(BASE_URL, locationKey, API_KEY);

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                string json = await response.Content.ReadAsStringAsync();

                result = JsonConvert.DeserializeObject<AccuWeather>(json);
            }

            return result;
        }
    }
}
