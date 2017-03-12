using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Akyat.Pinas.Data;
using Akyat.Pinas.Models;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Akyat.Pinas
{
    public class FirstAidService
    {
        //private static MountainsData mountainsRepository = new MountainsData();
        private static FirstAidData firstaidRepository = new FirstAidData();
       // private static LeaveNoTraceData leavenotraceRepository = new LeaveNoTraceData();
        //public List<Mountain> GetAllMountains()
        //{
        //    return mountainsRepository.GetData();
        //}

        public FirstAid GetFirstAidData()
        {
            return firstaidRepository.GetFirstAidData();
        }
        //public static List<LeaveNoTrace> GetLeaveNoTraceData()
        //{
        //    return leavenotraceRepository.GetLeaveNoTraceData();
        //}
    }
}