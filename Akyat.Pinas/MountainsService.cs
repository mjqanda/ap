using System.Collections.Generic;
using Akyat.Pinas.Models;
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