using System;
using System.Net.Http;
using System.Threading.Tasks;
using Akyat.Pinas.Models;
using Newtonsoft.Json;

namespace Akyat.Pinas.Data
{
    public class FirstAidData
    {
        const string url = "https://ia801507.us.archive.org/10/items/mountainsData/FirstAidData.json";
        private static FirstAid Firstaids = new FirstAid();

        public FirstAidData()
        {
            Task.Run(() => this.LoadDataAsync(url)).Wait();
        }

        private async Task LoadDataAsync(string uri)
        {
            if (Firstaids != null)
            {
                string responseJsonString = null;
                using (var httpClient = new HttpClient())
                {
                    try
                    {
                        Task<HttpResponseMessage> getResponse = httpClient.GetAsync(uri);

                        HttpResponseMessage response = await getResponse;

                        responseJsonString = await response.Content.ReadAsStringAsync();
                        Firstaids = JsonConvert.DeserializeObject<FirstAid>(responseJsonString);
                    }
                    catch (Exception ex)
                    {
                        string message = ex.Message;
                    }
                }

            }
        }
        public FirstAid GetFirstAidData()
        {
            return Firstaids;
        }
    }
}