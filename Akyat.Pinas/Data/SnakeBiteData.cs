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
    class SnakeBiteData
    {
        const string url = "https://ia801507.us.archive.org/10/items/mountainsData/SnakeBiteData.json";
        private static SnakeBite _snakeBite = new SnakeBite();


        public SnakeBiteData()
        {
            Task.Run(() => this.LoadDataAsync(url)).Wait();
        }

        private async Task LoadDataAsync(string uri)
        {
            if (_snakeBite != null)
            {

                string responseJsonString = null;

                using (var httpClient = new HttpClient())
                {
                    try
                    {
                        Task<HttpResponseMessage> getResponse = httpClient.GetAsync(uri);

                        HttpResponseMessage response = await getResponse;

                        responseJsonString = await response.Content.ReadAsStringAsync();
                        _snakeBite = JsonConvert.DeserializeObject<SnakeBite>(responseJsonString);
                    }
                    catch (Exception ex)
                    {
                        string message = ex.Message;
                    }
                }

            }
        }

        public SnakeBite GetSnakeBiteData()
        {
            return _snakeBite;
        }
    }
}