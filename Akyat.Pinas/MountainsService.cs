using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Akyat.Pinas
{
    public class MountainsService
    {
        private static MountainsData mountainsRepository = new MountainsData();

        public List<Mountain> GetAllMountains()
        {
            return mountainsRepository.GetAllMountains();
        }

        ////public List<HotDogGroup> GetGroupedHotDogs()
        ////{
        ////    return hotDogRepository.GetGroupedHotDogs();
        ////}

        //public List<HotDog> GetHotDogsForGroup(int hotDogGroupId)
        //{
        //    return hotDogRepository.GetHotDogsForGroup(hotDogGroupId);
        //}

        //public List<HotDog> GetFavoriteHotDogs()
        //{
        //    return hotDogRepository.GetFavoriteHotDogs();
        //}

        //public HotDog GetHotDogById(int hotDogId)
        //{
        //    return hotDogRepository.GetHotDogById(hotDogId);
        //}
    }
}