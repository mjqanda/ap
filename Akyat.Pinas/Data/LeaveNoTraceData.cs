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
    class LeaveNoTraceData
    {
        const string url = "https://ia601507.us.archive.org/10/items/mountainsData/LeaveNoTraceData.json";
        private static List<LeaveNoTrace> _leaveNoTraces = new List<LeaveNoTrace>();


        public LeaveNoTraceData()
        {
            Task.Run(() => this.LoadDataAsync(url)).Wait();
        }

        private async Task LoadDataAsync(string uri)
        {
            if (_leaveNoTraces != null)
            {

                string responseJsonString = null;

                using (var httpClient = new HttpClient())
                {
                    try
                    {
                        Task<HttpResponseMessage> getResponse = httpClient.GetAsync(uri);

                        HttpResponseMessage response = await getResponse;

                        responseJsonString = await response.Content.ReadAsStringAsync();
                        _leaveNoTraces = JsonConvert.DeserializeObject<List<LeaveNoTrace>>(responseJsonString);
                    }
                    catch (Exception ex)
                    {
                        string message = ex.Message;
                    }
                }

            }
        }

        public List<LeaveNoTrace> GetLeaveNoTraceData()
        {
            return _leaveNoTraces;
        }
    }
}