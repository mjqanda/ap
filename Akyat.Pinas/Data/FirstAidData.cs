using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Akyat.Pinas.Models;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;

namespace Akyat.Pinas.Data
{
    public class FirstAidData
    {
        const string url = "https://ia601507.us.archive.org/10/items/mountainsData/FirstAidData.json";
        private static List<FirstAid> Firstaids = new List<FirstAid>();


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
                        Firstaids = JsonConvert.DeserializeObject<List<FirstAid>>(responseJsonString);
                    }
                    catch (Exception ex)
                    {
                        string message = ex.Message;
                    }
                }

            }
        }

        public List<FirstAid> GetFirstAidData()
        {
            return Firstaids;
        }
    }
}