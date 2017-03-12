using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Akyat.Pinas.Models;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Akyat.Pinas.Data;

namespace Akyat.Pinas
{
    public class MountainsService
    {
        private static MountainsData mountainsRepository = new MountainsData();
        private static FirstAidData firstaidRepository = new FirstAidData();
        private static LeaveNoTraceData leavenotraceRepository = new LeaveNoTraceData();
        private static SnakeBiteData snakebiteRepository = new SnakeBiteData();
        public List<Mountain> GetAllMountains()
        {
            return mountainsRepository.GetAllMountains();
        }

        public FirstAid GetFirstAidData()
        {
            return firstaidRepository.GetFirstAidData();
        }
        public LeaveNoTrace GetLeaveNoTraceData()
        {
            return leavenotraceRepository.GetLeaveNoTraceData();
        }
        public SnakeBite GetSnakeBiteData()
        {
            return snakebiteRepository.GetSnakeBiteData();
        }
    }
}