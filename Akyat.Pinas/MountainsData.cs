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
using SQLite;
using System.IO;

namespace Akyat.Pinas
{
    class MountainsData
    {
        public static List<Mountain> MountainList = new List<Mountain>()
            {
            new Mountain()
                {
                    MtName = "ALTO PEAK",
                    Masl = 1332,
                    Difficulty = 6,
                    Island = 2,
                    MtImg00 = Resource.Drawable.altopeak,
                    MtImg01 = Resource.Drawable.altopeak1,
                    MtImg02 = Resource.Drawable.altopeak2,
                    MtImg03 = Resource.Drawable.altopeak3,
                    MtImg04 = Resource.Drawable.altopeak4,
                    Location = "ORMOC, LEYTE",
                    JumpOff ="Lake Danao National Park, Ormoc",
                    Description ="LLA: 11.1061 N, 124.7097 E, 1332 MASL\nDays required: 3-4 days\nHours to summit: 11-14 hrs\nSpecs: Minor climb, Difficulty: 6/9\nTrail class: 3 with unestablished trail\nFeatures: Scenic views of Leyte\n\n",
                    Background ="Alto Peak is located in Ormoc Leyte, it is named Alto Peak because 'Alto' in Spanish means 'High'. It is also the highest mountain in Eastern Visayas (Region VIII), Alto Peak stands majestically on a beautiful realm, the Lake Danao National Park, home to a rich variety of flora and fauna. The domain is also home to farming communities whose vegetable plantations and cool climate.\n\nThe jump-off point of the hike is Lake Danao. It is said to be home of giant eels, carps, and other freshwater creatures, the lake is an outdoor destination in itself, with an already impressive elevation of about 830 MASL.\n\n",
                    Itinerary = "Day 0\n\nArrival at Lake Danao from Ormoc\n\nDay 1\n\n0700 ETD from Lake Danao\n1100 ETA Lake Hanagdan\n1200 Resume trek\n1500 Reach PNOC old drilling site\n1700 Reach campsite\n\nDay 2\n\n0500 Early breakfast\n0600 Commence summit assault (no established trail)\n1200 ETA Alto Peak; lunch at summit\n1300 Start descent\n1800 Back at campsite\n\nDay 3\n\n0500 Start descent\n0900 Back at Campsite\n1000 Resume trek to Lake Hanagdan\n1500 ETA Lake Hanagdan\n1800 Back at Lake Danao\n\nDay 4\n\nHead back to Ormoc and proceed to final destination",
                    Note = "NOTE: THIS MOUNTAIN IS NOT FOR BEGINNERS!",
                    Practicalities = "Transportation\nPublic (1) From Ormoc City to Lake Danao (45 mins)\n\nRegistration\nLogbook at National Park\n\nGuides\nAvailable \n\nContact Numbers\nMs. Corazon Makabenta (Ormoc Tourism) - 09172778884\nJhoc Nalda (Guide) - 09172558923\n\nCampsites\n(1) Campsite 1\n(2) Campsite 2\n\nWater sources\nWater sources coming from the lake\n\nCell phone signal\nPresent in some parts of the trail\n\nRiver crossing\nNone\n\nRope Segments\nNone\n\nSidetrips\nThe two lakes of Alto Peak\n\nAlternate trails\nNone\n\nDayhikable\nNo\n\nFacilities at jump-off\nSari-sari storeBarangay\n\nEstimated budget\n1500-1700\n\n",
                    Attire = "Jacket, Windbreaker or Shirt\nTrekking Pants\nHiking Shoes\nCap or bush hat",
                    Ttb = "Backpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"
                  
                },

                new Mountain()
                {
                    MtName = "APO",
                    Masl = 2956,
                    Difficulty = 7,
                    Island = 3,
                    MtImg00 = Resource.Drawable.apo,
                    MtImg01 = Resource.Drawable.apo1,
                    MtImg02 = Resource.Drawable.apo2,
                    MtImg03 = Resource.Drawable.apo3,
                    MtImg04 = Resource.Drawable.apo4,
                    MtImg05 = Resource.Drawable.apo5,
                    Location = "KIDAPAWAN CITY AND MAGPET, NORTH COTABATO",
                    JumpOff ="(Entry point) Brgy. Ilomavis, Kidapawan(Exit point) Brgy. Kisandal, Magpet",
                    Description ="LLA: 7�0'30 N, 125�16'33 E, 2,956\nDays required: 3 day\nHours to summit: 10-11 hrs\nSpecs: Major climb, Difficulty: 7/9\nTrail class: 3\nFeatures: Mossy forest, lake, sulfuric rocks\n\n",
                    Background ="Mt. Apo, the highest mountain in the Philippines, towering over Southern Mindanao, covering the provinces of Davao del Sur and North Cotabato. At 2,956 MASL, it possesses a formidable array of landscapes, from craggy rockscapes to virgin forests; from mossy swamps to volcanic structures. Indeed, Mt. Apo possesses the wildest spectrum of environments, and provides an experience for mountaineers that lives up to their expectations from the country�s highest.\n\nThe Kidapawan trail, one of many trails, will take you first to Lake Agko. From there, you will have to cross Marbel river in an unforgettable adventure: you have to cross the river several times by walking through coconut logs without anything to hold for support. Even here, lichens cling on the rocks, and very tall trees rise to the sky. The threat of sudden flashfloods, emphasized by the strong flow of water, will remind the intrepid hiker that he not climbing an ordinary mountain. \n\nAfter three hours of river crossing, you would reach the first campsite, at the Mainit Hot Springs. Here, there is a small pool where you could dip; the water is hot and very soothing. You must reach this campsite before 1500hr, because the next campsite is already Lake Venado, 5-6 hours away. Between the two campsites is a thick forest which you have to cross. Here, two �killer trails� are upcoming: the �87-degree� and the �90-degree� trail. Each taking around 15 minutes, these trails are known to have taken their toll on climbers. As of 2006, ropes are in place in the �90-degrees� to make it a little bit safer.\n\n",
                    Itinerary = "(Via Kidapawan-Magpet Trail)\n\nDay 1\n\n0500 Take van from Davao City to Kidapawan\n0730 ETA Kidapawan City; register and secure guides at Tourism Office\n0830 Proceed to Brgy. Ilomavis\n1000 ETA Brgy. Ilomavis, start trek\n1300 ETA Mainit Hot Springs\n1700 ETA Lake Venado (2280 MASL). Set up camp.\n\nDay 2\n\n0400 Early breakfast\n0500 Start summit assault\n0800 ETA summit of Mt. Apo\n1000 Start descent to Lake Venado\n1230 ETA Lake Venado; head to Bobbong campsite\n1800 ETA Bobbong campsite\n1900 Dinner / socials\n\nDay 3\n\n0600 Wake-up call / breakfast\n0800 Start descent to Bongolanon Falls\n1200 ETA Bongolanon Falls; Lunch.\n1300 Return to Kidapawan\n1500 ETA Kidapawan\n1800 ETA Davao City",
                    Note = "NOTE: THIS MOUNTAIN IS NOT FOR BEGINNERS!",
                    Practicalities = "Transportation\nPublic (1) Via Plane to Davao (2) hire a cab to Gaisano Mall tell the driver to bring you to the van terminal for kidapawan (P150; 3 hrs)\n\nRegistration\nClimb Fee P500 per pax (P750 for foreign nationals P400 for students)\n\nGuides\nAvailable, P800 per day\nPorter: P350 per day\n\nContact Numbers\nKidapawan Tourism Officer, Joey Recimilla - 09399064243\n\nCampsites\nBobbong Campsite\n\nWater sources\nThere are water sources near the campsite\n\nCell phone signal\nCellphone signal is present in the summit and partially in Lake Venado; it is sporadic elsewhere\n\nRope Segments\nRopes are in place in the 90� trail assault after Lake Venado\n\nSidetrips\nDavao City and beaches\n\nAlternate trails\n(1) Kapatagan trail\n(2) Traverse to Mt. Talomo\n(3) Sibulan Trail\n\nDayhikable\nNo\n\nFacilities at jump-off\nSari-sari store\nWash up area\n\nEstimated budget\n1000-1500 from Davao City\n\n",
                    Attire = "Jacket, Windbreaker or Shirt\nTrekking Pants\nHiking Shoes\nCap or bush hat",
                    Ttb = "Backpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"

                },

                new Mountain()
                {
                    MtName = "ARAYAT",
                    Masl = 1030,
                    Difficulty = 3,
                    Island = 1,
                    MtImg00 = Resource.Drawable.arayat,
                    MtImg01 = Resource.Drawable.arayat1,
                    MtImg02 = Resource.Drawable.arayat2,
                    MtImg03 = Resource.Drawable.arayat3,
                    Location = "PAMPANGA",
                    JumpOff ="Brgy. Bano, Arayat",
                    Description ="LLA: 15.20� N, 120.742� E, 1030 MASL\nDays required:  1 day\nHours to summit: 4 hrs\necs: Minor climb, Difficulty: 3/9\nTrail class: 3\nFeatures: Scenic views of Pampanga\n\n",
                    Background ="Mt. Arayat rises in the central plains of Luzon and the pride of all Kapampangans. Mt. Arayat National Park was built with natural pools, picnic areas, and the mountain trail that leads to Arayat�s Peak 1. Although the National Park has degenerated into a local resort, it is still the jump-off for Arayat climbs. When Arayat�s Peak 1 is reached hikers can enjoy the spectacular view deck, where they can behold seemingly all of Central Luzon.\n\nThe Peak 2 of Mt. Arayat can accessed also to the other side of the mountain which is Magalang, Pampanga. In either trails, the �balding� of the mountain is evidenced by the intense heat of the sun. Still, some forests survive and therein, monkeys continue to roam free. You can hear their calls along the last leg of the trail. There are also sightings of wild boar, local civet (musang), and native birds.\n\nNPA scare continues to scare hikers from climbing Arayat, but there is now military presence in the trails, and the last pockets of NPA resistance were subjugated in 2002. Thus Arayat remains one of the most exciting hiking destinations in Luzon.\n\n",
                    Itinerary = "Via Arayat National Park\n\n0500 ETD Monumento, take bus to Arayat, Pampanga (P120)\n0730 ETA Arayat Pampanga. (If private vehicle, take San Simon exit at NLEX)\n0800 ETA Arayat National Park; register and negotiate (P100 and guide)\n0830 Start trek\n200 ETA peak campsite; lunch. You may explore the viewdeck\n1300 Start descent\n1530 ETA National Park; bathe at the natural pools\n1600 Head back to Manila or to Angeles City for sidetrips\n",
                    Practicalities = "Transportation\nPublic (1) Bus from Cubao to San Fernando Pampanga (P200 1.5-2 hrs) (2) jeepney SM Pampanga to Magalang-bound (P50 30 mins) then take tricycle to Brgy. Ayala (P100)\n\nRegistration\nDonations, No fees but registration is needed\n\nGuides\nAvailable P500 per group\nP1500-2000 for foreigners\n\nContact Numbers\nJason Guttierez (Guide/ Porter) � 09217255561\n\nCampsites\n(1) Summit Campsite\n\nWater sources\nNone\n\nCell phone signal\nPresent all throughout the hike\n\nRiver crossing\nNone\n\nRope Segments\nNone\n\nSidetrips\nAngeles City or Subic\n\nAlternate trails\nTraverse via Magalang Trail\n\nDayhikable\nYes (4 hrs up, 3 hrs down)\n\nFacilities at jump-off\nSari-sari stores\nWash up area\n\nEstimated budget\n700-800\n\n",
                    Attire = "Dryfit or Shirt\nTrekkin pants or Short\nHiking shoes or Sandals\nCap or bush hat",
                    Ttb = "Dayhike\n\nBackpack 28L capacity\nHiking shoes or sandals\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nPacked lunch\nTrail food\nMess kit (Spoon & fork)\nMulti-tool (swiss knife)\nMap or Compass\nWater or energy drink\ngloves (optional) \n\nOvernight\n\nBackpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"

                    },

                new Mountain()
                {
                    MtName = "BANOI",
                    Masl = 960,
                    Difficulty = 3,
                    Island = 1,
                    MtImg00 = Resource.Drawable.banoi,
                    MtImg01 = Resource.Drawable.banoi1,
                    MtImg02 = Resource.Drawable.banoi2,
                    MtImg03 = Resource.Drawable.banoi3,
                    MtImg04 = Resource.Drawable.banoi4,
                    MtImg05 = Resource.Drawable.banoi5,
                    Location = "LOBO, BATANGAS",
                    JumpOff ="Sitio Malabnig, Brgy. Balatbat, Lobo",
                    Description ="LLA: 960 MASL\nDays required: 1 day\nHours to summit: 3-5 hrs\nSpecs: Minor climb, Difficulty: 3/9\nTrail class: 1-3\nFeatures: Woodlands, scenic views of Southern Batangas\n\n",
                    Background ="Mt. Banoi is part of the mountain range that surrounds the town of Lobo, which, at 30 kilometers away from Batangas City, which is one of the most distant towns of Batangas province relative to Metro Manila. Before starting the hike, you must register to the Lobo Police Station to notify them that you will hike the mountain.\n\nThe hike starts at the Chapel at the end of the road of Brgy. Balatbat, which is also the beginning of the trail to Sitio Malabnig. The trail is generally straightforward and is not particularly confusing. You can ask locals along the way; there are houses along the way. The trail passes through woodlands. Malabnig Village is the major landmark along the trail, it is actually a community of more than a dozen houses at around 400 MASL, and beyond this lies the trail to the peaks. The first peak, the Front Peak, has an electric post and can serve as a campsite. Then, beyond it and in the same direction lies Two Towers� Peak (850 MASL) which is easily identifiable with its two communications towers. The Main Peak (960 MASL) is the final peak, forested that you can see from the Main Peak. There is a small, cement landmark that can be regarded as the summit marker. Features of the mountain include the beautiful scenes of farm animals, villages, and pastoral activities along the way. Then, at the top, the whole town of Lobo can be seen, and so is Batangas City and Verde Island south of it, as well as the sea lanes. The downside of Mt. Banoi is that its views, while remarkable, are not that spectacular, and the distance (3 hours travel time) may not justify it as a dayhike venue. Yet, it is still a high peak, a worthwhile challenge.\n\n",
                    Note = "NOTE: THIS MOUNTAIN IS NOT FOR BEGINNERS!",
                    Itinerary = "Dayhike\n\n0400 From Manila, take bus to Batangas City\n0530 Drop off at Balagtas. Take jeep to Lobo Jeepney terminal\n0600 From Lobo Jeepney Terminal, take jeep to Lobo\n0700 ETA Lobo Town Hall. Register at Police Station\n0730 Take tricycle to \"Malabnig, Brgy. Balatbat\"\n0800 ETA jumpoff, Start trek\n0915 ETA Waiting Shed (Water Source)\n1000 Arrival at Malabnig Village (Last Water Source)\n1100 Arrival at Front Peak (770 MASL)\n1130 Arrival at Two Towers� Peak (850 MASL)\n1200 Arrival at Main Peak (960 MASL)\n1300 Start descent\n1530 Back at Jumpoff\n1700 Last trip Lobo to Batangas City\n1800 ETA Batangas City. Take jeep to Balagtas Junction\n1820 Dinner / Take bus back to Manila\n2100 ETA Manila",
                    Practicalities = "Transportation\nPublic (1) Take bus to Balagtas, Batangas City (2) take jeep to Lobo Jeepney Terminal (3) take a jeep to Lobo town hall (4) Tricycle to Malabnig, Brgy. Balatbat\n\nRegistration\nLogbook in Malabnig Village\n\nGuides\nAvailable in Malabnig Village, but not mandatory\n\nContact Numbers\nNoneCampsites\nFront Peak or somewhere near the village\n\nWater sources\nAt the starting point of the trail\n\nCell phone signal\nYes, Available throughout the hike\n\nRope Segments\nNone\n\nSidetrips\nBeaches of Lobo are near in the town proper or climb sidetrips in Lobo Mountains\n\nAlternate trails\nNone\n\nDayhikable\nYes (3-5 hrs ascent, 2-3 hrs down)\n\nFacilities at jump-off\nChurch\nPolice station\nSari-sari store\n\nEstimated budget\n800-900\n\n",
                          Attire = "Dryfit or Shirt\nTrekkin pants or Short\nHiking shoes or Sandals\nCap or bush hat",
       Ttb = "Dayhike\n\nBackpack 28L capacity\nHiking shoes or sandals\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nPacked lunch\nTrail food\nMess kit (Spoon & fork)\nMulti-tool (swiss knife)\nMap or Compass\nWater or energy drink\ngloves (optional) \n\nOvernight\n\nBackpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"

                },

                new Mountain()
                {
                    MtName = "BATOLUSONG",
                    Masl = 645,
                    Difficulty = 3,
                    Island = 1,
                    MtImg00 = Resource.Drawable.batolusong,
                    MtImg01 = Resource.Drawable.batolusong1,
                    MtImg02 = Resource.Drawable.batolusong2,
                    MtImg03 = Resource.Drawable.batolusong3,
                    MtImg04 = Resource.Drawable.batolusong4,
                    MtImg05 = Resource.Drawable.batolusong5,
                    Location = "TANAY, RIZAL",
                    JumpOff ="Brgy. San Andres, Tanay, Rizal",
                    Description ="LLA: 645 MASL (Mapatag Plateau) 780 MASL (Susong Dalaga) \nDays required:  1 day\nHours to summit: 2 hrs\nSpecs: Minor climb, Difficulty: 3/9\nTrail class: 1-3\nFeatures: Grassland slopes, Scenic views of Laguna, Rizal, Quezon\n\n",
                    Background ="Mt. Batolusong, one of the many potential hiking destinations in Tanay, Rizal, since the town is part of the southern tail end of the Sierra Madre, the longest mountain range in the Philippines. The major jump-off of the hike is Brgy. San Andres because of the security reasons and hikers need assistance in the barangay hall.\n\nThe hike starts at Brgy. San Andres where hikers need to register first and arrange a guide because it is mandatory to hire. The first 15 minutes crossing the trails with rice fields and will take you to a blue clear water looking cave, then the trail will require to cross a dry river which is huge when rainy season starts. The ascent to the Mapatag Plateau is very easy and quick but be mindful that the hot weather can be dangerous. Mapatag Plateau can be the final endpoint of the hike � it is a grassland slope that serves as a scenic viewpoint and a possible campsite.\n\nIt is possible to go to Susong Dalaga Peak which takes about 2 hours from Mapatag Plateau according to the guides of Mt. Batolusong. Also, a new Peak is open named �Rangyas Peak� which offers the view of the eastern side of the Mountain.\n\n",
                    Itinerary = "Batolusong (Mapatag Plateau) Dayhike\n\n0500 Leave Manila for Antipolo City (Cogeo Gate 2)\n0600 ETA Cogeo Gate 2; Take jeep to Brgy. Sampaloc\n0730 Drop off at �Batangas�; take habal-habal to Brgy. San Andres\n0800 ETA Brgy. San Andres; courtesy call to local officials/ get guides\n0830 Start trek\n0945 Arrival at Duhatan Ridge (590m)\n1000 Arrival at Mapatag Plateau (645m)\n1030 Start descent\n1145 Back in Brgy. Sampaloc. Tidy up/ Lunch\n1230 Head back to �Batangas�\n1300 ETA �Batangas� junction, Wait for return jeepney\n1430 Back at Antipolo City, Take jeep/bus back to Manila\n1600 ETA Manila",
                    Practicalities = "Transportation\nPublic (1) Van or FX, from Manila to Antipolo, Cogeo Gate 2 terminal (2) jeepney to Batangasan junction arch of Brgy. San Andres (3) then take Tricycle to the jump-off\n\nRegistration\nP25 at Brgy. San Andres\n\nGuides\nAvailable P400 per day\nContact Numbers\nNo contacts yet\n\nCampsites\n(1) Mapatag Plateau\n\nWater sources\nThe first part of the trail\n\nCell phone signal\nPresent all throughout the hike\n\nRiver crossing\nThe dry river that can swell during the rainy seasons\n\nRope Segments\nNone\n\nSidetrips\nKay-Ibon Falls\n\nAlternate trails\nNne\n\nDayhikable\nYes (2 hrs up, 1 hr down)\n\nFacilities at jump-off\nSari-sari stores\nWash up area\nBarangay\n\nEstimated budget\n500-800\n\n",
                        Attire = "Dryfit or Shirt\nTrekkin pants or Short\nHiking shoes or Sandals\nCap or bush hat",
           Ttb = "Dayhike\n\nBackpack 28L capacity\nHiking shoes or sandals\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nPacked lunch\nTrail food\nMess kit (Spoon & fork)\nMulti-tool (swiss knife)\nMap or Compass\nWater or energy drink\ngloves (optional) \n\nOvernight\n\nBackpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"

                    },

                new Mountain()
                {
                    MtName = "BATULAO",
                    Masl = 811,
                    Difficulty = 4,
                        Island = 1,
                    MtImg00 = Resource.Drawable.batulao,
                    MtImg01 = Resource.Drawable.batulao1,
                    MtImg02 = Resource.Drawable.batulao2,
                    MtImg03 = Resource.Drawable.batulao3,
                    MtImg04 = Resource.Drawable.batulao4,
                    MtImg05 = Resource.Drawable.batulao5,
                    Location = "NASUGBU, BATANGAS",
                    JumpOff ="Evercrest Golf Course, Nasugbu",
                    Description ="LLA: 14.0408 N 120.8011 E 811 MASL \nDays required: 1 day (dayhike) 2days (overnight)\nHours to summit: 2-4 hrs \nSpecs: Minor climb, Difficulty: 4/9 \nTrail class: 3 with 60-70� assault \nFeatures: Open trails, rolling slopes, scenic views of Batangas\n\n",
                    Background ="Mt. Batulao is the best place to visit and hike because the mountain is accessible near Manila and Cavite, the transportation to go there is so easy that hikers can commute in just one way trip to the jump-off point. Evercrest is the jump-off point which hikers can ride a P50 tricycle fee to the registration point of Batulao. Beginner hikers can hire a guide to accompany them during their hike on the mountain but guides are not mandatory because the mountain is a minor climb even solo or group hikes can be safe in an open trails of the mountain.\n\nThe weather in Mt. Batulao is a pleasant escape from the city because of the location of the mountain which is near Tagaytay city. The cool weather occurs during the months of January and February even in the rainy seasons. During summer the hikers can feel like they are in the desert because of the hot and humid open trails of the mountain, on the other hand the mountain makes the trail prone to muddiness during the rainy season (June to October). The landscapes of Mt. Batulao are quite remarkable it shows the whole view of its body and the rocky formations of the peaks throughout the hike; and although the view remains basically the same throughout the hike, the rolling slopes, through which trail pass by, and the new variety afforded by two major trails \"Old Trail\" and \"New Trail\", makes Batulao one of the most popular dayhikes or near Manila hikes.\n\n",
                    Itinerary = "Old to New Trail \n\n0400 ETD Coastal Mall bus terminal to Nasugbu, Batangas\n0715 Arrival at Evercrest\n0730 Start trek\n0845 Arrival at Fork. Take the left, downward trail that enters the forested area\n0900 Arrival at Camp 1. Register\n1015 Arrival at Camp 8, commence final assault\n1100 Arrival at summit; lunch\n1200 Start descent via New Trail, which is opposite the Old Trail at the summit\n1300 Arrival at New Trail Campsite. Register again.\n1530 Back at Evercrest; clean-up at nearby sari-sari store\n1600 ETD for Tagaytay by jeepney (P30.00)\n1630 ETA Tagaytay; Side trips, Dinner\n1800 ETD Tagaytay city to Coastal Mall Bus Terminal\n\nNew to Old Trail\n\n0400 ETD Coastal Mall bus terminal to Nasugbu, Batangas\n	0715 Arrival at Evercrest\n0730 Start trek\n0845 Arrival at Fork. Take the slightly right upward trail\n0930 Arrival at New Trail Campsite. Rest/ Register\n1030 Arrival at summit; early lunch\n1200 Start descent via Old Trail, which is opposite the New Trail at the summit\n1300 Arrival at New Trail Campsite. Register again\n1530 Back at Evercrest; clean-up at nearby sari-sari store\n1600 ETD for Tagaytay by jeepney (P30.00)\n1630 ETA Tagaytay; Side trips, Dinner\n1800 ETD Tagaytay city to Coastal Mall Bus Terminal",
                    Practicalities = "Transportation\nPublic (1) Nasugbu-bound bus, Coastal Mall to Evercrest (P104) (2) Optional Tricycle, Evercrest to Registration area (P25 per pax).\nPrivate from Manila go to Tagaytay city and then proceed to Tagaytay-Nasugbu road until Evercrest Golf Course reached. Go past the gate, follow through, turn left at the fork, and then go down the rough road to the trailhead. (Approximately 2.5 hours)\n\nRegistration\nLogbook at the first registration point before starting the hike. Also, Old and New Trail campsites. Total fees per hiker P20 per pax (dayhike); P30 per pax when camping.\n\nGuides\nAvailable (P300-P400/day); not mandatory\n\nContact Numbers\nNew Trail Campsite (Roel) +639279008496\nNasugbu Police Station � (043) 931-9952\n\nCampsites\nNew Trail Campsite\nOld Trail Campsite\n\nWater sources\nAvailable in campsites � ask from caretakers.\n\nCell phone signal\nPresent in most parts of the trail\n\nRope Segments\nFixed rope in steep part of the Old Trail and before reaching the summit from New Trail\n\nSidetrips\nLunch, Dinner at Tagaytay city after the hike, Calaruega Church near the Jump-off point\n\nAlternate trails\nToong trail from New Trail to Mt. Talamitam\n\nDayhikable\nYes (2-3 hrs to summit; 1.5-2 hrs down)\n\nFacilities at jump-off\nSari-sari store, Shower facilities or Ligo for P10 per timba, Parking P50\n\nEstimated budget\n500-900",
                       Attire = "Dryfit or Shirt\nTrekkin pants or Short\nHiking shoes or Sandals\nCap or bush hat",
        Ttb = "Dayhike\n\nBackpack 28L capacity\nHiking shoes or sandals\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nPacked lunch\nTrail food\nMess kit (Spoon & fork)\nMulti-tool (swiss knife)\nMap or Compass\nWater or energy drink\ngloves (optional) \n\nOvernight\n\nBackpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"
    },

                new Mountain()
                {
                    MtName = "BINACAYAN",
                    Masl = 424,
                    Difficulty = 3,
                    Island = 1,
                    MtImg00 = Resource.Drawable.binacayan,
                    MtImg01 = Resource.Drawable.binacayan1,
                    MtImg02 = Resource.Drawable.binacayan2,
                    MtImg03 = Resource.Drawable.binacayan3,
                    MtImg04 = Resource.Drawable.binacayan4,
                    MtImg05 = Resource.Drawable.binacayan5,
                    Location = "RODRIGUEZ, RIZAL",
                    JumpOff ="Brgy. Wawa, Rodriguez, Rizal",
                    Description ="LLA: 14�43�30.5 N, 121�11�26.1 E, 424 MASL\nDays required:  1 day\nHours to summit: 2-3 hrs\nSpecs: Minor climb, Difficulty: 3/9\nTrail class: 1-4\nFeatures: Limestone formations, scenic views of Sierra Madre and Rizal Province\n\n",
                    Background ="Mt. Binacayan, located in Brgy. Wawa Rodriguez, Rizal, has long been known to outdoor enthusiasts for its beautiful Montalban Gorge and various activities that can be done there: caving in Binacayan Cave and Bat Cave, mountain biking, swimming by Wawa Dam, and rock climbing in the limestone cliffs in Mt. Binacayan. In addition, the place has been recognized as a hiking spot with at least two of its small rocky mountains � Mt. Pamitinan and Mt. Binacayan, offering freshly new trails with close proximity to Metro Manila. Both mountains can be done as half-day hikes and can be combined as a nice twin dayhike adventure.\n\nThe mountain is shorter than Mt. Pamitinan by just few meters, different challenges will be faced when hiking with Binacayan, but similar views and other limestone formations, though Binacayan is more unexplored trail than Pamitinan.\n\n",
                    Itinerary = "Dayhike\n\n0500 Take van from Cubao to Eastwood, Rodriguez, Rizal\n0630 ETA Rodriguez, Rizal; take trike or jeep to brgy. Wawa\n0730 Arrival at Brgy. Wawa. Register at barangay hall/ tourism office\n0800 Start trek up Mt. Pamitinan\n1100 ETA summit / Lunch\n1200 Start descent\n1430 Back at Brgy. Wawa. Explore the area / Sidetrips\n1700 Tidy up then take outbound trike\n1930 Back in Manila",
                    Practicalities = "Transportation\nPublic (1) Van, Cubao to Montalban (Eastwood) (P50, 1-1.5 hrs) (2) Then take tricycle or jeepney to Wawa (P7.50-P10 30 mins)\nPrivate (1) Head out to Rodriguez, Rizal via Marikina and San Mateo, then follow the road ro Wawa Dam, There is an entrance of P50 for private vehicles. Parking slots are available in front of the tourism office\n\nRegistration\nLogbook at the Barangay hall\nP2 registration fee\n\nGuides\nAvailable; assigned at the tourism office\nP400 per day (add more for twin dayhikes)\n\nContact Numbers\nEmman (guide) - 09493956589\nOgie (guide) - 09473868778\nRichard Salina (guide) - 09983266559\nJoni � (barangay) - 09295497211\n\nCampsites\nNone, not prohibited\n\nWater sources\nNone\n\nCell phone signal\nPresent all throughout the hike\n\nRiver crossing\nNone, Wawa River already has hanging bridges in place\n\nRope Segments\nNone\n\nSidetrips\nCaves: Bat Cave and Binacayan Cave (P55 fee for the cave including headlamp rental)\nRock climbing in Mt. Pamitinan\nSwimming by Wawa Dam\n\nAlternate trails\nPossible traverse from Mt. Binacayan:\nMt. Pamitinan and Mt. Hapunang Banoi\n\nDayhikable\nYes (2-3 hrs up, 1.5-2 hrs down)\n\nFacilities at jump-off\nSari-sari stores\nCarinderias\nWash up area\nCottages by Wawa Dam\n\nEstimated budget\n500-700\n\n",
  Attire = "Dri-fir or Shirt\nTrekking pants or Short\nHiking shoes or Sandals\nCap or bush hat\ngloves",
       Ttb = "Dayhike\n\nBackpack 28L capacity\nHiking shoes or sandals\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nPacked lunch\nTrail food\nMess kit (Spoon & fork)\nMulti-tool (swiss knife)\nMap or Compass\nWater or energy drink\ngloves (optional) \n\nOvernight\n\nBackpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"

},

                new Mountain()
                {
                    MtName = "CANDALAGA",
                    Masl = 2402,
                    Difficulty = 8,
                    Island = 3,
                    MtImg00 = Resource.Drawable.candalaga,
                    MtImg01 = Resource.Drawable.candalaga1,
                    MtImg02 = Resource.Drawable.candalaga2,
                    MtImg03 = Resource.Drawable.candalaga3,
                    MtImg04 = Resource.Drawable.candalaga4,
                    Location = "MARAGUSAN, COMPOSTELA VALLEY",
                    JumpOff ="Marangig Falls, Brgy. New Albay, Maragusan",
                    Description ="LLA: 7�21�0 N, 126�4�38 E, 2402 MASL\nDays required: 3 days\nHours to summit: 12-14 hrs\nSpecs: Major climb, Difficulty: 8/9\nTrail class: 1-5\nFeatures: Mossy forest, river crossing, waterfalls\n\n",
                    Background ="Mt. Candalaga of Compostella Valley known as the home of the ethnic Mandayan and Mansaka tribes, the mountain is untamed and wild, as it is beautiful steeped in folklore and blessed with a forest with a tantalizingly deep and dense foliage. Numerous waterfalls deck the mountain, and even at the start of the trail you will be welcomed by Marangig Falls, which is actually a system of waterfalls in 13 levels. Also the mountain has many flora and fauna that hikers will find, there are rafflesia, orchids, ferns, and trees covered with moss.\n\nThe trek is difficult and challenging at the same time it is very exciting. To begin with, rope works will greet you at the very start at Marangig Falls. 90% of the trail going to Camp 1 will be river trekking and rope course, and this will consume the entire Day 1, the trekking time requiring over 8 hours. The next day is the jungle trekking from Camp 1 to Camp 2, lasting for four hours. Then after setting up camp at Camp 2, the summit is just an hour away. The summit does not afford any views, but in itself it is very nice, completely enmeshed in moss from the ground to the trees. The rest of the day is spent going back to Camp 2 and staying there for the night.\n\nDay 3 is a day-long descent to Tagbibinta Falls, another attraction of the mountain. Here you can take your much-deserved relaxation, for the Candalaga climb is said to be really difficult and will consume three full days\n\n",
                    Itinerary = "Day 0\n\n1200 Departure from Tagum City\n1500 Arrival in Maragusan\n1530 Registration at Tourism Office\n1600 Market time for trail food, supplies\n1800 Lights out\n\nDay 1\n\n0530 Wakeup call\n0600 Head to Marangig Falls jump-off, Meet guides\n0700 Start trek\n1200 Lunch on trail\n1330 Resume trek\n1700 ETA Camp 1, set up camp\n1800 Dinner, socials\n\nDay 2\n\n0500 Wakeup call, Prepare breakfast\n0600 Breakfast, Break camp\n0800 Start trek to Camp 2\n1200 ETA Camp 2, set up camp, lunch\n1330 Begin assault to summit\n1430 ETA summit (2402 MASL)\n1600 Head back to Camp 2\n1700 Back at Camp 2; prepare dinner\n1800 Dinner, socials\n\nDay 3\n\n0500 Wakeup call, Prepare breakfast\n0600 Breakfast, Break camp\n0700 Start descent\n1200 Lunch on trail\n1300 Resume trek\n1600 Arrival at Tagbibinta Falls. Unwind, Bathe at falls\n1730 Back at jumpoff; head back to Maragusan proper\n\nDay 4\n\nReturn to Tagum City then Davao City for Manila",
                    Practicalities = "Transportation\nPublic (1) Bus, Davao City SM City Terminal to Tagum City (2) then take a bus to Maragusan (P100) (3) take habal-habal at tourism office (P25)\n\nRegistration\nMarasugan Tourism Office P110 per pax\n\nGuides\nAvailable: 1:5 P180 per day\nPorters: similar rates\n\nContact Numbers\nJonald Buyoc of Maragusan Tourism Office\n\nCampsites\n(1) Camp 1\n(2) Camp 2\n\nWater sources\nNo reliable water sources beyong Camp 1\n\nCell phone signal\nPresent when Camp 2 is reached and at the summit\n\nRiver crossing\nNone\n\nRope Segments\nNone\n\nSidetrips\nMarangig Falls that has 13 levels\n\nAlternate trails\nNone\n\nDayhikable\nNo\n\nFacilities at jump-off\nSari-sari store\nWash up area\n\nEstimated budget\n1500-2000\n\n",
    Attire = "Jacket, Windbreaker or Shirt\nTrekking Pants\nHiking Shoes\nCap or bush hat",
Ttb = "Backpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"

                },

                new Mountain()
                {
                    MtName = "CRISTOBAL",
                    Masl = 1470,
                    Difficulty = 4,
                    Island = 1,
                    MtImg00 = Resource.Drawable.cristobal,
                    MtImg01 = Resource.Drawable.cristobal1,
                    MtImg02 = Resource.Drawable.cristobal2,
                    MtImg03 = Resource.Drawable.cristobal3,
                    MtImg04 = Resource.Drawable.cristobal4,
                    MtImg05 = Resource.Drawable.cristobal5,
                    Location = "DOLORES, QUEZON; SAN PABLO AND NAGCARLAN, LAGUNA",
                    JumpOff ="Brgy. Sta. Lucia, Dolores, Quezon",
                    Description ="LLA: 121.428� N, 121.428� E, 1470 MASL\nDays required: 1-2 day\nHours to summit: 4-5 hrs\nSpecs: Minor climb, Difficulty: 4/9\nTrail class: 1-3\nFeatures: Mossy forest, views of the 7 lakes of Laguna\n\n",
                    Background ="Mt. Cristobal often called as the \"Devil�s Mountain\" because of the stories and legends surrounds the mountain. The summit looks like a �W� shape that when the sun sets, it creates a shadow of like a devils horn. Mt. Banahaw which is beside the mountain is called \"Holy Mountain\" that�s why the 2 mountains possesses the good and evil energies that cancel out. Furthermore, there are tales of voices or apparitions, such as the creature called �Tumao�, waylaying mountain climbers; many hiking groups have their own \"ghost stories\" to tell. Even locals believe these stories; some guides say they have amulets to counteract the negative energy.\n\nThese legends notwithstanding, there is no reason to be afraid of Mt. Cristobal. Its forests are pristine, with a splendid array of flora that include giant pakpaklawin, varicolored flowering plants, rattan, etc. Two types of civet cats, the musang and the animus, roam freely in the forests. There are also reptile species, including those locally known as the bubuli and the balikakas.\n\n",
                    Itinerary = "Dolores (Sta. Lucia) Trail\n\n0700 ETA San Pablo City (bus, P120), Rent jeep to Brgy. Kinabuhayan\n0800 Jump-off at Brgy. Kinabuhaya, start trek\n0840 ETA Montelibano house\n1100 Descend to crater\n1130 ETA Crater\n1200 Jone's Peal (highest point) summit vewing\n1230 Start descent\n1530 Back at jump-off\n1600 Head back to San Pablo\n1700 ETA San Pablo\n2000 ETA Manila\n",
                    Practicalities = "Transportation\nPublic (1) Lucena-bound buses, to San Pablo, Laguna (2) rented jeep to the proposed trail\n\nRegistration\nP200-P300 per day\n\nGuides\nAvailable for arrangements\n\nContact Numbers\nFor now the mountain is closed\nClimb arrangements - 09152409138\n\nCampsites\n(1) Bulwagan Saddle Camp\n\nWater sources\nNone\n\nCell phone signal\nPresent in some parts of the trail\n\nRiver crossing\nNone\n\nRope Segments\nNone\n\nSidetrips\nLaguna hotsprings or Quezon beaches\n\nAlternate trails\nTraverse trail to Nagcarlan side\nTraverse to Rizal, Quezon\n\nDayhikable\nYes (4 hrs up, 3 hrs down)\n\nFacilities at jump-off\nNone\n\nEstimated budget\n800-1200\n\n",
 Attire = "Dri-fir or Shirt\nTrekking pants or Short\nHiking shoes or Sandals\nCap or bush hat\ngloves",
  Ttb = "Dayhike\n\nBackpack 28L capacity\nHiking shoes or sandals\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nPacked lunch\nTrail food\nMess kit (Spoon & fork)\nMulti-tool (swiss knife)\nMap or Compass\nWater or energy drink\ngloves (optional) \n\nOvernight\n\nBackpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"

                },

                new Mountain()
                {
                    MtName = "DULANG-DULANG",
                    Masl = 2938,
                    Difficulty = 6,
                    Island = 3,
                    MtImg00 = Resource.Drawable.dulang,
                    MtImg01 = Resource.Drawable.dulang1,
                    MtImg02 = Resource.Drawable.dulang2,
                    MtImg03 = Resource.Drawable.dulang3,
                    MtImg04 = Resource.Drawable.dulang4,
                    MtImg05 = Resource.Drawable.dulang5,
                    Location = "LANTAPAN, BUKIDNON",
                    JumpOff ="Sitio Bol-ogan, Brgy. Songco, Lantapan",
                    Description ="LLA: 8.09798� N, 124.9605� E 2938 MASL\nDays required: 2 days\nHours to summit: 10 hrs\nSpecs: Major climb, Difficulty: 6/9\nTrail class: 2-4 with roped segments\nFeatures: Mossy forest\n\n",
                    Background ="The second-highest mountain in the Philippines is Mt. Dulang-dulang. Also possesses one of the most impressive forests in the country. The long trek to the peak boasts of a variety of landscapes, starting from the wide trails with pine trees and grassland and progressing into denser and denser jungles. The jungle will reach a point that virtually everything is covered with moss and clouds. The trees are like bonsai, with spiraling, convoluted branches and lichen and white moss that give an �ancient� feel to the forest. The temperature goes down even in daytime, and when you emerge from this jungle to the clearing at the peak, you can behold the whole of the Kitanglad range and even catch a glimpse of majestic Mt. Apo.\n\nDulang-Dulang, like Pulag and Apo, is sacred to the locals. The Talaandig tribe of Lantapan have been accorded rights to the mountains as their \"ancestral domains\". Hence it is a must to secure their blessing to climb Mt. Dulang-Dulang. It is said that they limit the climbers to groups of 20, although this demand is somewhat negotiable. Nevertheless, a ritual sacrifice of chickens is done before every climb by the datu, and climbers perform the ritual of hanging bands of white cloth at the summit, as respect to the native culture. These traditions add to the mysticism of Mt. Dulang-Dulang.\n\n",
                    Itinerary = "Day 1\n\n1100 From CDO�s Agora terminal, take bus to Malaybalay\n1500 ETA Malaybalay market, meet with the group\n1530 Take jeep to Lantapan\n1730 ETA Lantapan. Courtesy call with datu\n1800 Prepare for next day�s climb, dinner\n1900 Attend ritual sacrifice by the Talaandig tribesfolk\n2100 Lights out\n\nDay 2\n\n0530 Start trek\n1130 Lunch at water source (near river)\n1600 ETA Plaza\n1630 ETA Manny�s Garden (campsite near summit), Set up camp\n1700 Visit the summit (just 5 minutes away)\n\nDay 3\n\n0545 Wake up to watch the sunrise at the summit, Spot Mt. Apo\n0630 Breakfast\n0800 Break camp\n0830 Start descent\n1200 Back at water source\n1600 Back at jump-off point, take jeepney back to Malaybalay\n1730 Take jeep or bus back to CDO",
                    Practicalities = "Transportation\nPublic (1) Plane via Manila to CDO (2) take bus to Malaybalay, Bukidnon (3) arranged jeepney to Lantapan\n\nRegistration\nP170 per pax\n\nGuides\nAvailable P2500 for whole 4 days\nPorter fee P500 per day\n\nContact Numbers\nAsk help from (Northern Mindanao Mountaineering Society) to arrange hike\nSir Oyec � 09063492585\nOr (Bukidnon Mountaineering Society)\nSir Bogart � 09058352999\n\nCampsites\n(1) Summit Camp\n\nWater sources\nRiver at the starting point\n\nCell phone signal\nPresent in some parts of the trail\n\nRiver crossing\nNone\n\nRope Segments\nNone\n\nSidetrips\nNearby mountains: Mt. Kitanglad\n\nAlternate trails\nNone\n\nDayhikable\nNo\n\nFacilities at jump-off\nSari-sari store\nWash up area\n\nEstimated budget\n2000-2500\n\n",
                Attire = "Jacket, Windbreaker or Shirt\nTrekking Pants\nHiking Shoes\nCap or bush hat",
   Ttb = "Dayhike\n\nBackpack 28L capacity\nHiking shoes or sandals\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nPacked lunch\nTrail food\nMess kit (Spoon & fork)\nMulti-tool (swiss knife)\nMap or Compass\nWater or energy drink\ngloves (optional) \n\nOvernight\n\nBackpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"
    },

                new Mountain()
                {
                    MtName = "GUITING-GUITING",
                    Masl = 2058,
                    Difficulty = 9,
                    Island = 2,
                    MtImg00 = Resource.Drawable.guiting,
                    MtImg01 = Resource.Drawable.guiting1,
                    MtImg02 = Resource.Drawable.guiting2,
                    MtImg03 = Resource.Drawable.guiting3,
                    MtImg04 = Resource.Drawable.guiting4,
                    MtImg05 = Resource.Drawable.guiting5,
                    Location = "SIBUYAN ISLAND, ROMBLON",
                    JumpOff ="Brgy. Tampayan, Magdiwang, Sibuyan",
                    Description ="LLA: 12�24'50 N, 122�32'4'4 E, 2058 MASL\nDays required: 3 days\nHours to summit: 10-13 hrs\nSpecs: Major climb, Difficulty: 9/9\nTrail class: 5 with rock climbing/ scrambling\nFeatures: Rock formations, knife edge\n\n",
                    Background ="Mt. Guiting-Guiting, one of the most difficult climbs located in Sibuyan Island, Romblon. The mountain is rated Difficulty: 9/9 because of the steep and jagged ridges of the mountain called \"Knife Edge\" which hikers must cross in order to reach the summit, not to mention the ensuing rock formations with colorful names such as \"Kiss the Wall\". On top of this challenging trail, the weather is so volatile that hikers would use absolute cut-off times to reach the summit, otherwise they would have to turn back. By implication, only hikers with enough stamina are advised to attempt to hike this mountain.\n\nIn May 1982, a combined team of the Philippine Mountaineering Society (PMS) of Bacolod City and UP Mountaineers did the first exploration of the mountain, reaching the then-unnamed Mayo�s Peak but failing to reach the summit. A few weeks later, some of them returned to make the first ascent to Mt. Guiting-Guiting summit.\n\nEven without the accomplishment of getting to the summit of Mt. Guiting-Guiting, a visit to the Sibuyan Island is already amazing and rewarding enough. To begin with, Sibuyan Island is a jewel of the seas. 187 nautical miles from Manila, the 445-sq.km island has beaches, waterfalls, and one of the cleanest rivers in the Philippines. The mountain has been called the most diverse forest in the world being the habitat of up to 54 endemic plant varieties, and home to fascinating endemic flora and fauna. These include four species of rodents and a kind of bat discovered only in the mid-1990s and found nowhere else in the world.\n\nThe climb takes three days to finish, Day 1 is the hike up to Mayo�s Peak (1550 MASL). Three streams will be crossed before reaching Camp 1, and three camps will be passed (Camp 1-3) before reaching Mayo�s Peak. The trails are surrounded by woodlands throughout the hike. Normally, Day 2 is the 4-5 hr ascend to the summit and including back. A fast descent from Mayo�s Peak will lead to the \"Knife Edge\" � here the entire trail is rocky and exposed to the sun and winds; there are ravines on both sides and the view is both breathtaking and scary. After 3-4 hrs, the Peak of Deception, an imposing sight, will be reached. They say this peak was also called \"Peak of Decision\" because from here you will have to decide whether to proceed or not, considering the time and one�s energy, and from here, it�s only 30-45 minutes away from the summit itself. The trails here are unforgiving. After passing this trail, hikers can now reach the summit. At the summit, when it is clear, you can see the neighboring peaks of the Guiting-Guiting range, as well as the seas surrounding Sibuyan Island.\n\n	The third and final day is the descent back to Magdiwang. As you leave Sibuyan Island by ferry, the towering presence of Guiting-Guiting and its saw-toothed peaks will remind you of the unforgettable adventure.\n\n",
                    Itinerary = "Day 0\n\n0800 Assembly at Greenstar Liner (Buendia)\n0830 ETD Buendia to Batangas port\n1200 ETA Batangas port secure tickets to Ambulong Port (Magdiwang)\n1700 Take ferry to Magdiwang Port\n\nDay 1\n\n0800 Arrival at Magdiwang (Ambulong Port)\n0815 Proceed to Tourism Council for registration\n0900 Breakfast (magdiwang market)\n1000 Buy supplies\n1100 head to Tansiungco Residence or Sanctuary Lodge\n1200 preparation for the climb (precooking etc)\n2100 lights out\n\nDay 2\n\n0600 Wakeup call (Breakfast)\n	0730 Start trek. Brace for exposed area\n1030 ETA Camp 1\n1200 ETA Camp 2 (lunch)\n1400 ETA Camp 3\n1430 ETA Bulod�s spring (Load up last watersource)\n1500 Arrival at Mayo�s Peak (1550 MASL). Rest.\n1700 Sunset Viewing @ Mayo�s Peak\n1900 Dinner\n2000 Lights out\n\nDay 3\n\n0500 Breakfast / prepare packed lunch\n0600 Commence summit assault\n0630 Begin crossing the �Knife Edge�\n0800 Arrival at \"Kiss the Wall\"\n0930 Arrival at Mabel Spring (water not always available)\n1015 ETA Peak of Deception (1959 MASL)\n1100 ETA G2 summit (2057 MASL)\n1200 Head back\n1600 Back at Mayo�s Peak\n1800 Dinner / socials\n\nDay 4\n\n0700 Breakfast\n0800 Break camp\n0900 Start descent\n1400 Back to jump-off\n\nDay 5\n\nHead back to Batangas port",
                    Practicalities = "Transportation\nPublic (1) Bus, Buendia to Batangas Port (2) any of the following Ferry lines (MBRS Lines, Super Ferry, and Montenegro Lines)\n\nRegistration\nLogbook at Mt. Guiting-Guiting National Park P300 per person � includes climb certificate and tagalog-language booklet\n\nGuides\nP800 per day for Filipinos, P1000 per day for foreigners\nPorters: P600 per day\n\nContact Numbers\nMt. Guiting-Guiting National Park - 09284901038\n\nCampsites\n(1) Camp 1(2) Camp 2(3) Camp 3These camps can be reached before ascending to Mayo�s Peak\n\nWater sources\nThe rivers before Camp 1, very clean and you can take a refreshing dip\n\nCell phone signal\nPresent in the Park Center but sporadic even in the high elevations\n\nRope Segments\n	None\n\nSidetrips\nSibuyan Island beaches\n\nAlternate trails\nNone\n\nDayhikable\nNo\n\nFacilities at jump-off\nGuest houses with restrooms and shower P500 per room\n\nEstimated budget\n5000-6000\n\n",
        Attire = "Jacket, Windbreaker or Shirt\nTrekking Pants\nHiking Shoes\nCap or bush hat",
    Ttb = "Backpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"
        },

                new Mountain()
                {
                    MtName = "HALCON",
                    Masl = 2582,
                    Difficulty = 9,
                    Island = 2,
                    MtImg00 = Resource.Drawable.halcon,
                    MtImg01 = Resource.Drawable.halcon1,
                    MtImg02 = Resource.Drawable.halcon2,
                    MtImg03 = Resource.Drawable.halcon3,
                    MtImg04 = Resource.Drawable.halcon4,
                    MtImg05 = Resource.Drawable.halcon5,
                    Location = "BACO, ORIENTAL MINDORO",
                    JumpOff ="Brgy. Lantuyan, Baco",
                    Description ="LLA: 13�15.749 N 120�59.703 E, 2582 MASL\nDays required: 3.5-4 days\nHours to summit: 15-18 hrs\nSpecs: Major climb, Difficulty: 9/9\nTrail class: 2-4\nFeatures: River crossings, Mossy forest, rocky ridges\n\n",
                    Background ="Mt. Halcon, home of many endemic flora and fauna in the Philippines located in Baco, Oriental Mindoro. The mountain is 2582 MASL in Mindoro Island just south of Luzon. Mt. Halcon is one of the majestic mountains and also the best hiking destination in the Philippines, featuring long and often steep through dense jungle and crystal clear waters from its rivers.\n\nBefore attempting to hike Mt. Halcon, Group hikes are required to be safe and must be oriented or experienced mountaineers. First hikers must secure a permit that they are allowed to hike in the mountain and sending an advance party to get permits on a weekday is like a prudent option rather than going directly to the place. If going there directly, best arrive on weekdays and allow on extra day for contingencies.\n\nDuring rainy season, climbing may have to be aborted when flash floods sets in making the trail crossing rivers unpassable.  Another factor that adds up to the difficulty of climbing is the presence of the \"limatik\" on almost 90% of the trail. These small leeches silently clings to your body and makes their way to any exposed skin where they begin sucking your blood. Nature will always be a factor in the success of this climb.\n\n",
                    Itinerary = "3 Days Lantuyan or Bayanan trail (Summit Assault)\n\nDay 0\n\n0600 Assembly at Buendia corner Taft\n0630 ETD Manila to Batangas City\n0930 ETA Batangas Pier, take ferry to Calapan\n1015 ETA Calapan Pier, Hire tricycle to Calapan Market Place\n1030 ETA Calapan Market Place, Ride jeepney bound for Baco\n1130 ETA Baco Municipal Hall, Arrange for permit\n1200 Lunch in Baco/ Buy final supplies\n1400 ETD Baco Municipal Hall to jump-off\n1500 ETA jump-off. Register/ Arrange for guides\n1600 Free Time, Setup Camp, Make Final Preparation\n\nDay 1 (exact landmarks vary depending on choice of trail)\n\n0600 Breakfast / Prepare for the hike\n0700 Start Trek\n1200 Lunch along the jump-off\n1300 Resume Trek\n1700 ETA Aplaya campsite\n1830 Dinner / Prepare for packed lunch the next day\n2000 Light�s Out\n\nDay 2\n\n0300 Wake-up call/ Light snacks\n0400 Start summit assault\n0700 Breakfast/ 15-minute break at Camp 1 or 2\n1000 Arrival at ridgeline\n1100 ETA summit (allow up to 1300H)/ Lunch\n1200 Start descent\n1500 Dulungan River break / swimming\n1800 Back at Aplaya campsite\n1900 Dinner / socials\n\nDay 3 (exact landmarks vary depending on choice of trail)\n\n0600 Breakfast / Break camp\n0800 Start descent\n1200 Lunch along the trail\n1600 Back at the jump-off. End of trek!\n1700 Take tricycle back to Baco then jeep back to Calapan\n1900 ETA Calapan. Dinner\n2100 Take ferry back to Batangas\n2300 ETA Batangas. Take bus back to Manila\n0130 (+1 day) ETA Manila",
                    Practicalities = "Transportation\nPublic (1) Bus, Cubao or LRT-Buendia to Batangas Pier (P170, 2.5-3 hrs) (2) Ferry, Batangas Pier to Calapan, Oriental Mindoro (P180-300, 2-2.5 hrs) (3) Rented jeepney, Calapan to Baco Municipality and back (P2500-3000 for round trip, 40 minutes to Baco and 30 mins to the trailhead) Approximately 6-7 hrs time because of various stops and delays\n\nRegistration\n(1) Logbook at the Tourism Office in Baco\n(2) Logbook at the Police Station in Baco\n3) Logbooks and possible minor fees at the jump-off/ villages\n\nGuides\nAvailable; required; Ratio of 1:7 P500 per day\nPorters: same rate as guides, maximum 15kg\n\nContact Numbers\nHalcon (Jojo � Baco Tourism Office) � 09198821442\n\nCampsites\n(1) Emergency campsites\n(2) Aplaya campsite\n(3) Camp 1\n(4) Camp 2\n(5) Summit camp\n\nWater sources\nAvailable in Aplaya camp, Camp 1 and Camp 2 and some parts of the trail\n\nCell phone signal\nSporadic in Aplaya camp\nAvailable at the summit and in some parts of the trail\n\nRope Segments\nNone but there are parts where ropes might help beginners\n\nSidetrips\nPuerto Galera (one jeepney ride from Calapan)\nOther Mindoro mountains eg. Mt. Malasimbo\n\nAlternate trails\nNone\n\nDayhikable\nNo\n\nFacilities at jump-off\nSari-sari stores\nWash up places\n\nEstimated budget\n1500-2200 per pax for group of 7 (3 days)\n\n",
            Attire = "Jacket, Windbreaker or Shirt\nTrekking Pants\nHiking Shoes\nCap or bush hat",
   Ttb = "Backpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"
     },

                new Mountain()
                {
                    MtName = "HAMIGUITAN",
                    Masl = 1620,
                    Difficulty = 6,
                    Island = 3,
                    MtImg00 = Resource.Drawable.hamiguitan,
                    MtImg01 = Resource.Drawable.hamiguitan1,
                    MtImg02 = Resource.Drawable.hamiguitan2,
                    MtImg03 = Resource.Drawable.hamiguitan3,
                    MtImg04 = Resource.Drawable.hamiguitan4,
                    Location = "DAVAO, ORIENTAL",
                    JumpOff ="Brgy. La Union, San Isidro, Davao Oriental",
                    Description ="LLA: 6.745 N, 126.174 E, 1620 MASL\nDays required: 3 days\nHours to summit: 11 hrs\nSpecs: Major climb, Difficulty: 6/9\nTrail class: 3 with river crossing\nFeatures: bonsai field, flora and fauna\n\n",
                    Background ="Mt. Hamiguitan, Davao Oriental�s captivating wonder, is home to the country�s largest pygmy forest. Its impressive flora counts a total of 878 species, whereas its distinguished fauna include the Philippine Eagle. The vast, 600-hectare bonsai field is enchanting, and even more so the mysterious \"Tinagong Dagat\" (Hidden Sea), a lake that is said to have high tide and low tide schedules.\n\nThe trek begins from Brgy. La Union in San Isidro, Davao Oriental. A whole-day trek to either Kapatagan Uno (first camp) or all the way to Kapatagan Dos (second campsite; near the summit) is typically done. The first two hours require river crossing, in a background of woodlands. Followed by the second day which is mostly for exploring the beautiful pygmy forest, the summit, and the mysterious �Tinagong Dagat�. Also, near the bonsai fields lie the narrow but high Twin Falls.\n\nBefore reaching Camp 3, a vantage point known as �Lantawan� will be encountered � affording spectacular views of the Hamiguitan range as well as the southern seas, including Pujada bay. Pitcher plants and large ferns dominate the scene, as well as dense mossy patches. On the third day, one may descend via the same route but there is the option of descending via Gov. Generoso town. Two other camps will be passed before reaching Sitio Badiang.\n\n",
                    Itinerary = "Day 1\n\n0300 At Davao�s Ecoland terminal, take van to Tibanban, San Isidro (P85)\n0700 ETA San Isidro; hire jeep going to Brgy. La union\n0800 Arrive at La Union, arrange for porters and guides, Register\n0900 Start trek\n0500 ETA first campsite, Set up camp\n0600 Dinner, socials\n\nDay 2\n\n0600 Breakfast, break camp\n0800 Resume ascent\n1000 Arrive at Lantawan 1\n1100 Arrive at Lantawan 2\n1200 Arrive at second campsite (Near summit, Bonsai Field) Set up camp\n1300 Explore the summit, bonsai field, and the �Tinagong Dagat�\n1700 Return to campsite\n1800 Dinner, socials\n\nDay 3\n\n0600 Breakfast, break camp\n0800 Start descent via traverse to Gov. Generoso\n1200 River crossing and trekking (difficult ascents, descents)\n1230 Lunch on trail\n1330 Start trekking going to Camp 1\n1530 Arrive at Camp 1\n1700 ETA Sitio Badiang\n1730 Return to Poblacion (Tibanban, San Isidro)\n1800 ETD for Davao City",
                    Practicalities = "Transportation\nPublic (1) Van, from Davao Ecoland Terminal to San Isidro (P85) (2) then jeep to Brgy. La Union\n\nRegistration\nP100 per pax\n\nGuides\nAvailable: 1:5 P150 to P200 per day\n\nContact Numbers\nMax (Local guide) � 09155702173\n\nCampsites\n(1) Camp 1\n(2) Camp 2\n\nWater sources\nWater sources are abundant with plenty of streams\n\nCell phone signal\nPresent all throughout the hike\n\nRiver crossing\nNone\n\nRope Segments\nNone\n\nSidetrips\nSouthern Mindanao Mountains: Mt. Candalaga, Mt. Apo\n\nAlternate trails\nNone\n\nDayhikable\nNo\n\nFacilities at jump-off\nSari-sari store\nWash up area\n\nEstimated budget\n1000-1500 from Davao\n\n",
             Attire = "Jacket, Windbreaker or Shirt\nTrekking Pants\nHiking Shoes\nCap or bush hat",
    Ttb = "Backpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"
   },

                new Mountain()
                {
                    MtName = "HIBOK-HIBOK",
                    Masl = 1332,
                    Difficulty = 4,
                    Island = 3,
                    MtImg00 = Resource.Drawable.hibok,
                    MtImg01 = Resource.Drawable.hibok1,
                    MtImg02 = Resource.Drawable.hibok2,
                    MtImg03 = Resource.Drawable.hibok3,
                    MtImg04 = Resource.Drawable.hibok4,
                    Location = "CAMIGUIN ISLAND",
                    JumpOff ="Ardent Hot Spring, Mambajao, Camiguin",
                    Description ="LLA: 9�12�2 N, 124�40�5 E, 1332 MASL\nDays required: 1 day\nHours to summit: 3-5 hrs\nSpecs: Minor climb, Difficulty: 4/9\nTrail class: 3\nFeatures: Volcanic crater, tropical forest, scenic views of Camiguin\n\n",
                    Background ="In the island of Camiguin in Northern Mindanao stands its most famous volcano, Mt. Hibok-Hibok.  Not many people know that Camiguin is a literally a hot plate with no less than seven volcanoes in the small island. Mt. Timpoong, at 1450 MASL is actually higher than Hibok-Hibok, but the latter has risen to fame because of its explosive history. Five eruptions have been recorded since the 1827. The latest, in the early 1950s, killed 600 people.\n\nToday, although Mt. Hibok-Hibok remains an active volcano, it has no signs of activity. In fact, the only signs of volcanism are the hot springs that count among Camiguin�s tourist destinations. One of them, Ardent Hot Springs, is actually the jump-off point for a Mt. Hibok-Hibok climb.\n\nMt. Hibok-Hibok is a challenging mountain for a dayhike. It takes 3-4 hours to reach the peak depending on the hikers pace. The altitude gain when ascent is quite fast and trees are too minimal. Yet the views are unique and spectacular.\n\n",
                    Itinerary = "Dayhike\n\n0500 Take ferry to Camiguin from Balingoan port\n0630 ETA Benoni; take FX to Mambajao (P50)\n0700 ETA Mambajao, Meet with guide, Drop by DENR office (P200)\n0800 Take motorcycle to Ardent Hot Springs (P30)\n0830 ETA Ardent; Start trek\n1200 ETA summit, Explore the area, Lunch\n1300 Start descent\n1530 Back at Ardent Hot Spring; take a dip at the spring (P50)\n1700 Take motorcycle back to your hotel or lodging place in Camiguin\n",
                    Practicalities ="Transportation\nPublic (1) Ferry, CDO, Balingaon port to Camiguin (2) tricycle to Brgy. Yumbing\n\nRegistration\nP200 will collect by the DENR office in Mambajao\n\nGuides\nP1500 per day (fixed)\n\nContact Numbers\nJackie (+639158123686 Globe; +639104963820 Smart)\n\nCampsites\nNone\n\nWater sources\nNone\n\nCell phone signal\nPresent in some parts of the trail\n\nRiver crossing\nNone\n\nRope Segments\nNone\n\nSidetrips\nCamiguin hot springs\n\nAlternate trails\nTraverse via Brgy. Yumbing\n\nDayhikable\nYes (3-5 hrs ascent; 1.5-2 hrs down)\n\nFacilities at jump-off\nSari-sari store\nDENR office\nWash up area\n\nEstimated budget\n1500-1800 from Davao\n\n",
           Attire = "Jacket, Windbreaker or Shirt\nTrekking Pants\nHiking Shoes\nCap or bush hat",
     Ttb = "Backpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"
    },

                new Mountain()
                {
                    MtName = "KALATUNGAN",
                    Masl = 2880,
                    Difficulty = 8,
                    Island = 3,
                    MtImg00 = Resource.Drawable.kalatungan,
                    MtImg01 = Resource.Drawable.kalatungan1,
                    MtImg02 = Resource.Drawable.kalatungan2,
                    MtImg03 = Resource.Drawable.kalatungan3,
                    MtImg04 = Resource.Drawable.kalatungan4,
                    Location = "TALAKAG, PANGATUCAN, BUKIDNON",
                    JumpOff ="Brgy. Miarayon, Talakag",
                    Description ="LLA: 7�57�18 N, 124�48�09 E, 2880 MASL\nDays required: 3-4 days\nHours to summit: 15 hrs\nSpecs: Major climb, Difficulty: 8/9\nTrail class: 3-4\nFeatures: Tribal domain, mossy forest\n\n",
                    Background ="One of the most difficult climbs in the country, Kalatungan Mountain Range has its own peak and perhaps even more challenging climbs in Bukidnon, complementing the grand Kitanglad Range to the southwest Mindanao. And finally, it is now regarded as the 5th highest mountain in the Philippines.\n\nThe first part of the trail is open and like that of Madjaas, would consume three hours of trekking. Then the forest line is breached, after which the long trek continues, taking 8 hours of hike to reach the summit campsite and involving a scenic \"summit ridge\" trail. Then, the traverse proceeds south to the town of, starting off with Mt. Makaupao, a component peak of the Kalatungan Range. It will take a dozen more hours to reach the town proper, and climbers (indeed, survivors) of the Kalatungan climb will tell you that the final leg of the trail is called \"Dead Nails� Trail\" and for good reason.\n\n",
                    Itinerary = "Mt. Kalatungan Traverse Maka-Upao (Wiji)\n\nDay 1\n\n1000 CDO Airport; ETD for Agora Terminal\n1030 ETA Agora Terminal\n1330 ETA Malaybalay, lunch\n1400 ETA DENR (registration, secure permits)\n1500 Buy foods at the Market\n1800 Dinner\n\nDay 2\n\n0600 ETD for Miarayon\n0900 ETA Miarayon (ride habal-habal going to Brgy)\n1000 ETA Brgy; look for Datu Reo Bisto; tribal socials\n1200 Lunch\n1300 Buy Tribal Ceremony materials\n1600 Tribal Ceremony\n1800 Dinner\n2100 Lights out\n\nDay 3\n0500 Wakeup call; prepare breakfast and packed lunch\n0600 start trek\n1000 forest line\n1200 lunch en route, water source in Camp 1 along the way\n1800 Kalatungan Summit\n2000 Dinner\n2200 Lights out\n\nDay 4\n\n0500 Wakeup call; Prepare breakfast and packed lunch\n0600 Start descent\n1100 Mt Makaupao (Wiji)\n1200 Lunch en route\n1700 Pangantucan camp; water source\n1800 Dinner\n2100 Lights out\n\nDay 5\n\n0500 Wakeup call; breakfast\n0600 Start trek\n0700 Dead nails trail\n1100 Town Proper; ride habal-habal to terminal\n1400 ETA Malaybalay; late lunch; get certificates from PASU\n1500 ETD for Agora station\n1800 ETA Agora station; dinner\n\nDay 6\n\n0900 ETD for CDO Airport",
                    Practicalities = "Transportation\nPublic (1) Bus, CDO, Agora Terminal to Malaybalay-bound (2) take bus or jeep to Kibanggay (P60) (3) then take habal-habal to the jump-off\n\nRegistration\nP300 per pax\n\nGuides\nAvailable 1:8 P350 per day\nPorter fee P400 per day\n\nContact Numbers\nMr. Vergilino Alima (Kalatungan Range Natural Park) � 09282523558\nSir Jayson (Pangantucan Tourism) - 0906 370 0421\n\nCampsites\n(1) Summit camp\n(2) Pangantucan Camp\n\nWater sources\nThere is a water source in the starting point but needs to be filtered\n\nCell phone signal\nMinimal Cellphone coverage in the area\n\nRiver crossing\nNone\n\nRope Segments\nNone\n\nSidetrips\nSamal island\n\nAlternate trails\nNone\n\nDayhikable\nNo\n\nFacilities at jump-off\nSari-sari stores\nWash up area\n\nEstimated budget\n2500-3000\n\n",
              Attire = "Jacket, Windbreaker or Shirt\nTrekking Pants\nHiking Shoes\nCap or bush hat",
  Ttb = "Backpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"
    },

                new Mountain()
                {
                    MtName = "KANLAON",
                    Masl = 2435,
                    Difficulty = 8,
                    Island = 1,
                    MtImg00 = Resource.Drawable.kanlaon,
                    MtImg01 = Resource.Drawable.kanlaon1,
                    MtImg02 = Resource.Drawable.kanlaon2,
                    MtImg03 = Resource.Drawable.kanlaon3,
                    MtImg04 = Resource.Drawable.kanlaon4,
                    MtImg05 = Resource.Drawable.kanlaon5,
                    Location = "NEGROS OCCIDENTAL",
                    JumpOff ="Brgy. Mambucal, Murcia Negros Occidental",
                    Description ="LLA: 10�24�44 N, 123�7�55 E, 2435 MASL\nDays required: 3-4 days\nHours to summit: 15-16 hrs\nSpecs: Major climb, Difficulty: 8/9\nTrail class: 4\nFeatures: Forest, rolling slopes, volcanic crater\n\n",
                    Background ="Mt. Kanlaon, the country�s largest active volcano and Visayas� highest mountain in Negros Island. As the country�s largest active volcano, it is fearsome. The majestic beautiful scenery of the mountain lies in its forests, waterfalls, lagoons, and culminates in its crater. However, this seat of majesty is also the source of Mt. Kanlaon�s volcanic wrath. It is, after all, one of the most active volcanoes in the Philippines.\nEconomically, the highland domain of Kanlaon is the source of vegetables and fruits in the same way that Benguet is the �Salad Bowl� of Luzon. It provides a home for a lot of communities, who earn their livelihood from the forest products. Ecologically, Kanlaon is another biodiversity haven, home to about 197 species of flora and an impressive roster of fauna, such as the endangered Philippine spotted deer and the Visayan Warty Pig.\nThe geologic importance of Kanlaon attracts foreign tourists who want to see the country�s third most active volcano (next to Mayon and Taal) in its volcanic glory. But also because of this danger, close coordination with DENR is a must when climbing the mountain.\n\n",
                    Itinerary ="Day 0\n\nTravel from Manila to Bacolod City. After buying supplies at the malls/groceries;Proceed to Mambucal Resort via jeep or minibus (P35) where one can take dip at the hot, sulfuric Springs or explore the waterfalls.\n\nDay 1\n\n0500 Breakfast\n0600 Start trek\n1000 ETA river area. Water source\n1100 Lunch at Giant tree\n1500 Arrival at Hardin Sang Balo (Old NPA camp), Set up camp\n1730 Dinner / socials\n\nDay 2\n\n0600 Breakfast\n0700 Break camp and resume trek\n0900 Pass by lagoons \n1200 Arrival at Margaha Valley outer rim. Snacks/ Light lunch\n1300 Negotiate trek at outer rim, continue to campsite\n1500 Arrival at campsite, Explore summit area\n1730 Back at camp; Dinner preparation\n1800 Dinner / socials\n\nDay 3\n\n0600 Breakfast\n0700 Descend via Guintubdan trail\n1000 ETA Rancho Dos; water source\n1200 Arrival at Guintudban. Tidy up and have lunch\n1400 Take last trip to La Carlota City en route to Bacolod\n1700 ETA Bacolod City",
                    Practicalities = "Transportation\nPublic (1) Manila to Bacolod via Airfare (2) take jeepney or Mini Bus to Mambucal resort (P35)\n\nRegistration\nPark fees P320 per pax, (P220 if student)\n\nGuides\nAvailable P500 per day exclusive of food and tent you have to provide\n\nContact Numbers\nAngelo Bibar (Park Superintendent of Mt. Kanlaon National Park (MKNP) � 09173011410\n\nCampsites\nSummit campsite near the crater\n\nWater sources\nThe river before reaching the Giant tree\n\nCell phone signal\nSmart network is the strongest signals, the rest sporadic\n\nRope Segments\nNone\n\nSidetrips\nMambucal Resort\nTwin falls of Guintubdan\nNearby mountains Mts Silay and Mandalagan, and Mt. Talinis, also known as Mt. Cuernos de Negros\n\nAlternate trails\nNearby Mountain Trails\n\nDayhikable\nNo\n\nFacilities at jump-off\nMambucal Resot\n\nEstimated budget\n2000-2500\n\n",
               Attire = "Jacket, Windbreaker or Shirt\nTrekking Pants\nHiking Shoes\nCap or bush hat",
   Ttb = "Backpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"
  },

                new Mountain()
                {
                    MtName = "KITANGLAD",
                    Masl = 2899,
                    Difficulty = 6,
                    Island = 3,
                    MtImg00 = Resource.Drawable.kitanglad,
                    MtImg01 = Resource.Drawable.kitanglad1,
                    MtImg02 = Resource.Drawable.kitanglad2,
                    MtImg03 = Resource.Drawable.kitanglad3,
                    MtImg04 = Resource.Drawable.kitanglad4,
                    MtImg05 = Resource.Drawable.kitanglad5,
                    Location = "IMPASUG-ONG, BUKIDNON",
                    JumpOff ="Sitio Intavas, La Fortuna, Impasugong",
                    Description ="LLA: 8�8�2 N, 124�47�0 E, 2899 MASL\nDays required: 2 days\nHours to summit: 5-6 hrs\nSpecs: Major climb, Difficulty: 6/9\nTrail class: 2-4\nFeatures: Mossy forest\n\n",
                    Background ="Mt. Kitanglad, the fourth highest mountain in the Philippines situated in Impasug-ong, Bukidnon. Amazingly, there are bunkhouses with electricity at the summit, for it is a communications center. Since people actually work at the summit, the trails going up are well-established. Still, the trails are challenging, the views beautiful, and experience unique. There are steel stairs that will assist you in ascending the very steel trails, and at the top, so many mountains and places in Northern and Central Mindanao are visible. The Kitanglad mountain range is very rich in biodiversity, and the forests are refreshing.\n\nAccording to a DENR newsletter, the name Kitanglad came from a legend: a great flood submerged the native lands and only the tip of the mountain, the size of tanglad (lemon grass), remained visible (kita in Tagalog). Today, it is the domain of several old cultural communities like the Bukidnon, Higaonon and Talaandig.\n\n",
                    Itinerary = "Intavas Trail\n\nDay 1\n0400 Depart from CDO to Impasug-ong\n0800 ETA jump-off at Sitio Intavas, Register and start trek\n1200 ETA \"Aerial Roots\" area, lunch along the trail\n0330 ETA summit\n1800 Prepare for next day�s climb, dinner\n1900 Attend ritual sacrifice by the Talaandig tribes folk\n2100 Lights out\n\nDay 2\n\n0600 Mountain-viewing session: Mt. Ragang, Mt. Balatucan, Dulang-dulang\n0700 Breakfast, break camp\n0800 Start descent via Intavas trail, Muddy and steep\n1100 Reach �Aerial roots�: roots suspended in air\n1300 ETA rough road\n1400 ETA jump-off point at Sitio Intavas\n1500 Take jeepney back to Malaybalay or CDO\n1800 ETA CDO",
                    Practicalities = "Transportation\nPublic (1) From Manila, take a plane to Laguindingan Airport in Misamis Oriental (2) bus, Agora bus terminal to Bukidnon (P145 2.5-3 hrs) (3) ride multi-cab from Malaybalay to DENR station (P7)\n\nRegistration\nP170 Climbing permits at the DENR office\nP85 per mountain\n\nGuides\nAvailable 1:2 P1000 per day\n\nContact Numbers\nDENR � Mount Kitanglad Range Natural Park at (088) 813 3453\nBen Maputi(guide)- 09365004147 \n\nCampsites\n(1) Summit Campsite\n\nWater sources\nNone\n\nCell phone signal\nPresent at the summit and throughout the trail\n\nRiver crossing\nNone\n\nRope Segments\nNone, but there are steel stairs\n\nSidetrips\nOther Bukidnon Mountains: Mt. Dulang-Dulang\n\nAlternate trails\nTraverse to Mt. Dulang-Dulang\n\nDayhikable\nYes\n\nFacilities at jump-off\nSari-sari stores\nDENR office\n\nEstimated budget\n900-1000 from CDO\n\n",
                 Attire = "Jacket, Windbreaker or Shirt\nTrekking Pants\nHiking Shoes\nCap or bush hat",
 Ttb = "Backpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"
  },

                new Mountain()
                {
                    MtName = "LUBOG",
                    Masl = 955,
                    Difficulty = 4,
                    Island = 1,
                    MtImg00 = Resource.Drawable.lubog,
                    MtImg01 = Resource.Drawable.lubog1,
                    MtImg02 = Resource.Drawable.lubog2,
                    MtImg03 = Resource.Drawable.lubog3,
                    MtImg04 = Resource.Drawable.lubog4,
                    MtImg05 = Resource.Drawable.lubog5,
                    Location = "RODRIGUEZ, RIZAL",
                    JumpOff ="Sitio Lubog, Brgy. Puray, Rogriguez",
                    Description ="LLA: 14�50�10.4 N, 121�14�12.9 E, 955 MASL\nDays required: 1 day\nHours to summit: 1.5 hrs\nSpecs: Minor climb, Difficulty: 4/9\nTrail class: 1-4 with rock scrambling\nFeatures: Limestone formation, scenic views of Sierra Madre\n\n",
                    Background ="Mt. Lubog is part of the Sierra Madre mountain ranges of Rizal. The mountain offers a forested hike that culminates in limestone-decked summit and also offers a spectacular view of the surrounding. Mt. Lubog is in the town of Rodriguez that will require hikers to ride a habal-habal in 2 hrs before reaching the jump-off point. The rough road that leads to the jump-off point is also the same road that illegal loggers use to transport logs.\n\nThe trail from the jump-off is straightforward, hikers would very soon enter a tropical rainforest, strewn with lime stones that foreshadow the rocky peak. Two flat areas with wooden benches that is made by the locals for comfortable rest stops of the hikers, and the first one offers a fifteen-minute sidetrip to Lubog Cave. From the second one, the summit is no more than a 10-minute ascent.\n\nAt 955 MASL, the summit is a wonderful haven of rocks, where hikers can feel themselves perched in one getaways to the Sierra Madre. Also, hikers can enjoy a quick dip into Panintingan Falls 45 minutes from the jump-off area.\n\n",
                    Itinerary = "Dayhike\n\n0400 ETD Cubao for Brgy. San Rafael, Rodriguez\n0500 ETA Brgy. San Rafael\n0600 Take habal-habal to Brgy. Puray\n0800 ETA Brgy. Puray. Register, secure guides\n0830 Resume habal-habal ride\n0900 ETA trailhead, start trekking\n0930 First rest stop, Optional sidetrip to Lubog Cave\n1030 Second rest stop\n1045 ETA summit (955m)\n1200 Start descent\n1330 Back at trailhead, Optional trek to Panintingan Falls\n1415 Take a dip at the lagoon\n1500 Back to rough road; take habal-habal\n1630 ETA Brgy. San Rafael",
                    Practicalities = "Transportation\nPublic (1) Van, Cubao to Montalba (P50 1-1.5 hrs) (2) habal-habal to Sitio Lubog (P450 per pax including all fees to the whole adventure\n\nRegistration\nPrior arrangement is required in order to make arrangements for the guides and habal-habal\n\nGuides\nAvailable, assigned at the barangay hall; this is included in P450 per pax package\n\nContact Numbers\nKagawad Peter � 09284647447\n\nCampsites\nView deck near the registration\n\nWater sources\nNone\n\nCell phone signal\nNo signal all throughout the trail\n\nRiver crossing\nNone\n\nRope Segments\nNone\n\nSidetrips\nLubog Cave and Panintingan Falls\n\nAlternate trails\nPossible to traverse Mt. Balagbag\n\nDayhikable\nYes (1.5 hrs to the summit, 1 hr down)\n\nFacilities at jump-off\nSari-sari store\n\nEstimated budget\n700-800\n\n",
                 Attire = "Dri-fir or Shirt\nTrekking pants or Short\nHiking shoes or Sandals\nCap or bush hat\ngloves",
               Ttb = "Backpack 28L capacity\nHiking shoes or sandals\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nPacked lunch\nTrail food\nMess kit (Spoon & fork)\nMulti-tool (swiss knife)\nMap or Compass\nWater or energy drink\ngloves (optional) \n"
                },

                new Mountain()
                {
                    MtName = "MACULOT",
                    Masl = 930,
                    Difficulty = 4,
                    Island = 1,
                    MtImg00 = Resource.Drawable.maculot,
                    MtImg01 = Resource.Drawable.maculot1,
                    MtImg02 = Resource.Drawable.maculot2,
                    MtImg03 = Resource.Drawable.maculot3,
                    MtImg04 = Resource.Drawable.maculot4,
                    MtImg05 = Resource.Drawable.maculot5,
                    Location = "NASUGBU, BATANGAS",
                    JumpOff ="Brgy. Siete, Cuenca",
                    Description ="LLA: 13� 55 N, 121� E, 706 MASL (Rockies)/ 930 MASL (Summit)\nDays required: 1 day\nHours to summit: 1-2 hrs Rockies/ 2-4 hrs Summit\nSpecs: Minor climb, Difficulty: 3/9 (Rockies) 4/9 (Traverse)\nTrail class: 1-3 with Roped segments\nFeatures: Scenic views of Taal lake, rock formations, forest\n\n",
                    Background ="Mt. Maculot is one of the most popular hiking destination. It is so popular that on weekends and summer months that the mountain is receive too many impacts and visitors. The mountain is located at the heart of Cuenca, Batangas that it is easily identifiable because of its form and breathtaking to everybody else especially the visitors. The mountain has three parts or destination that hikers usually visit: the famous Rockies (760m), the summit (930m) and the Grotto (510m). These can be covered by a traverse dayhike, but most hikers head to the Rockies because of its beautiful, breathtaking scenery which is the reason why many of them took pictures, posing in the rocking in that place. Only 5% of hikers pursue the traverse which will walk the whole mountain trail from different starting point until reaching the other side.\n\nIt is understandable, though, that the Rockies is Maculot�s most powerful draw or the most popular place in the mountain that caught the attention of the beginner hikers. This rocky formation stands beside Taal Lake including the worlds famous Taal Volcano; as well as the plains of Batangas. In the Summit you can see the other mountains of Batangas: Mt. Makiling, Malipunyo mountain ranges and Tagaytay Highlands. The climbing time is variable; experienced hikers can reach the Rockies in less than an hour, but on a more relaxed pace, one could take up to two or three hours.\nFrom the summit of Maculot, there are two trails: one that follows the trail of the origin, and another than goes down right from the summit. This goes to the Grotto where hikers can experience the steep trail land roped segment of the mountain. The forest ends where the Grotto emerges, and the Grotto has Stations of the Cross that follows to reach the end of the trail.\n\n",
                    Itinerary ="Rockies\n\n0600 Board Lemery-bound bus from Buendia or Cubao (P130)\n0900 ETA Cuenca Poblacion � Highway. Walk or take trike to jump-off\n0930 Start trek\n1115 Arrive at campsite, head to Rockies\n1130 At Rockies; take pictures\n1200 Return to campsite for lunch\n1230 Start descent\n1400 Back at jump-off; tidy up then head back to the highway from\nManila-bound bus.\n\nTRAVERSE (Rockies-Summit-Grotto)\n\n0500 Board Lemery-bound bus from Buendia or Cubao (P130)\n0800 ETA Cuenca Muncipal Hall, Walk or take trike to jump-off, P10 registration fee\n0830 Start trek\n1000 Arrive at campsite, head to Rockies\n1010 At Rockies; take pictures\n1110 Leave for the summit\n1230 ETA Summit of Mt. Maculot, Lunch\n1300 Start descent to Grotto\n1430 Arrival at Grotto, Rest\n1445 Resume descent\n1600 Arrival at exit point\nGrotto\n\n0600 Board Lemery-bound bus from Buendia or Cubao (P130)\n0900 ETA Cuenca Poblacion � Highway, Take trike to \"Grotto at Brgy. 5\"\n0930 Registration/ Start trek\n1100 Arrival at Grotto, Explore the area/ Lunch\n1145 Start descent\n1300 Arrival at exit point",
                    Practicalities = "Transportation\nPublic (1) Lemery-bound bus from bus terminals in Cubao (MRT3: Cubao; LRT 2 Cubao) or Buendia (LRT1: Gil Puyat) (P150-P160; 2.5 hrs). Alternatively, one can take a bus to Lipa then take jeepney to Bayan ng Cuenca (P28). From there, you can either walk to the jump-off or (2) take a tricycle (P50 per pax). The tricycle will detour you to the registration area\nPrivate (1) SLEX to Lipa Batangas, turn left until you reach the way to Bayan ng Cuenca follow the road and you will see the town of Cuenca\n\nRegistration\nLogbook at brgy. outpost. P20\n\nGuides\nMandatory as of January 2015: P400/5 pax/day for the regular \n\nContact Numbers\n(1) Barangay Outpost � 09103172853/n(2) Cuenca Police Station � (043) 342-9952\n\nCampsites\nWide campsite is available before the Rockies and Summit\n\nWater sources\nAvailable in some parts of the trail\n\nCell phone signal\nPresent throughout the trail\n\nRope Segments\n(1) The slippery part of new trail going to campsite, Rockies part\n(2) Some part of the trail going to Summit from Grotto\n\nSidetrips\nTwin dayhike with Manabu Peak\nLunch or Dinner at Lipa city\n\nAlternate trails\nNone\n\nDayhikable\nYes (2-3 hrs to summit; 1.5-2 hrs down)\n\nFacilities at jump-off\nShower at the wash up area\nSari-sari store or Mountaineer store\nParking space\nBrgy\n\nEstimated budget\n600-900\n\n",
                     Attire = "Dryfit or Shirt\nTrekkin pants or Short\nHiking shoes or Sandals\nCap or bush hat",
          Ttb = "Dayhike\n\nBackpack 28L capacity\nHiking shoes or sandals\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nPacked lunch\nTrail food\nMess kit (Spoon & fork)\nMulti-tool (swiss knife)\nMap or Compass\nWater or energy drink\ngloves (optional) \n\nOvernight\n\nBackpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"
     },

                new Mountain()
                {
                    MtName = "MADJAAS",
                    Masl = 2102,
                    Difficulty = 8,
                    Island = 2,
                    MtImg00 = Resource.Drawable.madjaas,
                    MtImg01 = Resource.Drawable.madjaas1,
                    MtImg02 = Resource.Drawable.madjaas2,
                    MtImg03 = Resource.Drawable.madjaas3,
                    MtImg04 = Resource.Drawable.madjaas4,
                    MtImg05 = Resource.Drawable.madjaas5,
                    Location = "CULASI, ANTIQUE",
                    JumpOff ="Brgy. Flores, Culasi",
                    Description ="LLA: 11.38932� N, 122.16197� E 2102 MASL\nDays required: 3-4 days\nHours to summit: 14 hrs\nSpecs: Major climb, Difficulty: 8/9\nTrail class: 1-4\nFeatures: Open slopes, mossy forest, waterfalls, highest point\n\n",
                    Background ="Mt. Madjaas in Culasi, Antique is one of the most challenging climbs in the Visayan Islands. Some questions have been raised whether Mt. Madjaas is the highest or second highest in Panay, but for now it is recognized as the highest. And regardless of this dispute, Madjaas is certainly the mountain that makes Antique a truly rewarding destination for climbing. Madjaas means �mataas� in some local dialect, but in English it can suitably described as �lofty� instead of just tall. This loftiness will definitely be felt in the summit which opens up to the view of Western Panay island and the surrounding seas, but it extends to the mossy forests of the mountain, in which several unique flora and found have been identified.\n\nAccess is still limited and Madjaas is currently a relative-unexplored peak\n\n",
                    Itinerary = "Day 0\n\nTravel time from Kalibo, San Jose or Iloilo to Culasi\nand off to Brgy. Flores\n\nDay 1\n\n0500 Wakeup call/ Breakfast/ Prepare lunch\n0700 Start trek\n1200 Lunch on the trail\n1700 Arrival at Bantang River campsite/ Set camp\n1800 Dinner/ socials\n\nDay 2\n\n0500 Wakeup call/ Breakfast/ Prepare lunch\n0630 Break camp\n0700 Resume trek\n1200 Lunch on the trail\n1700 Arrival at Camp 3. Set camp\n1800 Dinner/ socials\n\nDay 3\n\n0500 Assault to summit for sunrise\n0530 ETA Mt. Madjaas summit\n0630 Head back to Camp\n0700 Back at Camp 3/ Breakfast/ Prepare packed lunch\n0800 Start descent\n1200 Lunch on the trail\n1700 Back at Brgy. Flores jump-off. Spend the night\nor take arranged transportation back to Culasi\n\nDay 4\n\nSidetrips/ Head back to Iloilo or Kalibo",
                    Practicalities = "Transportation\nPublic (1) take a bus from your arrival point in Panay Island, more frequently Iloilo (4-5 hours ride) or Kalibo (2-3 hours). (2) Then take a tricycle or jeep to the jumpoff at Brgy. Flores.\n\nRegistration\nEntry permit P150 per pax\n\nGuides\nAvailable P350 per guide/ per day (2 guides)\n\nContact Numbers\nMr. John John Sumanting (Tourism Officer) � (036) 277-8077/09163245068\nAdonis (Guide) � 09286878128\n\nCampsites\n(1) Bantang Campsite 1\n(2) Madjaas Summit Campsite 2\n\nWater sources\nAvailable in some parts of the trail\n\nCell phone signal\nAvailable in some parts of the trail\n\nRope Segments\nNone\n\nSidetrips\nMalalison Island (15 mins boatride)\nKawa Hot Pot in Tibiao, Antique\n\nAlternate trails\nNone\n\nDayhikable\nNo\n\nFacilities at jump-off\nSari-sari stores\nWash up places\n\nEstimated budget\n2000-2500\n\n",
            Attire = "Jacket, Windbreaker or Shirt\nTrekking Pants\nHiking Shoes\nCap or bush hat",
   Ttb = "Backpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"
     },

                new Mountain()
                {
                    MtName = "MAKILING",
                    Masl = 1090,
                    Difficulty = 6,
                    Island = 1,
                    MtImg00 = Resource.Drawable.makiling,
                    MtImg01 = Resource.Drawable.makiling1,
                    MtImg02 = Resource.Drawable.makiling2,
                    MtImg03 = Resource.Drawable.makiling3,
                    MtImg04 = Resource.Drawable.makiling4,
                    MtImg05 = Resource.Drawable.makiling5,
                    Location = "STO. TOMAS, BATANGAS",
                    JumpOff ="Brgy. San Felix Sto. Tomas, Batangas",
                    Description ="LLA: 14.13� N, 121.20� E, 1090 MASL (Peak 2)\nDays required: 1-2 days\nHours to summit: 7-8 hrs (Traverse)\nSpecs: Major climb, Difficulty: 6/9\nTrail class: 3 with roped segments\nFeatures: Mossy forest\n\n",
                    Background ="The challenging side of the Mt. Makiling located in Brgy. San Felix, Sto. Tomas, Batangas. The mountain is a mossy forest that many unusual animals and plants are to be found in here. The forest is field with many limatiks (blood sucking leeches) that will bite hikers unconsciously. The trails are also labyrinthine because many locals are creating more entry and exit points in the mountain. In the past many injuries and deaths of hikers are recorded in this mountain, because of that few hikers are only challenging this mountain.\n\nThe trail starts at the \"sBasurahan\" or Eco-Park, the jump-off is full of pipelines all over the place because of MakBan Geothermanl Plant in the area. The trail will lead into an open field that will give you a glimpse of Mt. Makiling Sto. Tomas side look. This open field has still has pipelines from the MakBan Geothermal. Mt. Makiling is named \"Maktrav\" because the beast way to experience the whole hike is to do a traverse from Sto. Tomas, Batangas to UP Los, Banos, and the trails consists of roped segments because of the steep trails and bouldering. This is an action packed dayhike, traversing Mt. Makiling, is likewise gaining popularity, considering the difficulty of carrying heavy packs across Makiling, a dayhike is a good option � and it is worth try.\n\n",
                    Itinerary = "Via Sipit (East) Trail Traverse\n\n0430 ETD LRT-Buendia, board bus passing by Sto. Tomas to Brgy. San Felix\n0600 Take tricycle to \"Basurahan\" or Makiling\n0630 ETA jump-off, Register, No fees required\n0700 Start trek\n0730 ETA Station 1 then Station 2 (Kambigan)\n0800 Find trail left of Rocky River\n1030 Merge with main trail (marked with red and white ribbons). Follow it to the right (NE)\n1100 ETA Melkas Ridge campsite\n1130 Commence Melkas Ridge crossing\n1200 ETA Peak 3. Follow Wild Boar trail to Peak 2\n1400 ETA Peak 2 (Mt. Makiling summit), Late lunch\n1430 Start descent via UPLB trail\n1530 ETA UP College of Forestry, Shower up\n1700 Take jeepney to the entrance of UPLB; take jeepney to Crossing\n1800 Take Bus bound to Buendia\n2000 ETA Manila",
                    Practicalities = "Transportation\nPublic (1) Take bus, Buendia bound to Lucena and drop you off at Brgy. San Felix Sto. Tomas (P120 2 hrs) (2) take tricycle to Basurahan (P20 30 mins\n\nRegistration\nLogbook at the Nursery, UPLB College of Forestry (P10)\n\nGuides\nAvailable, Guides are required\n\nContact Numbers\nMENRO Sto. Tomas - 043-7848434\nSir Erwin Adornado - 09183460730\n\nCampsites\nPossible at Agila Base, UPLB side\n\nWater sources\nBefore reaching Agila Base\n\nCell phone signal\nSporadic during the hike, Strong at the Summit\n\nRope Segments\nYes, there are fixed rope in Melkas Ridge and other steep trails\n\nSidetrips\nLaguna is known for their Hotspring; Pansol, UPLB\nThe Original Buko pie near the UPLB (P250)\n\nAlternate trails\nHikers can choose to traverse or not or start from the other side of the mountain\nUPLB Trail, Palanggana Trail\n\nDayhikable\nYes (5-6 hrs up, 3-4 hrs down)\n\nFacilities at jump-off\nSari-store\nNursery (UPLB side)\nWash up places\n\nEstimated budget\n600-700\n\n",
                    Attire = "Dryfit or Shirt\nTrekkin pants or Short\nHiking shoes or Sandals\nCap or bush hat",
             Ttb = "Dayhike\n\nBackpack 28L capacity\nHiking shoes or sandals\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nPacked lunch\nTrail food\nMess kit (Spoon & fork)\nMulti-tool (swiss knife)\nMap or Compass\nWater or energy drink\ngloves (optional) \n\nOvernight\n\nBackpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"
  },

                 new Mountain()
                {
                    MtName = "MANABU PEAK",
                    Masl = 760,
                    Difficulty = 2,
                    Island = 1,
                    MtImg00 = Resource.Drawable.manabu,
                    MtImg01 = Resource.Drawable.manabu1,
                    MtImg02 = Resource.Drawable.manabu2,
                    MtImg03 = Resource.Drawable.manabu3,
                    MtImg04 = Resource.Drawable.manabu4,
                    MtImg05 = Resource.Drawable.manabu5,
                    Location = "STO. TOMAS, BATANGAS",
                    JumpOff ="Sulok, Brgy. Sta. Cruz, Sto. Tomas",
                    Description ="LLA: 13.9777 N, 121.2413 E, 760 MASL\nDays required: 1 day\nHours to summit: 1-2 hrs\nSpecs: Minor climb, Difficulty: 2/9\nTrail class: 1-2\nFeatures: Woodlands, meadow peak, views of Batangas Mountains\n\n",
                    Background ="Mt. Manabu is one of the 3 major peaks of Malipunyo mountain ranges in Sto. Tomas, Batangas. The mountain is just 2 hours to climb from the starting point because it is less challenging and it is good for beginner hikers. The highest point is marked with a big white cross. During summer months, wild berries that are called \"sampinit\" grow on the trails near the peak. They are edible and sweet, like mini-strawberries. The mountain is probably the easiest and also the one of the accessible mountains from Manila.\n\nThe name Manabu means \"Mataas na Bundok\" said by the locals residing near the mountain. Being one of the 3 major peaks of Malipunyo mountain ranges the other two which is the Malipunyo summit and Susong Dalaga peak are also can be seen from the campsite until the summit of Mt. Manabu. The weather in Mt. Manabu is usually cloudy, lending an almost nostalgic air. The best thing in the mountain is that the Alamid Coffee is free in Mang Pirying's hut. They will offer the hikers to drink Alamid Coffee for free while takinga quick rest and chatting with them. Alamid coffee is made up of Civet cat's droppings which is the digested coffee and also known as the world's most expensive coffee.\n\n",
                    Itinerary = "Dayhike\n\n0600 ETD Lucena or Lipa Batangas bound bus at Gil Puyat\n0730 ETA Fiesta Mall, Sto. Tomas Take trycicle to \"Sulok\"\n0830 ETA \"Sulok\", Brgy. Sta. Cruz\n0900 Start Trek\n1000 Reach Mang Pirying's hut\n1100 ETA Summit\n1130 Start decent\n1300 Lunch at Rose and Grace (famous for Bulalo)\n1500 ETD Sto. Tomas bus bacl to Manila\n1700 ETA Manila",
                    Practicalities = "Transportation\nPublic (1) Bus, Buendia or Lipa, Batangas (approximately 2 hrs) (2) Take Multi-cab to Fiesta Mall P12 (3) Tricycle, Fiesta Mall to Sulok, Brgy. Sta Cruz (approximately 30 mins) P100 per trip *the tricycle terminal is at Fiesta Mall junction.\nPrivate from Manila go to Tagaytay city and then proceed to Tagaytay-Nasugbu road until Evercrest Golf Course reached. Go past the gate, follow through, turn left at the fork, and then go down the rough road to the trailhead. (Approximately 2.5 hours)\n\nRegistration\nLogbook at the brgy hall. P20 fee per pax\n\nGuides\nAvailable at the brgy. But it is not required (P500 for dayhike, P1250 for overnight camping)\n\nContact Numbers\nMario (Guide) - 09994106990\n\nCampsites\nThe campsite is located before the summit accent. Can fit up to 20 tents\n\nWater sources\nSeveral; available at the rest stops\n\nCell phone signal\nPresent through most parts of the trail\n\nRiver crossing\nSmall stream near the starting point with minimal risk of flooding\n\nRope Segments\nNone\n\nSidetrips\nHikers usually done a Twin dayhike with Mt. Manabu and Mt. Maculot\n\nAlternate trails\nPossible to do a traverse to or from Mt. Malipunyo\n\nDayhikable\nYes (2.5-4 hrs to summit; 1.5-3 hrs down)\n\nFacilities at jump-off\nSari-sari store\nWash up/ shower places\nParking\n\nEstimated budget\n500-700 (dayhike)\n800-1000 (overnight)\n\n",
                   Attire = "Dryfit or Shirt\nTrekkin pants or Short\nHiking shoes or Sandals\nCap or bush hat",
               Ttb = "Dayhike\n\nBackpack 28L capacity\nHiking shoes or sandals\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nPacked lunch\nTrail food\nMess kit (Spoon & fork)\nMulti-tool (swiss knife)\nMap or Compass\nWater or energy drink\ngloves (optional) \n\nOvernight\n\nBackpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"
    },

                new Mountain()
                {
                    MtName = "MANTALINGAJAN",
                    Masl = 2086,
                    Difficulty = 9,
                    Island = 2,
                    MtImg00 = Resource.Drawable.mantalingahan,
                    MtImg01 = Resource.Drawable.mantalingahan1,
                    MtImg02 = Resource.Drawable.mantalingahan2,
                    MtImg03 = Resource.Drawable.mantalingahan3,
                    Location = "SOUTHERN PALAWAN",
                    JumpOff ="Brgy. Ransang, Rizal, Palawan",
                    Description ="LLA: 8�48 N 117�40 E, 2086 MASL\nDays required: 3-5 days\nHours to summit: 15-20 hrs\nSpecs: Major climb, Difficulty: 9/9\nTrail class: 2-5\nFeatures: Indigenous tribes, unique flora and fauna\n\n",
                    Background ="Palawan, the last frontier in the Philippine mountaineering. Known more for its beaches, marine life, and tourist spots such as the Puerto Princesa Underground River, Palawan�s potential as a hiking hotspot is overwhelming. The length of Palawan spans over 600 kilometers, bordering South Luzon and North Borneo. On its central part there is a mountain range, many peaks of which are unnamed and unexplored. The literal pinnacle of these highlands is Mt. Mantalingajan, locally revered as \"The Mountain of God\". Rising at 2086 MASL.\n\nAn average of 4-5 days must be devoted to scale Mantalingajan � earning for it the distinction of being the mountain with the longest minimum time to reach the summit. Only the physically- and mentally-prepared are encouraged to attempt the climb, because it is really very difficult. A hike to the mountain requires crossing the sheer length of Mt. Halcon, and overcoming the sheer difficulty of Mt. Guiting-Gutiing. The constant menace of malaria - through dwindling - further highlights the perils of the place.\n\n",
                    Itinerary = "Day 0\n\n1000 Arrival at Puerto Princesa; take tricycle to bus terminal\n1100 Take Charing Bus Lines to Rizal, Palawan (P250)\n1700 ETA Rizal, Palawan. Head to Castelar Lodge (P150/night)\n1730 Pay courtesy call to mayor\n\nDay 1\n\n0700 Shop for supplies at market\n0800 Take jeep or ride motorcycle to Brgy. Ransang jump-off\n0900 ETA Brgy. Ransang; Start trek\n1000 Arrival at first village (Balin-Balin)\n1100 Arrival at second village. Secure porter/ guide. Early lunch.\n1200 Resume trek\n1600 ETA Mt. Dulangbukid; cross the four brooks\n1800 Arrival at Balu�in campsite (water source nearby)\n1830 Dinner\n\nDay 2\n\n0600 Wakeup call/ Breakfast\n0700 Resume trek\n1200 Arrival at Kawayan campsite; lunch\n1300 Resume trek\n1400 ETA Agong-Agungan (place of week-long wine feast)\n1600 Reach start of canopy walk at Mt. Tulanggok\n1800 Arrival at Palay-Palay campsite (water source nearby)\n1830 Dinner\nDay 3\n\n0600 Wakeup call/ Breakfast\n0700 Commence summit assault; bring packed lunch\n0845 Reach Simba Rock\n0930 Arrival at First Peak (2055 MASL)\n1000 ETA Mt. Mantalingajan summit (2086 MASL)\n1200 Lunch at summit\n1300 Descent\n1530 Back at Palay-Palay campsite\n1600 Rest time\n1800 Dinner/ socials\n\nDay 4\n\n0600 Wakeup call/ Breakfast\n0700 Start descent\n1000 Arrival at Mangkopa campsite\n1200 Arrival at Balu�in campsite/ Lunch\n1300 Resume trek\n1730 Arrival at village\n1800 Dinner/ Interaction with locals\n\nDay 5\n\n0600 Wakeup call/ Breakfast\n0700 Start descent\n0800 ETA Balin-Balin village\n0900 Back at jump-off\n1200 If time permits, take last trip to Puerto Princesa\n\nDay 6\n\nHead back to Manila or sidetrips/ other destinations",
                    Practicalities = "Transportation\nPublic (1) Van from San Jose to Rizal (P300 several departures daily; last trip 1200H or 1400H) (2) Motorcycle from Rizal to Brgy. Ransang (P400 per person) (3) Van from Brgy. Malis (exit point) to Puerto Princesa (P300 More frequent departures; first trip 0300H, last trip 2200H)\n\nRegistration\n(1) Logbook and P100/person at DENR-CENRO Quezon (ask van driver to drop you off)\n(2) Logbook, Rizal Tourism. No fees\n(3) Logbook, Rizal Police Station, No fees\n(4) Logbook and P100/person at Brgy. Ransang, If doing the traverse:\n(5) Logbook at Brgy. Malis, Brooke�s Point, No fees\nTotal fees per hiker P200\n\nGuides\nAvailable: 500 per day for guides and porters.\n\nContact Numbers\nDENR-PASU (Claris Pador) +639287129155\nRizal Tourism (Evelyn Reyes) +639981846682\nGuide (Kuya Binoy) +639308624828\n\nCampsites\n(1) Olango Camp 3\n(2) Mayo's Peak\n(3) Traditional Camp 2 and 3\n\nWater sources\nNumerous, including several streams on both sides of the traverse. Balin-Balin, Kabugan and Paray-Paray campsites all have nearby water sources. Note that drinking water from some streams are said to be taboo\n\nCell phone signal\nPresent in many parts of the mountain\n\nRope Segments\nNone\n\nSidetrips\nSingapan Cave, Estrella falls in Narra and Tabon Cave in Quezon\n\n\n\nDayhikable\nNo\n\nFacilities at jump-off\nSari-sari storesBarangay hall\n\nEstimated budget\n3000-4000 from Puerto Princesa\n\n",
             Attire = "Jacket, Windbreaker or Shirt\nTrekking Pants\nHiking Shoes\nCap or bush hat",
    Ttb = "Backpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"
   },

               

                new Mountain()
                {
                    MtName = "MARAMI",
                    Masl = 405,
                    Difficulty = 3,
                    Island = 1,
                    MtImg00 = Resource.Drawable.marami,
                    MtImg01 = Resource.Drawable.marami1,
                    MtImg02 = Resource.Drawable.marami2,
                    MtImg03 = Resource.Drawable.marami3,
                    MtImg04 = Resource.Drawable.marami4,
                    MtImg05 = Resource.Drawable.marami5,
                    Location = "MARAGONDON, CAVITE",
                    JumpOff ="Brgy. Ramirez, Magallanes, Cavite",
                    Description ="LLA: 405 MASL\nDays required: 1-2 days\nHours to summit: 4-6 hrs\nSpecs: Minor climb, Difficulty: 3/9\nTrail class: 1-3\nFeatures: Rocky outcrops, scenic views of Cavite\n\n",
                    Background ="Mt. Marami is shares the same characteristics as the Pico De Loro�s because of the rock formation that is seen during the hike, Matching Pico de Loro�s rocky tower. The face of Mt. Marami looks like a monumental rocky pillars that is ideal for rock climbers but until now no one attempts to climb the rocky face of Mt. Marami by bouldering. The name \"Marami\" is of local origin, and is attributed to the \"many rocks\"that formed it. According to the locals the original name of Mt. Marami is \"Nagbuo\" and was christened with its present name by the earlier mountaineers.\n\nThe major Jump-off to Mt. Marami is Brgy. Ramirez in Magallanes, Cavite. However the summit and its environs are under the jurisdiction of Maragondon, Cavite. It is a 3-hour drive from Manila; passing by the Coastal road, onwards to Tanza, then Naic, from Naic a jeepney can take you to Magallanes. Brgy. Ramirez is just 10 minutes away from the town proper, and accessible by tricycle. The barangay hall is where the arrangement of guides and registration before proceeding the hike.\nThe trail begins smoothly; although it poses concerns for both wet and dry seasons. It is severely muddy when wet (your feet can sink in some part of the mud); whereas sun exposure is notoriously acute when dry and heatstroke can be the effect for the hikers. Even so, the views in the summit is very rewarding. River crossing in the rainy season can be possible but when the dry season comes the rivers are not visible and dry.\nAt the summit of Mt. Marami, there is an obstacle going to the other part of the summit that will require hikers to jump or step wider to pass through the small cliff. It is dangerous and you make take note of it.\n\n",
                    Itinerary = "Day 1\n\n0500 ETD Coastal Mall Saulog bus to Naic (P65)\n0700 ETA Naic, take jeepney to Magallanes (P30)\n0800 ETA Magallanes, Register at Police Station, take tricycle to Brgy. Ramirez\n0900 ETA Brgy. Ramirez; register\n0930 Start trek\n1000 ETA IlognaKayrayag\n1100 Cross three segments of Bangkaan River; proceed to NuestraSe�ora de la Paz\n1200 Lunch; There�s a nearby water source\n1300 Resume trek to Campsite 1\n1400 ETA Campsite 1\n1500 Reach Bamboo Forest\n	1600 ETA campsite at base of Mt. Marami summit\n1630 Assault the summit; explore\n1800 Return to camp\n1830 Dinner, socials\n\nDay 2\n\n0530 Wake up, sunrise viewing\n0630 Breakfast\n0730 Break camp\n0800 Start descent\n1230 Back at jump-off point at Brgy. Ramirez\n1300 Leave for Municipal Hall, then Naic via jeep\n1400 ETA Naic. Take bus back to Manila\n1700 Back in Manila",
                    Practicalities = "Transportation\nPublic (1) Bus, Coastal to Naic (P60, 2 hrs) (2) Jeep, Naic to Magallanes (P35, 45 mins � 1 hr) (3) Tricycle, Magallanes Police Station to trailhead (P30 per pax; 20 mins) *last trip of jeepney from Magallanes to Naic is 5 pm\nPrivatetake CAVITEX or Aguinaldo highway all the way to Naic, Cavite, then follow the signs to Magallanes. Ask directions for Brgy. Ramirez\n\nRegistration\nRegister at barangay hall. Logbook P25\n\nGuides\nAvailable; assigned at the barangay hall or by prior arrangement P100 per pax.\n\nContact Numbers\nGuides � 09267122198\nGuides � 09083246967\nGuides � 09982421045\n\nCampsites\n(1) Campsite 1 before the bamboo forest\n(2) Summit campsite\n\nWater sources\nPresent near the streams at the initial\n\nCell phone signal\nSporadic at the lower reaches\nPresent from 600m up to the peak\n\nRope Segments\nNone\n\nSidetrips\nNearby mountains include Pico de Loro, Mt. Buntis, and other mountains of Maragondon, as well as some historical sites in the area\nPuerto Azul in Ternate\n\nAlternate trails\nPossible to Traverse in Pico De Loro\n\nDayhikable\nYes (2.5-4 hours to summit; 1.5-3 hours down)\n\nFacilities at jump-off\nBrgy hall\nSari-sari stores\nWash-up / shower places\n\nEstimated budget\n500-700 (dayhike)\n800-1000 (overnight)\n\n",
                     Attire = "Dryfit or Shirt\nTrekkin pants or Short\nHiking shoes or Sandals\nCap or bush hat",
          Ttb = "Dayhike\n\nBackpack 28L capacity\nHiking shoes or sandals\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nPacked lunch\nTrail food\nMess kit (Spoon & fork)\nMulti-tool (swiss knife)\nMap or Compass\nWater or energy drink\ngloves (optional) \n\nOvernight\n\nBackpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"
   },

                new Mountain()
                {
                    MtName = "MATUTUM",
                    Masl = 2293,
                    Difficulty = 4,
                    Island = 3,
                    MtImg00 = Resource.Drawable.matutum,
                    MtImg01 = Resource.Drawable.matutum1,
                    MtImg02 = Resource.Drawable.matutum2,
                    MtImg03 = Resource.Drawable.matutum3,
                    Location = "TUPI, SOUTH COTABATO",
                    JumpOff ="Sitio Glandang, Brgy. Kablon, Tupi",
                    Description ="LLA: 6�22 N, 125�06.5 E, 2293 MASL\nDays required: 1-2 days\nHours to summit: 4-6 hrs\nSpecs: Minor climb, Difficulty: 4/9\nTrail class: 3\nFeatures: Rolling hills, plains\n\n",
                    Background ="Mt. Matutum is located in Tupi, South Cotabato, and a town famous for its pineapple plantations. Its characteristic is irregular but imposing cone shape dominates the landscape from General Santos to Koronadal City. It is so tall that it literally beckons hikers passing by the road from GenSan to Koronadal to climb it. Rising at 2239 MASL, it is also considered as an active volcano.\n\nLocal officials have made the mountain as an ecotourism spot for regulating hiking activities. They are requiring hikers to plant a seedlings in the designated area in the mountain for every visit in the mountain.  The motto is \"Amyak Maleh Matutum!\" which means Climb and Plant Matutum!\n\n",
                    Itinerary = "Day 1\n\n0500 Take bus, transport to Tupi, South Cotabato\n0900 ETA Kablon Crossing, Tupi. Take vehicle to Sitio Glandang\n0930 ETA jump-off; register at Tourist Guard House, DENR\n1100 Start trek\n1200 Lunch at Camp 1\n1300 Resume trek\n1700 ETA summit of Mt. Matutum\n1800 Dinner, socials\n\nDay 2\n\n0600 Breakfast, sunrise views\n0700 Break camp\n0800 Start descent\n1200 Back at jump-off; return to highway\n1300 Take bus back to Davao, GenSan, Koronadal",
                    Practicalities = "Transportation\nPublic (1) Bus, to Tupi, South Cotabato (2) Kablon Crossing, Tupi take vehicle to Sitio Glandang jump-off\n\nRegistration\nSecure permission beforehand P150 climb fee\nTogether with P10 fee for seedlings\n\nGuides\nAvailable arrangements in tourism office\n\nContact Numbers\nNone; Tourism Office \n\nCampsites\nCampsite 1\n\nWater sources\nWater source at Camp 1\n\nCell phone signal\nPresent throughout the hike\n\nRiver crossing\nNone\n\nRope Segments\nNone\n\nSidetrips\nPineapple Plantations\n\nAlternate trails\nTrails are either to start in Koronadal or GenSan\n\nDayhikable\nPossible dayhike and traverse\n\nFacilities at jump-off\nSari-sari stores\nWash up area\n\nEstimated budget\n500-800 from Cotabato\n\n",
                      Attire = "Dryfit or Shirt\nTrekkin pants or Short\nHiking shoes or Sandals\nCap or bush hat",
         Ttb = "Dayhike\n\nBackpack 28L capacity\nHiking shoes or sandals\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nPacked lunch\nTrail food\nMess kit (Spoon & fork)\nMulti-tool (swiss knife)\nMap or Compass\nWater or energy drink\ngloves (optional) \n\nOvernight\n\nBackpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"
     },

                new Mountain()
                {
                    MtName = "NAPULAK",
                    Masl = 1239,
                    Difficulty = 4,
                    Island = 2,
                    MtImg00 = Resource.Drawable.napulak,
                    MtImg01 = Resource.Drawable.napulak1,
                    MtImg02 = Resource.Drawable.napulak2,
                    Location = "IGBARAS, ILOILO",
                    JumpOff ="Brgy. Bagay, Igbaras",
                    Description ="LLA: E, 1239 MASL (+1030m)\nDays required: 1-2 days\nHours to summit: 4-6 hrs\nSpecs: Minor climb, Difficulty: 4/9\nTrail class: 1-5\nFeatures: Tropical rainforest, scenic views of Igbaras, rock formations\n\n",
                    Background ="Mt. Napulak the most famous mountain and the oldest hiking destination in the Visayas located at the southern tail end of Panay Island's great mountain ranges. Mt. Napulak meaning \"nipple\" in the local language because of the rounded rock that sits at its very summit, this mountain is the most popular hiking destination in Panay, given its easy access from the university town of Miag-ao and the major commercial centre in the region, Iloilo City, where many local hikers are based.\n\nHikers who are based hiking in the Luzon Mountains will find that Mt. Napulak is a melange of dayhike destinations in Manila, having the forest of Manabu, the grassy slopes of Batulao, and the limestone formations of the Montalban Mountains. The mountain is less than an hour away from Iloilo, a worthy dayhike for hikers out there!\n\n",
                    Itinerary = "Traverse Dayhike\n\n0500 Take Ceres bus from Iloilo to Igbaras crossing\n0600 ETA Igbaras crossing, Log in at police station\n0630 Take habal-habal to Brgy. Bagay\n0700 ETA Brgy. Bag-ay, Start trek\n0815 Enter forested part\n0915 Rest at last water source\n1030 Arrive at grassland part\n1100 ETA Summit/ Early lunch\n1200 Start descent via Brgy. Tigbanaba\n1500 At Brgy. Tigbanaba; end of trek\n1530 Take habal-habal back to Igbaras\n			1600 Take bus, van or jeep back to Iloilo\n1730 Back in Iloilo",
                    Practicalities = "Transportation\nPublic (1) Bus, Iloilo to Igbaras crossing (P50 30-45 mins) (2) Brgy. Bag-ay (P50, 20 mins) Approximately 1.5-2 hrs travel time from Iloilo\nPrivate (1) Take the Iloilo-Antique highway, passing by the towns of Oton, Tigbauan, and Guimbal, then making a right turn to Igbaras. From Igbaras municipality, take habal-habal to trailhead (see above) Approximately 1-1.5 hours travel time from Iloilo\n\nRegistration\n(1) Logbook at the Igbaras Police Station, No fees\n\nGuides\nAvailable P500 per day\n\nContact Numbers\nJaime (Guide) � 09262972165\n\nCampsites\n(1) Near the summit\n\nWater sources\nSeveral sources along the Bag-ay trail\n\nCell phone signal\nPresent in most parts of the trail\n\nRope Segments\nNone\n\nSidetrips\nOther nearby mountains of Panay\n\nAlternate trails\nNone\n\nDayhikable\nYes (3.5-5 hours up, 2-3 hours down)\n\nFacilities at jump-off\nSari-sari stores\n\nEstimated budget\n400-500 from Iloilo City\n\n",
                  Attire = "Dryfit or Shirt\nTrekkin pants or Short\nHiking shoes or Sandals\nCap or bush hat",
                   Ttb = "Dayhike\n\nBackpack 28L capacity\nHiking shoes or sandals\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nPacked lunch\nTrail food\nMess kit (Spoon & fork)\nMulti-tool (swiss knife)\nMap or Compass\nWater or energy drink\ngloves (optional) \n\nOvernight\n\nBackpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"
  },

                new Mountain()
                {
                    MtName = "OSME�A PEAK",
                    Masl = 1013,
                    Difficulty = 3,
                    Island = 2,
                    MtImg00 = Resource.Drawable.osmena,
                    MtImg01 = Resource.Drawable.osmena1,
                    MtImg02 = Resource.Drawable.osmena2,
                    MtImg03 = Resource.Drawable.osmena3,
                    MtImg04 = Resource.Drawable.osmena4,
                    MtImg05 = Resource.Drawable.osmena5,
                    Location = "DALAGUETE, CEBU",
                    JumpOff ="Mantalongon Market, Dalaguete, Cebu",
                    Description ="LLA: 09� 49.209 N, 123� 26.541 E, 1013 MASL\nDays required: 1 day\nHours to summit: 1-2 hrs\nSpecs: Minor climb, Difficulty: 3/9\nTrail class: 1-2\nFeatures: Dalaguete Hills\n\n",
                    Background ="Osme�a Peak is located in Mantalongon, Dalaguete also known as the \"Vegetable Basket\" of Cebu or \"Little Baguio\" because of the vast vegetable farms in the area. The mountain is actually a series of rugged peaks that have been compared with Chocolate Hills of Bohol because of its interesting formations.\n\nAt 1013 MASL, the mountain is considered the highest peak in the province of Cebu. The peak was named after the Osme�a family, an influential political clan in the province. Osme�a Peak is accessible all year round, the mountain is best to climb in the first months of the year to avoid rain and slippery trails.\nDalaguete town is about 85 kilometers from Cebu City, to get there, one should board a mini bus that goes directly to Mantalongon Market. The bus parks at Caltex gasoline station near Carbon Market. After reaching Mantalongon hikers can take a \"Habal-habal\" to the Market or go directly to the foot of Osmena Peak. The trek to the mountain starts from the Market, a rough barangay road about 1 to 2 hrs hike that leads to the foot of the mountain.\nThe neighboring mountain ranges of Osme�a Peak are mostly pointed and rocky, the very trademark of the area. Some of the mountains don�t have very sharp peaks and, hence, resembles Bohol�s Chocolate Hills. The area is somewhat bare to thinly forest because the locals are farming most of the lands.\n\n",
                    Itinerary = "Dayhike\n\n0600 Assembly, breakfast\n0700 At Caltex, take Dalaguete-bound minibus\n1000 Arrival; Register at Mantalongon Barangay Hall\n1030 Start trek from Market to foot of Osme�a Peak\n1130 Arrival at first water source\n1230 Lunch at Mantalongon Market\n1330 Arrive at foot of Osme�a Peak; set camp/ visit summit\n1430 Start descent\n1545 ETA Mantalongon Market\n1715 ETA Dalaguete junction\n2000 Back to Cebu City",
                    Practicalities ="Transportation\nPublic (1) via Plane ride to Mactan Airport (30 minutes away from Cebu City) (2) take Dalaguete �bound minibus drop off to Mantalongon (P100) (3) take Habal-habal to Mantalongon Market (P200)\n\nRegistration\nTourist Assistance Center in Dalaguete P20\n\nGuides\nAvailable, you can give any amount fair amount\n\nContact Numbers\nRamil Berlandres (Habal-habal driver) � 09298743455\n\nCampsites\nSummit campsite, the caretakes collects P20 per pax and gets the garbages of the visitors\n\nWater sources\nLocated along the trail to the summit\n\nCell phone signal\nPresent in most parts of the trail\n\nRope Segments\nNone\n\nSidetrips\nKawasan Falls in Badian (6 hrs traverse)\n\nAlternate trails\nTraverse to Kawasan Falls\n\nDayhikable\nYes (2.5 hrs up, 1.5 hrs down)\n\nFacilities at jump-off\nSari-sari store\nMantalongon Market\n\nEstimated budget\n800-900 from Cebu City\n\n",
                         Attire = "Dryfit or Shirt\nTrekkin pants or Short\nHiking shoes or Sandals\nCap or bush hat",
                           Ttb = "Backpack 28L capacity\nHiking shoes or sandals\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nPacked lunch\nTrail food\nMess kit (Spoon & fork)\nMulti-tool (swiss knife)\nMap or Compass\nWater or energy drink\ngloves (optional) \n"
                     },

                new Mountain()
                {
                    MtName = "PAMITINAN",
                    Masl = 426,
                    Difficulty = 3,
                    Island = 1,
                    MtImg00 = Resource.Drawable.pamitinan,
                    MtImg01 = Resource.Drawable.pamitinan1,
                    MtImg02 = Resource.Drawable.pamitinan2,
                    MtImg03 = Resource.Drawable.pamitinan3,
                    MtImg04 = Resource.Drawable.pamitinan4,
                    MtImg05 = Resource.Drawable.pamitinan5,
                    Location = "RODRIGUEZ, RIZAL",
                    JumpOff ="Brgy. Wawa, Rodriguez,Rizal",
                    Description ="LLA: 14�43�51.7 N, 121�11�29.2 E, 426 MASL\nDays required: 1 day\nHours to summit: 1.5-3 hrs\nSpecs: Minor climb, Difficulty: 3/9\nTrail class: 1-4\nFeatures: Limestone formations, scenic views of Sierra Madre and Rizal Province\n\n",
                    Background ="Mt. Pamitinan, located in Brgy. Wawa Rodriguez, Rizal, has long been known to outdoor enthusiasts for its beautiful Montalban Gorge and various activities that can be done there: caving in Binacayan Cave and Bat Cave, mountain biking, swimming by Wawa Dam, and rock climbing in the limestone cliffs in Mt. Binacayan. In addition, the place has been recognized as a hiking spot with at least two of its small rocky mountains � Mt. Pamitinan and Mt. Binacayan, offering freshly new trails with close proximity to Metro Manila. Both mountains can be done as half-day hikes and can be combined as a nice twin dayhike adventure.\n\nThe mountain has more established trail that takes roughly 1.5-2 hrs going up. The first part is forested, passing through houses and some attractions such as an ancient balete tree and the rock climbing place. The trails of Pamitinan will lead to a Hapunang Banoi junction and the trail to the summit of the mountain. The summit of Mt. Pamitinan is also rocky and surrounded with many bamboo trunks. Wearing gloves is recommended when climbing in the mountains of Rizal, because of the rocks that form sharp because of the acid rains.\n\n",
                    Itinerary = "Dayhike\n\n0500 Take van from Cubao to Eastwood, Rodriguez, Rizal\n0630 ETA Rodriguez, Rizal; take trike or jeep to brgy. Wawa\n0730 Arrival at Brgy. Wawa. Register at barangay hall/ tourism office\n0800 Start trek up Mt. Pamitinan\n0900 Arrival at Hapunang Banoy junction\n1030 ETA summit/ Lunch\n1200 Start descent\n1400 Back at Brgy. Wawa, Explore the area/ Sidetrips\n1700 Tidy up then take outbound trike\n1930 Back in Manila",
                    Practicalities = "Transportation\nPublic (1) Van, Cubao to Montalban (Eastwood) (P50, 1-1.5 hrs) (2) Then take tricycle or jeepney to Wawa (P7.50-P10 30 mins)\nPrivate (1) Head out to Rodriguez, Rizal via Marikina and San Mateo, then follow the road ro Wawa Dam. There is an entrance of P50 for private vehicles. Parking slots are available in front of the tourism office\n\nRegistration\nLogbook at the Barangay hall\nP2 registration fee\n\nGuides\nAvailable; assigned at the tourism office\nP400 per day (add more for twin dayhikes)\n\nContact Numbers\nEmman (guide) - 09493956589\nOgie (guide) - 09473868778\nRichard Salina (guide) - 09983266559\nJoni � (barangay) - 09295497211\n\nCampsites\nNone, but possible \n\nWater sources\nNone\n\nCell phone signal\nPresent all throughout the hike\n\nRiver crossing\nNone, Wawa River already has hanging bridges in place\n\nRope Segments\nFixed rope before reaching the summit\n\nSidetrips\nCaves: Bat Cave and Binacayan Cave (P55 fee for the cave including headlamp rental)\nRock climbing near the Hapunang Banoy junction\nSwimming by Wawa Dam\n\nAlternate trails\nPossible traverse from Mt. Pamitinan:\nMt. Binacayan and Mt. Hapunang Banoi\n\nDayhikable\nYes (1.5-3 hrs up, 1-2 hrs down)\n\nFacilities at jump-off\nSari-sari stores\nCarinderias\nWash up area\nCottages by Wawa Dam\n\nEstimated budget\n500-700\n\n",
                  Attire = "Dri-fir or Shirt\nTrekking pants or Short\nHiking shoes or Sandals\nCap or bush hat\ngloves",
                       Ttb = "Backpack 28L capacity\nHiking shoes or sandals\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nPacked lunch\nTrail food\nMess kit (Spoon & fork)\nMulti-tool (swiss knife)\nMap or Compass\nWater or energy drink\ngloves (optional) \n"
                   },

                new Mountain()
                {
                    MtName = "PICO DE LORO",
                    Masl = 664,
                    Difficulty = 3,
                    Island = 1,
                    MtImg00 = Resource.Drawable.pico,
                    MtImg01 = Resource.Drawable.pico1,
                    MtImg02 = Resource.Drawable.pico2,
                    MtImg03 = Resource.Drawable.pico3,
                    MtImg04 = Resource.Drawable.pico4,
                    MtImg05 = Resource.Drawable.pico5,
                    Location = "MARAGONDON, CAVITE",
                    JumpOff ="DENR Station, Magnetic Hill, Ternate, Cavite",
                    Description ="LLA: 14� 12.855 N; 120� 38.785 E; 664 MASL\nDays required: 1 day\nHours to summit: 2-5 hrs\nSpecs: Minor climb, Difficulty: 3/9\nTrail class: 1-3\nFeatures: Monolith, forest, scenic view of Cavite\n\n",
                    Background = "History: Centuries ago, Spaniards aboard their galleons to Manila Bay noticed the form of a giant parrots beak, perched in the forested mountains in Cavite. They named it \"Pico De Loro\" � Parrot�s Peak. Today, mountaineers who visit Pico De Loro discover that it is as enchanting as its name. High on Cavite�s highest point, they could behold the rocky tower that the Spanish sailors once saw as the parrot�s beak, and they could gaze towards South China Sea where the galleons once sailed, all the way to the historic island fort of Corregidor. Gusts of sea breeze reach the peak, refreshing hikers after a four-hour climb. The peak�s rocky outcropping is dramatic, and sharply contrasts with the plains of Cavite and the waters of South China Sea.\n\nHikers choose this also as the most popular mountain to hike near Manila. Pico De Loro is located on a DENR Protected Area. Which is also the location of different kinds of destination like Puerto Azul and Caylabne and also the famous Kaybiang tunnel. Readily accessible by bus from Coastal Mall, that�s why it is a perfect weekend getaway. Even during the dry season, its forests protect hikers from the sun. Sometimes hikers can even chance upon exotic birds and monkeys along the trail.\nThe trail now is made by the DENR which they proposed that hikers can walk through the mountain in just 2 hrs compared to the old trail that is now closed for rehabilitation of the forest. The summit campsite is surrounded by bamboos and some nice trees. There is also a part of the campsite that is part of a ridge that overlooks the summit.From the summit, there is an opportunity to scale the Parrot�s Beak � more popularly known as the �Monolith� which is the centerpiece of the views at the top. This is a 5-10 minute descent-then-ascent, then a brief scramble that can be quite dangerous.\nThe mountain has also traverse trails, the option to go down via Nasugbu, Batangas or go back to Ternate Highway, which cuts the trail for 30-60 minutes. Pico De Loro is one of the best dayhikes for outdoor activities.\n\n",
                    Itinerary = "Dayhike\n\n0400 Board bus at Coastal Mall Terminal to Ternate (P82)\n0700 ETA Ternate. Rent jeepney or tricycle to jump-off\n0745 ETA DENR, jump-off point. (P25 registration) \n0800 Start trek\n0945 Reach highest point of the New Trail\n1000 Arrival at junction with Old Trail\n1030 ETA campsite\n1100 ETA summit, Lunch\n\nFrom this point, take either Option A (Backtrail) or B (Traverse)\n\nOption A: Backtrail to Ternate\n1230 Start descent to Magnetic Hill\n1430 Back at DENR; take jeep/ trike to Ternate then take bus back to Manila\n1900 ETA Manila\n\nOption B: Traverse to Nasugbu\n1230 Start descent to Nasugbu-Ternate Highway\n1530 ETA Nasugbu-Ternate Highway\n1700 Arrival in Nasugbu; Dinner, Bus terminal is near Jolibee\n2100 ETA Manila",
                    Practicalities = "Transportation\nPublic (1) Bus, Coastal Mall to Ternate terminal (P82 1.5 hrs) (2) Tricycle or rent a jeep, Ternate terminal to DENR trailhead (P250 way for tricycle)\n\nPrivate take CAVITEX or Aguinaldo Highway all the way to Naic, Cavite. Then follow the way to Naic, then follow the signs to Puerto Azul, go past the resort, and park at the DENR Outpost you can see on the lest parking space is available at the outpost.\n\nRegistration\nLogbook at DENR; P25\n\nGuides\nAvailable but not required\n\nContact Numbers\nJeep Rental � 09175956140\n\nCampsites\nAt the base of the summit\n\nWater sources\n(1) At the brook during the initial part of New Trail\n(2) At view deck near campsite (weak) \n\nCell phone signal\nNo signal in DENR and forested area, Present in the campsite and summit\n\nRope Segments\nAt the the Monolith\n\nSidetrips\nNasugbu beach for those traversing (Puerto Azul, Caylabne or Hamilo Coast); those going in the regular trail can explore Maragondon for Mt. Buntis and Nagpatong.\n\nAlternate trails\nThere are trails going to Mt. Marami\n\nDayhikable\nYes (3-4 hours to summit; 2 hours down for both regular and traverse routes)\n\nFacilities at jump-off\nSari-sari store\nWash up places\nParking\n\nEstimated budget\n700-800\n\n",
                   Attire = "Dryfit or Shirt\nTrekkin pants or Short\nHiking shoes or Sandals\nCap or bush hat",
             Ttb = "Dayhike\n\nBackpack 28L capacity\nHiking shoes or sandals\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nPacked lunch\nTrail food\nMess kit (Spoon & fork)\nMulti-tool (swiss knife)\nMap or Compass\nWater or energy drink\ngloves (optional) \n\nOvernight\n\nBackpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n",
                      Vid = "https://ia801507.us.archive.org/6/items/Vpico_201701/Vpico.mp4"
                },
             
                new Mountain()
                {
                    MtName = "PULAG",
                    Masl = 2922,
                    Difficulty = 3,
                    Island = 1,
                    MtImg00 = Resource.Drawable.pulag,
                    MtImg01 = Resource.Drawable.pulag1,
                    MtImg02 = Resource.Drawable.pulag2,
                    MtImg03 = Resource.Drawable.pulag3,
                    MtImg04 = Resource.Drawable.pulag4,
                    Location = "BOKOD, BENGUET",
                    JumpOff ="Ambangeg Ranger Stn. Bokod, Benguet",
                    Description ="LLA: 16�34�58 N, 120�53�15 E, 2922 MASL\nDays required: 1-2 days\nHours to summit: 4-5 hrs\nSpecs: Minor climb, Difficulty: 3/9\nTrail class: 1-2\nFeatures: Sea of clouds, dwarf bamboo slopes, pine forest\n\n",
                    Background = "Mt. Pulag (2922 MASL), the highest mountain in Luzon where hikers usually go during summer and experience the climate in the northern part of the country. The mountain is called \"The Playground of the Gods\" because of its breathtaking wide dwarf bamboo slopes along with the famous �Sea of Clouds� that can be seen during the sunrise or sunset. The sea of clouds of the mountain is the center of the attraction of Pulag because of many pictures scattered in the internet, and because of that the mountain has too many impacts of visitors and hikers during the summer.\n\nThe Ambangeg trail is the proposed trail for the beginners that requires a long walk that is why it is minor climb suitable for beginners even though the mountain is the highest point of Luzon. The Ambangeg trail is wide and surrounded by pine trees and beautiful landscapes can be seen during the first part. The next part of the trail is in the middle of a mossy forest and Camp 1 is marked by a hut. The trail is very relaxing and enjoyable, with cool weather and encounter some various faces of the mountain.\n\n",
                    Itinerary = "Day 0\n\n2300 Take bus to Baguio City\n\nDay 1\n\n0500 ETA Baguio City, Breakfast then proceed to rented jeepney\n0700 Take rented jeepney to Ambangeg\n1000 ETA Visitors� Center, Registration/ Orientation\n1130 Set out for Ranger Station\n1230 ETA and lunch at Ranger\n1300 Start trek\n1430 ETA Camp 1\n1600 ETA Camp 2, Set up camp\n1800 Dinner at campsite; socials\n\nDay 2\n\n0430 Early morning trek to summit for sunrise\n0545 Arrival at summit just in time for sunrise\n0700 Start descent from summit\n0800 Back at Camp 2; heavy breakfast\n0900 Break camp; start descent to Ranger Station\n1130 Back at Ranger; Settle guide fees; jeepney descent\n1230 Back at Visitors� Center; tidy up and log out\n1400 Head back to Baguio City\n1700 ETA Baguio City, Dinner\n1900 Head back to Manila\n0200 Back in Manila",
                    Practicalities = "Transportation\nPublic (1) Bus, from Manila to Baguio City (P500 6-7 hrs) (2) Rented jeep to Ranger Station (3-4 hrs)\n\nRegistration\nMandatory orientation and registration at the Visitor�s Center, P255 per pax\nAs of December 2015 Medical Certificates are required\n\nGuides\nGuides are available at the Ranger Station, 1:5 P500 per guide\n\nContact Numbers\nMereng (DENR-PASU) � 09196315402\n\nCampsites\nCamp 1, Grassland Campsite (Camp2), and Saddle Campsite (Camp 3)\n\nWater sources\n100m from Camp 2 along the trail\n\nCell phone signal\nPresent in some parts of the trail\n\nRiver crossing\nNone\n\nRope Segments\nNone\n\nSidetrips\nBaguio City, other Cordillera peaks and the Four Lakes \n\nAlternate trails\nAkiki Trail\nTawangan Trail\nAmbaguio Trail\n\nDayhikable\nYes (3-5 hrs to summit, 2-3 hrs down)\n\nFacilities at jump-off\nSari-sari stores\nCarinderias\nWash up area\n\nEstimated budget\n2000-3000 for DIYs\n4000 � for Guided groups\n\n",
                 Attire = "Jacket, Windbreaker or Shirt\nTrekking Pants\nHiking Shoes\nCap or bush hat",
            Ttb = "Dayhike\n\nBackpack 28L capacity\nHiking shoes or sandals\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nPacked lunch\nTrail food\nMess kit (Spoon & fork)\nMulti-tool (swiss knife)\nMap or Compass\nWater or energy drink\ngloves (optional) \n\nOvernight\n\nBackpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"
   },

                new Mountain()
                {
                    MtName = "ROMELO",
                    Masl = 300,
                    Difficulty = 3,
                    Island = 1,
                    MtImg00 = Resource.Drawable.romelo,
                    MtImg01 = Resource.Drawable.romelo1,
                    MtImg02 = Resource.Drawable.romelo2,
                    MtImg03 = Resource.Drawable.romelo3,
                    MtImg04 = Resource.Drawable.romelo4,
                    MtImg05 = Resource.Drawable.romelo5,
                    Location = "SINILOAN, LAGUNA",
                    JumpOff ="Brgy. Macatad, Upland Siniloan",
                    Description ="LLA: 300 MASL\nDays required: 1 day\nHours to summit: 2-3 hrs\nSpecs: Minor climb, Difficulty: 3/9\nTrail class: 2 with River crossing\nFeatures: Waterfalls, rain forest, river crossing\n\n",
                    Background ="Mt. Romelo is popular for its beautiful waterfalls that can be explored during the hike while the summit is often ignore by the hikers because their attention is in the waterfalls. The mountain is located at the southwest border of the Sierra Madre mountain ranges, Mt. Romelo used to be called \"Famy\" because of some mistakes that got perpetuated by the hikers. The trails are easy and often times very muddy during rainy days. The hike will take them 2 hrs to arrive at the campsite where the exploration of 7 waterfalls can be started. The waterfalls can be located by following the flow of the river path.\n\nFirst below the campsite \"Buruwisan falls\" can be heard because of the strong waterfalls that is from the river located in the middle of the campsite. It is accessible by going down the steep trail provided by the locals who created the trail. Buruwisan falls is a wide, clear catch basin, veiling an enclave verdant with moss and ferns. The waterfalls is also ideal for rappelling, and photography because of its beautiful and majestic scenery. Long vines grow beside the falls enabling the hikers to do a vine jump to splash in the water. Buruwisan falls is named after a hardwood variety that used to grow on the banks of Romelo River.\nBatya-batya falls is located upstream and on the other hand Sampaloc falls. Batya-batya can be reach 30 minutes from the campsite with river crossing. Batya-batya falls is a two-level falls that the water there is deeper than the other falls it is around 18 feet below. Many interesting rock formation and natural pools that can be visit in the mountain. Further up is Sampaloc falls, this waterfalls is also a sizeable catch basin that anyone can position themselves below it and relax and meditate.\nMt. Romelo is a nice destination for exploring waterfalls, but those searching for the real challenge of the mountain might be disappointed.\n\n",
                    Itinerary = "Dayhike\n\n0500 Take bus or van to Brgy. Macatad, Siniloan, Laguna\n0900 ETA jump-off point. Register (P50 per pax) and get optional guides (P100 per day)\n0930 Start trek\n1130 ETA Campsite, Visit Buruwisan falls, Lunch\n1230 Explore Sampaloc falls and Batya-batya falls\n1430 Start descent\n1600 Back at jump-off, Tidy-up.1630 Head back to Manila\n2030 ETA Manila\n\nOvernight\n\nDay 1\n\n0600 Assembly at Raymond Bus Terminal, Sampaloc, Manila\n0630 ETD for Siniloan\n1000 ETA jump-off point; Register (P50 per pax) and get optional guides (P100 per day)\n1030 Start trek\n1230 ETA Campsite; Set up camp, Visit Buruwisan, Lunch\n1230 Explore Batya-Batya falls and Sampaloc falls\n1700 Back at campsite\n1800 Dinner, socials\n\nDay 2\n\n0600 Breakfast\n0700 Rappel down Buruwisan Falls\n0900 Explore Lanzones Falls\n1200 Lunch at campsite; break camp\n1300 Start descent\n1500 ETA jump-off; tidy-up\n1600 Head back to Manila\n2000 ETA Manila",
                    Practicalities = "Transportation\nPublic (1) Take UV express vans bound to Tanay market in Starmall-Shaw terminal (P70) (2) Ride jeepney going to Siniloan (P47) (3) Take tricycle to Brgy. Macatad (Mt. Romelo Jump-off) (P20)\nPrivate from Manila, take East-bound lane of Ortigas Avenue going to Antipolo. Then take the Manila-east route going to Famy, Laguna. From here Jump-off is less than 10 minutes away via Siniloan-Famy-Real-Infanta Road\n\nRegistration\nLogbook at the Sari-sari store jump-off; P50 per pax\n\nGuides\nAvailable P600\n\nContact Numbers\nMr. Peter Pontipedra - 09092861945\n\nCampsites\nBeside the stream and above the Buruwisan falls\n\nWater sources\nAvailable all throughout the trail\n\nCell phone signal\nPresent in some parts of the trail\n\nRope Segments\nNone\n\nSidetrips\nOther falls can be explored when you have plenty of time\nWaterfalls (Lanzones falls, Batya-batya falls, Sampalc falls, Buruwisan falls\n\nAlternate trails\nNone\n\nDayhikable\nYes, 3 falls can only be visited when attempting a dayhike which is the Buruwisan, Sampaloc, and Batya-batya falls.\n\nFacilities at jump-off\nSari-sari store at jump-off\nShower at nearby house\nParking space: P50\n\nEstimated budget\n600-800\n\n",
                  Attire = "Dryfit or Shirt\nTrekkin pants or Short\nHiking shoes or Sandals\nCap or bush hat",
              Ttb = "Dayhike\n\nBackpack 28L capacity\nHiking shoes or sandals\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nPacked lunch\nTrail food\nMess kit (Spoon & fork)\nMulti-tool (swiss knife)\nMap or Compass\nWater or energy drink\ngloves (optional) \n\nOvernight\n\nBackpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"
   },

                new Mountain()
                {
                    MtName = "TAAL VOLCANO",
                    Masl = 311,
                    Difficulty = 2,
                    Island = 1,
                    MtImg00 = Resource.Drawable.taal,
                    MtImg01 = Resource.Drawable.taal1,
                    MtImg02 = Resource.Drawable.taal2,
                    MtImg03 = Resource.Drawable.taal3,
                    MtImg04 = Resource.Drawable.taal4,
                    MtImg05 = Resource.Drawable.taal5,
                    Location = "TALISAY, BATANGAS",
                    JumpOff ="Talisay, Batangas",
                    Description ="LLA: 14�00 N, 120�59.1 E, 311 MASL\nDays required: Half day\nHours to summit: 1 hr\nSpecs: Minor climb, Difficulty: 2/9\nTrail class: 1\nFeatures: Volcanic crater, sulfuric vents\n\n",
                    Background ="Taal Volcano, the smallest active volcano in the world, and also a famous tourist spot that is located in Talisay, Batangas 50 kilometers south of Manila. It is an island within a lake within an island, makes it a unique geological wonder that fascinates thousands of tourist.\n\nThe Taal Volcano can be done in just half a day by renting a boat to cross the Lake to reach the island where tourist and hikers can register and secure their guides for an adventure to the crater. Visitors can also use a horse but they have to pay a P500 fee. The trail starts with a steep and wide walkable path. There are also steam vents that will be encountered, giving off a sulfuric odor, be careful to inhale it. The path is still wide upon reaching the summit. The summit of Taal Volcano is an excellent viewpoint, affording the views of other Batangas mountains and also it�s Lake.\n\n",
                    Itinerary = "Dayhike\n\n0500 ETD Manila to Talisay, Batangas via Lemery (P120)\n0800 ETA Talisay. Arrange for pumpboats/ guides at lakeshore resorts\n0830 Start boatride\n0900 At Volcano island, start trek to summit\n0945 ETA summit, optional descent to Crater Lake\n1030 ETA crater Lake, take a dip\n1115 Back at summit, head back\n1200 Back at jump-off point, take return boat ride\n1300 Back at base hotel or resort, lunch\n1400 Head back to Manila\n1700 ETA Manila",
                    Practicalities = "Transportation\nPublic (1) Bus to Lemery (P120 3 hrs) (2) Boatride to Volcano Island (P1000 30 mins)\n\nRegistration\nP50 registration in the Registration area\n\nGuides\nGuides are mandatory P500 per day\n\nContact Numbers\nTaal Lake Yacht Club that offers package tours to Taal Volcano including boat ride � 09437730192\n\nCampsites\nNot prohibited\n\nWater sources\nNone\n\nCell phone signal\nPresent all throughout the trail to the summit\n\nRiver crossing\nNone\n\nRope Segments\nNone\n\nSidetrips\nTagaytay City\nPicnic grove\n\nAlternate trails\nNone\n\nDayhikable\nYes (1 hr to the summit, 45 mins down)\n\nFacilities at jump-off\nSari-sari store\nSouvenir store\nCarinderias\n\nEstimated budget\n600-800\n\n",
                          Attire = "Dryfit or Shirt\nTrekkin pants or Short\nHiking shoes or Sandals\nCap or bush hat",
                       Ttb = "Backpack 28L capacity\nHiking shoes or sandals\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nPacked lunch\nTrail food\nMess kit (Spoon & fork)\nMulti-tool (swiss knife)\nMap or Compass\nWater or energy drink\ngloves (optional) \n"
                   },

                new Mountain()
                {
                    MtName = "TALAMITAM",
                    Masl = 630,
                    Difficulty = 3,
                    Island = 1,
                    MtImg00 = Resource.Drawable.talamitam,
                    MtImg01 = Resource.Drawable.talamitam1,
                    MtImg02 = Resource.Drawable.talamitam2,
                    MtImg03 = Resource.Drawable.talamitam3,
                    MtImg04 = Resource.Drawable.talamitam4,
                    Location = "NASUGBU, BATANGAS",
                    JumpOff ="Sitio Bayabasan, Brgy. Aga, Nasugbu (KM. 83)",
                    Description ="LLA: 14.1158� N, 120.757� N, 630 MASL\nDays required: 1 day\nHours to summit: 1.5-2 hrs\nSpecs: Minor climb, Difficulty: 3/9\nTrail class: 3 with steep assault\nFeatures: Grasssland slopes, views of Batangas\n\n",
                    Background = "The Mountain is located in Nasugbu, Batangas and it is near Mt. Batulao, hikers also choose to hike Mt. Talamitam because of its easy and open trails that looks like in the \"Teletubbies kids show\". It is a surprisingly wondrous mountain on its own right, with verdant cogon grass during the rainy season, and a challenging 60� trail before the peak. The name Talamitam came from the talamitam trees that used to grow on its slopes - this is a reminder that the mountain had a lush vegetation and untarnished ecosystems in the past. Today Mt. Talamitam is a bald mountain, but efforts are underway to rehabilitate the peak with tree planting and other initiatives.\n\nThe trail starts at the end of the rough road going down to a river, from here a short woodland hike would connect hikers to a grassland slope that has sparse vegetation. The mountain has many trail variations, most of them leading to the plateau where the peak of Mt. Talamitam sits. The trail is easy hikers can just follow whichever the trail leads until they reach the peak. Ascending the summit takes about 20-30 minutes due to steep and sometimes hot because of the open trails, also the tall grasses that can slow hikers down, especially during the rainy season.\nGoing back takes less than an hour, take note that when descending the mountain the trails may lead you to other villages nearby, and make sure to remember it before hiking. Hiking the mountain can actually take just half of a day, increasingly popular option this is combined hike with Mt. Batulao as Twin Dayhike.\n\n",
                    Itinerary = "Dayhike\n\n0400 ETD Coastal Mall bus terminal to Nasugbu, Batangas (P120.00)\n0700 ETA Registration area at Sitio Bayabasan, Brgy. Aga (KM. 83)\n0730 Start trek\n0930 Arrival at summit\n1030 Start descent\n1200 Back at registration area, head to Tagaytay or Manila\n1300 Lunch at Tagaytay\n1430 Head back to Manila\n1700 ETA Manila",
                    Practicalities = "Transportation\nPublic (1) Bus, Coastal Mall to KM. 83 or Talamitam (P120, 2.5 hrs) isang sakay lang!\nPrivate(1) Head to Tagaytay either via SLEX-ETON Greenfield �Sta. Rosa or via Cavite (2) Follow through the road to Batangas, until you reach KM. 83. Make a right turn at the small side street past the school and look for parking space.\n\nRegistration\nLogbook at Brgy. Aga (P20 per pax)\n\nGuides\nAvailable P300 per day. Hiker are required to get a guide\n\nContact Numbers\nTed Calimag (Brgy. Aga) � 09477118513\nNick Wijangco � 09278248475\nNasugbu Police Station � (043) 931-9952\n\nCampsites\nAt the base of the summit and at the summit itself\n\nWater sources\nNone in normal course of trail except near the trailhead\n\nCell phone signal\nPresent throughout trail\n\nRope Segments\nNone\n\nSidetrips\nNasugbu beaches or Tagaytay city; Twin dayhike with Mt. Batulao\n\nAlternate trails\nThere are new open Traverse trail to Mt. Apayang wich is located beside the mountain itself\n\nDayhikable\nYes (1.5-3 hrs to summit; 1-2 hrs down)\n\nFacilities at jump-off\nSari-sari store\nShower at the Jump-off\nParking space\n\nEstimated budget\n500-600\n\n",
                  Attire = "Dryfit or Shirt\nTrekkin pants or Short\nHiking shoes or Sandals\nCap or bush hat",
            Ttb = "Dayhike\n\nBackpack 28L capacity\nHiking shoes or sandals\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nPacked lunch\nTrail food\nMess kit (Spoon & fork)\nMulti-tool (swiss knife)\nMap or Compass\nWater or energy drink\ngloves (optional) \n\nOvernight\n\nBackpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"
  },

                new Mountain()
                {
                    MtName = "TALOMO",
                    Masl = 2674,
                    Difficulty = 7,
                    Island = 3,
                    MtImg00 = Resource.Drawable.talomo,
                    MtImg01 = Resource.Drawable.talomo1,
                    MtImg02 = Resource.Drawable.talomo2,
                    MtImg03 = Resource.Drawable.talomo3,
                    MtImg04 = Resource.Drawable.talomo4,
                    Location = "CALINAN, DAVAO DEL SUR",
                    JumpOff ="Purok 6, Sitio Utan, Brgy. Tamayong, Calinan",
                    Description ="LLA: 2674 MASL\nDays required: 2-3 days\nHours to summit: 9 hrs\nSpecs: Major climb, Difficulty: 7/9\nTrail class: 2-5\nFeatures: Mossy forest\n\n",
                    Background ="Mt. Talomo is the guardian mountain and volcanic edifice of Mt. Apo, the highest mountain in the Philippines. Due to its prominence, and on its own rights, it is one of the highest mountains in the Philippines.\n\nThe trail is mostly forested, and just like other high mountains in Mindanao, the forest transitions to be of an upper mossy forest variety in the higher elevations. Rivers are encountered, counting as water sources along the trails. The hikers can enable to reach the summit of Mt Talomo in just a whole day o f hiking. The reward of reaching the summit of Mt. Talomo is a splendid view of majestic Mt. Apo.\n\n",
                    Itinerary = "Day 1\n\n0500 From Davao City, take jeep transport to Calinan\n0600 ETA Calinan Public Market, take vehicle to jump-off\n0640 ETA jump-off (Purok 6,Tamayong)\n0700 Start Trek\n0800 ETA Mt. Sicao, register at Datu Sicao\n0900 Resume Trek\n1200 lunch at river\n1730 ETA summit of Mt. Talomo\n1800 Dinner, Socials\n\nDay 2\n\n0500 Wakeup call\n0600 Sunrise view, Breakfast\n0800 Break camp\n0830 Start descent\n1200 Lunch on trail\n1600 ETA Sitio Utan, Tamayong\n1700 Take jeep back to Davao",
                    Practicalities = "Transportation\nPublic (1) Jeep, Davao to Calilan Public Market (2) take vehicle to jump-off\n\nRegistration\n(1) Register at Datu Sicao P50\n\nGuides\nAvailable P250 per day\n\nContact Numbers\nThere are no contacts yet\n\nCampsites\n(1) Summit Camp\n\nWater sources\nAvailable in the middle part of the trail\n\nCell phone signal\nPresent at the summit and some parts of the trail\n\nRiver crossing\nThe first part of the trail\n\nRope Segments\nNone\n\nSidetrips\nSouthern Mindanao Mountains: Mt. Apo\n\nAlternate trails\nNone\n\nDayhikable\nNo\n\nFacilities at jump-off\nSari- sari store\nWash up area\n\nEstimated budget\n1500-1800\n\n",
                  Attire = "Jacket, Windbreaker or Shirt\nTrekking Pants\nHiking Shoes\nCap or bush hat",
              Ttb = "Backpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"
       },

                new Mountain()
                {
                    MtName = "TARAK RIDGE",
                    Masl = 1130,
                    Difficulty = 4,
                    Island = 1,
                    MtImg00 = Resource.Drawable.tarak,
                    MtImg01 = Resource.Drawable.tarak1,
                    MtImg02 = Resource.Drawable.tarak2,
                    MtImg03 = Resource.Drawable.tarak3,
                    MtImg04 = Resource.Drawable.tarak4,
                    MtImg05 = Resource.Drawable.tarak5,
                    Location = "MARIVELES, BATAAN",
                    JumpOff ="Brgy. Alas-asin, Mariveles",
                    Description ="LLA: 14�30.357 N, 120�30 E, 1,006 (ridge) 1,130 (peak)\nDays required: 2 days\nHours to summit: 5-6 hrs\nSpecs: Major climb, Difficulty: 4/9\nTrail class: 3\nFeatures: Scenic views of Bataan, Manila Bay, and Corregidor Island\n\n",
                    Background ="Tarak Ridge is one of the major peaks of Mt. Mariveles that has gained much attention, hikers can also scale the very summit of the mountain. The craggy landscape, sharp rocks, and steep location may have given the name Tarak which means cross between �Tabak� (Hunting Knife) and Tarik� (Steep). The scenic views of Bataan can be seen in the ridge as well as Manila Bay, Corregidor Island.\n\nThe first part of the trail involves wide trail and open to sun exposure, which is during summer months the field is burned in kaingin. The middle part is where you will find Papaya River where hikers take deep in the river and use it as their water source. Then the next part involves woodlands, steep trails in which you can hold on to branches and roots for support. After several minutes, you�ll find yourself in Tarak Ridge. There you can set camp and by next morning you can assault to the summit. Gusts of wind, coming from the South China Sea, pounds hard on the Ridge, requiring extra pegs for tents at night.\n\n",
                    Itinerary = "Day 1\n\n0500 Board Genesis or Bataan Express bus lines to Balanga, Bataan (P120)\n0800 ETA Balanga; take mini-bus to Brgy. Alas-asin (P40)\n0930 ETA Alas-asin; register at Brgy. Hall (P20)\n1000 Start trek\n1300 ETA Papaya River; lunch\n1330 Resume trek to woodlands\n1500 ETA Tarak Ridge; set up camp\n1530 Explore the summit (there is a mossy forest there)\n1730 Back at the Ridge; await the sunset; prepare for dinner\n2000 Lights out\n\nDay 2\n\n0600 Breakfast; break camp\n0700 Start descent\n0730 ETA Papaya river\n1000 Back at jump-off point\n1100 ETA Balanga via minibus",
                    Practicalities = "Transportation\nPublic (1) Bus, to Balanga, Bataan (P120 3-3.5 hrs) (2) take Mini-Bus to Brgy. Alas-asin (P40 1.5 hrs)\n\nRegistration\nP40 per pax in the jump-off\n\nGuides\nGuides are not required \n\nContact Numbers\nNone\n\nCampsites\nThe ridge or beside the Papaya River\n\nWater sources\nPapaya River\n\nCell phone signal\nPresent all throughout the hike\n\nRiver crossing\nNone; Papaya River is located beside the trail\n\nRope Segments\nNone\n\nSidetrips\nCorregidor Island (15 minutes from Mariveles)\nMt. Samat\n\nAlternate trails\nNone; but there are other peaks\n\nDayhikable\nNo\n\nFacilities at jump-off\nSari-sari store\nCarinderias\nWash up area\n\nEstimated budget\n1000-1200\n\n",
                       Attire = "Dryfit or Shirt\nTrekkin pants or Short\nHiking shoes or Sandals\nCap or bush hat",
         Ttb = "Dayhike\n\nBackpack 28L capacity\nHiking shoes or sandals\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nPacked lunch\nTrail food\nMess kit (Spoon & fork)\nMulti-tool (swiss knife)\nMap or Compass\nWater or energy drink\ngloves (optional) \n\nOvernight\n\nBackpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"
  },

                new Mountain()
                {
                    MtName = "TAYAK HILL",
                    Masl = 560,
                    Difficulty = 2,
                    Island = 1,
                    MtImg00 = Resource.Drawable.tayak,
                    MtImg01 = Resource.Drawable.tayak1,
                    MtImg02 = Resource.Drawable.tayak2,
                    MtImg03 = Resource.Drawable.tayak3,
                    MtImg04 = Resource.Drawable.tayak4,
                    Location = "RIZAL, LAGUNA",
                    JumpOff ="Brgy. Tala, Rizal",
                    Description ="LLA: 14.0688 N, 121.420 E, 560 MASL\nDays required: Half day\nHours to summit: 1.5 hrs\nSpecs: Minor climb, Difficulty: 2/9\nTrail class: 1\nFeatures: Views of Laguna and Mt. Cristobal\n\n",
                    Background ="Tayak Hill is located in Brgy. Tala, Rizal which is also part of the �Devils Mountain� Mt. Cristobal. Tayak Hill is bordering the town of Rizal and San Pablo City. The name Tayak came from its tayak grasses that envelopes the hill, that�s why it is called Tayak Hill. The peak of the mountain is called �Tilos� or �Parang� by the locals, making it a distinct destination.\n\n",
                    Itinerary = "Dayhike\n\n0500 ETD for San Pablo City via Lucena bus (P112)\n0730 ETA San Pablo; take tricycle to Nagcarlan jeep near Catherdral\n0800 ETD for Rizal via Nagcarlan jeep (P13)\n0830 ETA Rizal Elementary School; begin trek\n0840 ETA Terraza Verde Resort, continue walking\n0920 Reach end of cemented road\n0950 ETA Sitio Sto Ni�o Chapel; turn right\n1010 ETA Tayak Peak. Snacks and photo-ops\n1100 Start descent\n1230 ETA Rizal, Laguna. Proceed to sidetrip\n1700 Back at San Pablo City; dinner then head back to Manila (P112)\n2000 ETA Manila",
                    Practicalities = "Transportation\nPublic (1) Bus bound to Lucena to San Pablo (P112) (2) tricycle to Nagcarlan near Cathedral (3) jeepney from Nagcarlan to Rizal (P13 30 mins)\n\nRegistration\nNone; not required\n\nGuides\nNone; not required\n\nContact Numbers\nNone\n\nCampsites\nNone; not allowed\n\nWater sources\nNone\n\nCell phone signal\nPresent all throughout the trail to the summit\n\nRiver crossing\nNone\n\nRope Segments\nNone\n\nSidetrips\nMt. Cristobal\nSampaloc Lake Park in San Pablo\n\nAlternate trails\nNone\n\nDayhikable\nYes (1.5 hrs to the summit, 1 hr down)\n\nFacilities at jump-off\nSari-sari store\nWash up area\n\nEstimated budget\n400-500\n\n",
                       Attire = "Dryfit or Shirt\nTrekkin pants or Short\nHiking shoes or Sandals\nCap or bush hat",
                           Ttb = "Backpack 28L capacity\nHiking shoes or sandals\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nPacked lunch\nTrail food\nMess kit (Spoon & fork)\nMulti-tool (swiss knife)\nMap or Compass\nWater or energy drink\ngloves (optional) \n"
                  },

                 

                new Mountain()
                {
                    MtName = "TRES MARIAS",
                    Masl = 1315,
                    Difficulty = 5,
                    Island = 2,
                    MtImg00 = Resource.Drawable.tresmarias,
                    MtImg01 = Resource.Drawable.tresmarias1,
                    MtImg02 = Resource.Drawable.tresmarias2,
                    MtImg03 = Resource.Drawable.tresmarias3,
                    Location = "ALMERIA, BILIRAN",
                    JumpOff ="Brgy. Sampao, Almeria",
                    Description ="LLA: 1315 MASL\nDays required: 2 days\nHours to summit: 6-7 hrs\nSpecs: Major climb, Difficulty: 5/9\nTrail class: 2-4\nFeatures: Waterfalls, stream crossing, mossy forest\n\n",
                    Background ="Mt. Tres Marias in Biliran Island, Eastern Visayas is one of the active volcanoes in the Philippines, the mountain is pristine and beautiful, held in myths to be a paradise guarded by snakes and spirits. Endowed with beautiful waterfalls so numerous that locals did not even bother to name each one, and yet-unraveled biodiversity, it is the highest mountain in Biliran island, and counts also as the highest point in the Biliran complex volcano.\n\nThe name \"Tres Marias\" was drawn from the three peaks that forms the mountain. The highest, at 1315 MASL, is an emerging hiking destination in the Leyte-Samar area. Possibly, Tres Marias is also the second highest mountain in Region VIII, next to the Alto Peak in Ormoc, Leyte.\n\n",
                    Itinerary = "Day 1\n\n0520 ETA Tacloban from Manila\n0600 Head to Tacloban to Almeria\n0900 Buy supplies at Naval, Biliran\n1000 ETA Brgy. Sampao, Almeria, Register\n1030 Start trek\n1230 ETA Ulan-Ulan Falls, Lunch\n1400 Resume trekking\n1800 Arrival at Aeta Campsite\n\nDay 2\n\n0500 Wakeup call/ Light breakfast\n0530 Commence summit assault\n0715 ETA Mt. Tres Marias summit (1315 MASL)\n0800 Start descent\n0914 Back at Aeta campsite, Brunch\n1000 Start descent\n1400 Back at jump-off\n1430 Head back to Masongsong Pool or Mainit Hot Springs\n1800 Head back to Leyte\n2130 ETA Tacloban City",
                    Practicalities = "Transportation\nPublic (1) From Cebu ferry to Ormoc (2) take jeep to Naval (3) jeep to Almeria (4) then tricycle to the jump-off point\n\nRegistration\nLogbook at Brgy. Sampao\n\nGuides\nAvailable, contact first the guide to set things up\n\nContact Numbers\nRene Galleros (Guide) - 09106989517\n\nCampsites\n(1) Aeta Campsite\n\nWater sources\nThere are streams before the trail up to Mt. Tres Marias\n\nCell phone signal\nPresent in some parts of the trail\n\nRope Segments\nNone\n\nSidetrips\nSan Juanico Bridge\nOther falls of Mt. Tres Marias\n\nAlternate trails\nNone\n\nDayhikable\nNo\n\nFacilities at jump-off\nSari-sari store\nBarangay hall\n\nEstimated budget\n900-1000 from Tacloban\n\n",
               Attire = "Dryfit or Shirt\nTrekkin pants or Short\nHiking shoes or Sandals\nCap or bush hat",
       Ttb = "Backpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"
         },

                new Mountain()
                {
                    MtName = "ULAP",
                    Masl = 1846,
                    Difficulty = 3,
                    Island = 1,
                    MtImg00 = Resource.Drawable.ulap,
                    MtImg01 = Resource.Drawable.ulap1,
                    MtImg02 = Resource.Drawable.ulap2,
                    MtImg03 = Resource.Drawable.ulap3,
                    MtImg04 = Resource.Drawable.ulap4,
                    MtImg05 = Resource.Drawable.ulap5,
                    Location = "ITOGON, BENGUET",
                    JumpOff = "Brgy. Ampucao, Itogon",
                    Description ="LLA: 16.2904 N, 120.6312 E, 1846 MASL\nDays required: 1 day\nHours to summit: 2-3 hrs\nSpecs: Minor climb, Difficulty: 3/9\nTrail class: 1-3\nFeatures: Grassland and pine ridges, scenic views of the Cordilleras, burial caves\n\n",
                    Background ="Mt. Ulap offers the view of what the northern ambiance is. It showcases the Cordilleras has to offer: Pine trees and grassland ridges with stunning views of the neighboring mountains in Cordillera, and even a glimpse of culture with villages, burial caves, and hanging bridges along the hike. Mt. Ulap Eco-Trail in Itogon is perfect for a dayhike from Baguio city, only 40 minutes away from the city by riding a public jeepney that will depart early in the morning. The hike measures about 8 kilometers through several peaks along the Ampucao-Sta. Fe Ridge, It is easy enough and possible that the hike can be completed in 4-6 hrs or less than, making it feasible as a dayhike or even a half-dayhike for hikers of all levels.\n\nHikers always need to register first before starting the hike, they required to detour on the barangay to register and secure guides because guides are required. The trailhead starts along from the road to Philex. The trail goes upa a ridge line that is immediately surrounded by pine trees, and soon becaome scenic with views of Mt. Sto. Tomas and Baguio City; even Mt. Arayat from Pampanga can be seen in the hike when the weather is permits.\nSo many attractions and new to the hikers who only visited the place very solemn, because of that Mt. Ulap also became popular because of the pictures circulating in the internet. The mountain trails are created by the trail runners, and then opening up as a hiking destination for hikers.\n\n",
                    Itinerary = "Dayhike\n\n0000 Take bus from Manila to Baguio\n0600 Take jeepney from Baguio to Brgy. Ampucao (P50)\n0640 ETA Brgy. Ampucao. Head to barangay hall. Register/ Secure guides\n0700 Start trek\n0930 ETA Gungal Rock\n1030 ETA Mt. Ulap summit\n1130 Visit Burial Caves\n1300 Arrival at Sta. Fe exit point. Wait for jeepney back to Baguio\n1400 Back in Baguio City (and then to Manila)",
                    Practicalities = "Transportation\nPublic (1) Bus, Cubao or Pasay to Baguio (P500-P750; 4-6 hrs) (2) Jeepney, Baguio City to Brgy. Ampucao via Philes-Bound route (P50; 40 mins) Approximately 40 minutes travel time from Baguio City\n\nRegistration\nLogbook at the Igbaras police station P100 per pax\n\nGuides\nAvailable and required P300/ day\n\nContact Numbers\nBrgy. Ampucao Tourism � 0998-9589549\n\nCampsites\nAmbunao Paoay campsite\n\nWater sources\nNot available during the hike\n\nCell phone signal\nPresent in most parts of the trails\n\nRope Segments\nNone\n\nSidetrips\nBaguio City or other dayhikes Mt. Timbak and Mt. Sto Tomas\n\nAlternate trails\nNone\n\nDayhikable\nYes (4-6 hrs for the entire traverse)\n\nFacilities at jump-off\nSari-sari stores\nRestrooms\nParking\n\nEstimated budget\n1200-1500 from Manila\n300-400 from Baguio\n\n",
                Attire = "Jacket, Windbreaker or Shirt\nTrekking Pants\nHiking Shoes\nCap or bush hat",
               Ttb = "Dayhike\n\nBackpack 28L capacity\nHiking shoes or sandals\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nPacked lunch\nTrail food\nMess kit (Spoon & fork)\nMulti-tool (swiss knife)\nMap or Compass\nWater or energy drink\ngloves (optional) \n\nOvernight\n\nBackpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"
   },

                new Mountain()
                {
                    MtName = "VICTORIA",
                    Masl = 1726,
                    Difficulty = 7,
                    Island = 2,
                    MtImg00 = Resource.Drawable.victoria,
                    MtImg01 = Resource.Drawable.victoria1,
                    MtImg02 = Resource.Drawable.victoria2,
                    MtImg03 = Resource.Drawable.victoria3,
                    Location = "NARRA, PALAWAN",
                    JumpOff ="Sitio Mariwara, Brgy. Princess Urduja, Narra ",
                    Description ="LLA: 1726 MASL\nDays required: 2-3 days\nHours to summit: 9-11 hrs\nSpecs: Major climb, Difficulty: 7/9\nTrail class: 2-4 with ri ver crossings\nFeatures: River crossings, tropical and forests, rare pitcher plants\n\n",
                    Background ="Mt. Victoria is an unexplored and wild destination for hikers who seeks adventure, with its unbelievable array of flora and fauna just starting to be discovered. In this mountain a \"spectacular\" rat-eating pitcher plant was discovered creating a global sensation for scientists and media alike. It has since been named Nepenthes attenboroughii and is just one of the species that are beginning to be unraveled in this mountain paradise. Plus this mountain is home to the native Tagbanua tribe.\n\nThe terrain of Mt. Victoria is diverse, exciting, and therefore a treat to the hikers. To start with, a biodiversity of its magnitude can only be nourished by an abundance of water. Hence the numerous water forms in Mt. Victoria: streams, waterfalls, and even lagoons. You can only imagine the unexplored species lurking in these hidden lakes. For their part, mountaineers have to cross these streams and falls, Indeed \"80% of the trail involves crossing major and minor rivers\". Other destinations waiting to be explored include Atong Peak, and Sultan Peak, and countless other nameless peaks of the Victoria Range.\nThe ascent to the summit of Mt. Victoria is challenging, a minimum of four days is required to do the hike. As mentioned, the hike heavily involves river crossings and the trails are mostly steep, and would oftentimes involve bouldering. Aside from the biodiversity and the tribes; the summit shows the views of South China Sea and Sulu Sea, the neighboring peaks and mountains.\n",
                    Itinerary = "Day 0\n\n1300 From San Jose Terminal, take shuttle van to Narra, Palawan\n1500 ETA Narra, Palawan. Check in at lodge/inn along national highway\n1600 Register with tourism office/ police station of Narra, Palawan\n1800 Dinner / briefing\nNote: One can opt to arrive earlier in Day 0 and visit Estrella Falls.\n\nDay 1\n\n0500 Breakfast\n0600 Take tricycle to jump-off point at Sitio Mariwara, Bgry. Princess Urduja\n0700 Start trek and crossings of Buhawi River\n1200 Lunch at Huling Sapa (i.e. the last river crossing)\n1300 Resume trek\n1600 Arrival at Mt. Victoria Campsite (water source nearby)/ Set up camp\n1800 Dinner / socials\n\nDay 2\n\n0500 Wakeup call\n0600 Start summit assault\n0800 Arrival at summit of Mt. Victoria (1726m)\n0900 Start descent\n1030 Back at High Camp/ Break camp\n1200 Lunch\n1300 Trek down\n1600 Arrival at Camp 1 )/ Set up camp\n1800 Dinner/ socials\n\nDay 3\n\n0600 Wakeup call\n0700 Breakfast/ break camp\n0800 Start trek/ River crossing\n1200 Back at trailhead in Sitio Mariwara. Take trike back to town\n1300 ETA Narra, Palawan/ Lunch\n1400 Take van back to Puerto Princesa\n1630 ETA Puerto Princesa",
                    Practicalities = "Transportation\nPublic (1) Van, San Jose Terminalto Narra, Palawan (P150, 2 hrs) (2) tricycle, rented, Narra Poblacion to Sitio Mariwara, Princess Urduja (P500 per way good for 3-4 pax) approximately 3-4 hrs travel time\n\nRegistration\n(1) Logbook at the tourism office of Narra and/ r barangay hall of Princessa Urduja. No registration fees collected as of November 2014\n\nGuides\nKuya Julius is the main guide for hikes in Narra (P500 per day)\n\nContact Numbers\nJehson (Tourism Office) - 09398826987\nJulius (Lead Guide) - 09099140540\n\nCampsites\nHigh Camp (around 1400 MASL)\nCamp 1 near last river (around 300 MASL)\n\nWater sources\nAbundant in the river crossing part of the trail and present in campsites\n\nCell phone signal\nPresent and campsite peak\n\nRope Segments\nNone\n\nSidetrips\nEstrella Falls near Narra (20 mins away by tricycle)\n\nAlternate trails\nNone\n\nDayhikable\nPossible\n\nFacilities at jump-off\nSari-sari stores\nCarinderias\nWash up places\n\nEstimated budget\n1000-1500 from Palawan\n\n",
               Attire = "Jacket, Windbreaker or Shirt\nTrekking Pants\nHiking Shoes\nCap or bush hat",
             Ttb = "Backpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"
   },

                new Mountain()
                {
                    MtName = "WHITE PEAK",
                    Masl = 2670,
                    Difficulty = 6,
                    Island = 3,
                    MtImg00 = Resource.Drawable.whitepeak,
                    MtImg01 = Resource.Drawable.whitepeak1,
                    MtImg02 = Resource.Drawable.whitepeak2,
                    MtImg03 = Resource.Drawable.whitepeak3,
                    MtImg04 = Resource.Drawable.whitepeak4,
                    Location = "NEW BATAAN, COMPOSTELA VALLEY",
                    JumpOff ="Brgy. Andap, New Bataan",
                    Description ="LLA: 2670 MASL\nDays required: 2-3 days\nHours to summit: 8-10 hrs\nSpecs: Major climb, Difficulty: 6/9\nTrail class: 2-5\nFeatures: Mossy forest, rare species of flora and fauna\n\n",
                    Background ="White Peak on Mt. Pandadagsaan is the highest mountain in Compostela Valley and the 13th highest mountain in the Philippines. The mountain is well known among the hikers of Southern Mindanao, but yet to be discovered by Luzon-based hikers. What sets it apart is the white, almost sparkling appearance of the mountain face as contrasted to the forests surrounding it.\n\nThe trails are mix of mossy forest and steep grassy slopes, these parts are required to bring ropes or need assistance in crossing in these parts. Peak 1 is the forested, while Peak 2 offers a panoramic view of Compostela Valley and Davao provinces.\n\nThe time consumed in reaching the summit can be short as 9-10 hours, but the itinerary given follows more relax paced.\n\n",
                    Itinerary = "Day 0\n\n1100 From Davao Overland Terminal, take Metro Shuttle bus to New Bataan\n1500 ETA New Bataan terminal; proceed to tourism office\n1700 Make final preparations\n1800 Dinner, stay at Poblacion for the night\n\nDay 1\n\n0600 Take jeep to jump-off (Brgy. Andap)\n0800 ETA jump-off; start trek\n200 Lunch on trail\n1500 ETA Pag-abangan (Camp 1) Set up camp\n1800 Dinner, socials\n\nDay 2\n\n0600 Wakeup call\n0800 Resume trek\n1200 Lunch on trail\n1400 Arrival at summit (Camp 2) Set up camp\n1800 Dinner, socials\n\nDay 3\n\n0400 Wake-up call, Preparation\n0600 Start descent\n1200 Lunch\n1400 Back at jump-off\n1500 Back at New Bataan; head back to Davao City",
                    Practicalities = "Transportation\nPublic (1) Bus, from Davao City to New Bataan (2) take habal-habal to the jump-off point\n\nRegistration\nP100 registration fee\n\nGuides\nAvailable, secure guide in the tourism office\n\nContact Numbers\nMa�am Lutie (New Bataan Tourism Office) � 09203604789\nProvincial Tourism Office � (84) 376 0140\n\nCampsites\n(1) Pag-abangan Campsite\n(2) Summit Campsite\n\nWater sources\nNone\n\nCell phone signal\nPresent at the summit\n\nRiver crossing\nYes 30 after the jump-off point\n\nRope Segments\nNone, make sure to bring because of the steep trail before reaching the summit\n\nSidetrips\nSamal Island\n\nAlternate trails\nNone\n\nDayhikable\nNo\n\nFacilities at jump-off\nSari-sari stores\nWash up area\n\nEstimated budget\n1500-2000\n\n",
                 Attire = "Jacket, Windbreaker or Shirt\nTrekking Pants\nHiking Shoes\nCap or bush hat",
            Ttb = "Backpack 40L or 60L capacity\nHiking boots or shoes\nTrashbag\nOutdoor clothes (Dri-fit, Hiking pants)\nFirst Aid kit\nTrail food\nMess kit (Spoon & fork)\nMulti-knife\nTent\nSleeping bag\nPre-cook food\nCook set\nMap or Compass\ntrekking pole\nWater for 2 days or energy drink\n"
  },

            };
    }
}

        
