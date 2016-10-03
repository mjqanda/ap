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
    class MountainsData
    {
        public static List<Mountain> MountainList = new List<Mountain>()
            {
            new Mountain()
                {
                    MtName = "BATULAO",
                    Masl = 830,
                    Difficulty = 3,
                    MtImg = Resource.Drawable.batulao,
                    Location01 = "Nasugbu, Batangas",
                    Location02 ="Evercrest Golf Course, Nasugbu",
                    Description01 = "LLA: 14.0408 N 120.8011E 811 MASL \n\n Days required / Hours to summit: 1 day / 2-4 hours \n Specs: Minor climb, Difficulty 4/9, Trail class 3 with 60-70 degrees assault",
                    Description02 = "The cool weather in Mt. Batulao is a pleasant escape from the city. The moment you arrive at the Evercrest Golf Course – the jumpoff – you will feel the same coolness felt by the visitors of Tagaytay. And this temperature will be with you all the way, especially during the months of January and February, where it is usually dry and cool. There are days, on the other hand, when Mt. Batulao can feel like a desert – very hot and humid – owing to the exposed nature of its trails, which also makes it prone to muddiness during the wet season (June to October). On the other hand, Mt. Batulao is usually visited by winds that make any climb – hot or cool – refreshing. This combination of elements make Mt. Batulao a very interesting destination.",
                    Trail01 = "Old to New Trail",
                    Itenerary01 = "0400 ETD Coastal Mall bus terminal to Nasugbu, Batangas\n 0715 Arrival at Evercrest \n 0730 Start trek \n 0845 Arrival at Fork. \n 0900 Arrival at Camp 1. Register. \n 1015 Arrival at Camp 8, commence final assault \n 1100 Arrival at summit; lunch \n 1200 Start descent via New Trail, which is opposite the Old Trail at the summit\n 1300 Arrival at New Trail Campsite.Register again. \n 1530 Back at Evercrest; clean-up at nearby sari-sari store \n 1600 ETD for Tagaytay by jeepney \n 1630 ETA Tagaytay \n",
                    Trail02 = "New to Old Trail",
                    Iterenary02 = "0400 ETD Coastal Mall bus terminal to Nasugbu, Batangas\n 0715 Arrival at Evercrest\n 0730 Start trek\n 0845 Arrival at Fork.\n 0930 Arrival at New Trail Campsite. Rest / Register.\n 1030 Arrival at summit; early lunch\n 1200 Start descent via Old Trail\n 1300 Arrival at New Trail Campsite.Register again.\n 1530 Back at Evercrest; clean-up at nearby sari-sari store\n 1600 ETD for Tagaytay by jeepney\n 1630 ETA Tagaytay"
                },
                new Mountain()
                {
                    MtName = "TALAMITAM",
                    Masl = 630,
                    Difficulty = 2,
                    MtImg = Resource.Drawable.talamitam,
                    Location01 = "Nasugbu, Batangas",
                    Location02 ="Evercrest Golf Course, Nasugbu",
                    Description01 = "LLA: 14.0408 N 120.8011E 811 MASL \n\n Days required / Hours to summit: 1 day / 2-4 hours \n Specs: Minor climb, Difficulty 4/9, Trail class 3 with 60-70 degrees assault",
                    Description02 = "The cool weather in Mt. Batulao is a pleasant escape from the city. The moment you arrive at the Evercrest Golf Course – the jumpoff – you will feel the same coolness felt by the visitors of Tagaytay. And this temperature will be with you all the way, especially during the months of January and February, where it is usually dry and cool. There are days, on the other hand, when Mt. Batulao can feel like a desert – very hot and humid – owing to the exposed nature of its trails, which also makes it prone to muddiness during the wet season (June to October). On the other hand, Mt. Batulao is usually visited by winds that make any climb – hot or cool – refreshing. This combination of elements make Mt. Batulao a very interesting destination.",
                    Trail01 = "Old to New Trail",
                    Itenerary01 = "0400 ETD Coastal Mall bus terminal to Nasugbu, Batangas\n 0715 Arrival at Evercrest \n 0730 Start trek \n 0845 Arrival at Fork. \n 0900 Arrival at Camp 1. Register. \n 1015 Arrival at Camp 8, commence final assault \n 1100 Arrival at summit; lunch \n 1200 Start descent via New Trail, which is opposite the Old Trail at the summit\n 1300 Arrival at New Trail Campsite.Register again. \n 1530 Back at Evercrest; clean-up at nearby sari-sari store \n 1600 ETD for Tagaytay by jeepney \n 1630 ETA Tagaytay \n",
                    Trail02 = "New to Old Trail",
                    Iterenary02 = "0400 ETD Coastal Mall bus terminal to Nasugbu,"
                },
                new Mountain()
                {
                    MtName = "MAKILING",
                    Masl = 1090,
                    Difficulty = 5,
                    MtImg = Resource.Drawable.makiling,
                    Location01 = "Nasugbu, Batangas",
                    Location02 ="Evercrest Golf Course, Nasugbu",
                    Description01 = "LLA: 14.0408 N 120.8011E 811 MASL \n\n Days required / Hours to summit: 1 day / 2-4 hours \n Specs: Minor climb, Difficulty 4/9, Trail class 3 with 60-70 degrees assault",
                    Description02 = "The cool weather in Mt. Batulao is a pleasant escape from the city. The moment you arrive at the Evercrest Golf Course – the jumpoff – you will feel the same coolness felt by the visitors of Tagaytay. And this temperature will be with you all the way, especially during the months of January and February, where it is usually dry and cool. There are days, on the other hand, when Mt. Batulao can feel like a desert – very hot and humid – owing to the exposed nature of its trails, which also makes it prone to muddiness during the wet season (June to October). On the other hand, Mt. Batulao is usually visited by winds that make any climb – hot or cool – refreshing. This combination of elements make Mt. Batulao a very interesting destination.",
                    Trail01 = "Old to New Trail",
                    Itenerary01 = "0400 ETD Coastal Mall bus terminal to Nasugbu, Batangas\n 0715 Arrival at Evercrest \n 0730 Start trek \n 0845 Arrival at Fork. \n 0900 Arrival at Camp 1. Register. \n 1015 Arrival at Camp 8, commence final assault \n 1100 Arrival at summit; lunch \n 1200 Start descent via New Trail, which is opposite the Old Trail at the summit\n 1300 Arrival at New Trail Campsite.Register again. \n 1530 Back at Evercrest; clean-up at nearby sari-sari store \n 1600 ETD for Tagaytay by jeepney \n 1630 ETA Tagaytay \n",
                    Trail02 = "New to Old Trail",
                    Iterenary02 = "0400 ETD Coastal Mall bus terminal to Nasugbu,"
                },
                new Mountain()
                {
                    MtName = "CRISTOBAL",
                    Masl = 1480,
                    Difficulty = 5,
                    MtImg = Resource.Drawable.cristobal,
                    Location01 = "Nasugbu, Batangas",
                    Location02 ="Evercrest Golf Course, Nasugbu",
                    Description01 = "LLA: 14.0408 N 120.8011E 811 MASL \n\n Days required / Hours to summit: 1 day / 2-4 hours \n Specs: Minor climb, Difficulty 4/9, Trail class 3 with 60-70 degrees assault",
                    Description02 = "The cool weather in Mt. Batulao is a pleasant escape from the city. The moment you arrive at the Evercrest Golf Course – the jumpoff – you will feel the same coolness felt by the visitors of Tagaytay. And this temperature will be with you all the way, especially during the months of January and February, where it is usually dry and cool. There are days, on the other hand, when Mt. Batulao can feel like a desert – very hot and humid – owing to the exposed nature of its trails, which also makes it prone to muddiness during the wet season (June to October). On the other hand, Mt. Batulao is usually visited by winds that make any climb – hot or cool – refreshing. This combination of elements make Mt. Batulao a very interesting destination.",
                    Trail01 = "Old to New Trail",
                    Itenerary01 = "0400 ETD Coastal Mall bus terminal to Nasugbu, Batangas\n 0715 Arrival at Evercrest \n 0730 Start trek \n 0845 Arrival at Fork. \n 0900 Arrival at Camp 1. Register. \n 1015 Arrival at Camp 8, commence final assault \n 1100 Arrival at summit; lunch \n 1200 Start descent via New Trail, which is opposite the Old Trail at the summit\n 1300 Arrival at New Trail Campsite.Register again. \n 1530 Back at Evercrest; clean-up at nearby sari-sari store \n 1600 ETD for Tagaytay by jeepney \n 1630 ETA Tagaytay \n",
                    Trail02 = "New to Old Trail",
                    Iterenary02 = "0400 ETD Coastal Mall bus terminal to Nasugbu,"
                },
                new Mountain()
                {
                    MtName = "ULAP",
                    Masl = 1846,
                    Difficulty = 3,
                    MtImg = Resource.Drawable.ulap,
                    Location01 = "Nasugbu, Batangas",
                    Location02 ="Evercrest Golf Course, Nasugbu",
                    Description01 = "LLA: 14.0408 N 120.8011E 811 MASL \n\n Days required / Hours to summit: 1 day / 2-4 hours \n Specs: Minor climb, Difficulty 4/9, Trail class 3 with 60-70 degrees assault",
                    Description02 = "The cool weather in Mt. Batulao is a pleasant escape from the city. The moment you arrive at the Evercrest Golf Course – the jumpoff – you will feel the same coolness felt by the visitors of Tagaytay. And this temperature will be with you all the way, especially during the months of January and February, where it is usually dry and cool. There are days, on the other hand, when Mt. Batulao can feel like a desert – very hot and humid – owing to the exposed nature of its trails, which also makes it prone to muddiness during the wet season (June to October). On the other hand, Mt. Batulao is usually visited by winds that make any climb – hot or cool – refreshing. This combination of elements make Mt. Batulao a very interesting destination.",
                    Trail01 = "Old to New Trail",
                    Itenerary01 = "0400 ETD Coastal Mall bus terminal to Nasugbu, Batangas\n 0715 Arrival at Evercrest \n 0730 Start trek \n 0845 Arrival at Fork. \n 0900 Arrival at Camp 1. Register. \n 1015 Arrival at Camp 8, commence final assault \n 1100 Arrival at summit; lunch \n 1200 Start descent via New Trail, which is opposite the Old Trail at the summit\n 1300 Arrival at New Trail Campsite.Register again. \n 1530 Back at Evercrest; clean-up at nearby sari-sari store \n 1600 ETD for Tagaytay by jeepney \n 1630 ETA Tagaytay \n",
                    Trail02 = "New to Old Trail",
                    Iterenary02 = "0400 ETD Coastal Mall bus terminal to Nasugbu,"
                }
            };
        }

        
}