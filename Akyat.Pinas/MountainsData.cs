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
                MtName = "MANABU PEAK",
                Masl = 760,
                Difficulty = 2,
                MtImg00 = Resource.Drawable.manabu,
                Location = "STO. TOMAS, BATANGAS",
                JumpOff = "Sulok, Brgy. Sta. Cruz, Sto. Tomas",
                Description =
                    "LLA: 13.9777 N, 121.2413 E, 760 MASL\nDays required: 1 day\nHours to summit: 1-2 hrs\nSpecs: Minor climb, Difficulty: 2/9\nTrail class: 1-2\nFeatures: Woodlands, meadow peak, views of Batangas Mountains\n\n",
                Background =
                    "Mt. Manabu is one of the 3 major peaks of Malipunyo mountain ranges in Sto. Tomas, Batangas. The mountain is just 2 hours to climb from the starting point because it is less challenging and it is good for beginner hikers. The highest point is marked with a big white cross. During summer months, wild berries that are called \"sampinit\" grow on the trails near the peak. They are edible and sweet, like mini-strawberries. The mountain is probably the easiest and also the one of the accessible mountains from Manila.\n\n"
                    +
                    "The name Manabu means \"Mataas na Bundok\" said by the locals residing near the mountain. Being one of the 3 major peaks of Malipunyo mountain ranges the other two which is the Malipunyo summit and Susong Dalaga peak are also can be seen from the campsite until the summit of Mt. Manabu. The weather in Mt. Manabu is usually cloudy, lending an almost nostalgic air. The best thing in the mountain is that the Alamid Coffee is free in Mang Pirying's hut. They will offer the hikers to drink Alamid Coffee for free while takinga quick rest and chatting with them. Alamid coffee is made up of Civet cat's droppings which is the digested coffee and also known as the world's most expensive coffee.\n\n",
                Itinerary =
                    "Dayhike\n\n0600 ETD Lucena or Lipa Batangas bound bus at Gil Puyat\n0730 ETA Fiesta Mall, Sto.Tomas Take trycicle to \"Sulok\"\n0830 ETA \"Sulok\", Brgy. Sta. Cruz\n0900 Start Trek\n1000 Reach Mang Pirying's hut\n1100 ETA Summit\n1130 Start decent\n1300 Lunch at Rose and Grace (famous for Bulalo)\n1500 ETD Sto.Tomas bus bacl to Manila\n1700 ETA Manila",

                Practicalities =
                    "Transportation\nPublic (1) Bus, Buendia or Lipa, Batangas (approximately 2 hrs) (2) Take Multi-cab to Fiesta Mall P12 (3) Tricycle, Fiesta Mall to Sulok, Brgy.Sta Cruz (approximately 30 mins) P100 per trip*the tricycle terminal is at Fiesta Mall junction.\nPrivate from Manila go to Tagaytay city and then proceed to Tagaytay-Nasugbu road until Evercrest Golf Course reached.Go past the gate, follow through, turn left at the fork, and then go down the rough road to the trailhead. (Approximately 2.5 hours)\n\nRegistration\nLogbook at the brgy hall.P20 fee per pax\n\nGuides\nAvailable at the brgy.But it is not required (P500 for dayhike, P1250 for overnight camping)\n\nContact Numbers\nMario (Guide) - 09994106990\n\nCampsites\nThe campsite is located before the summit accent.Can fit up to 20 tents\n\nWater sources\nSeveral; available at the rest stops\n\nCell phone signal\nPresent through most parts of the trail\n\nRiver crossing\nSmall stream near the starting point with minimal risk of flooding\nRope Segments\nNone\n\nSidetrips\nHikers usually done a Twin dayhike with Mt.Manabu and Mt.Maculot\n\nAlternate trails\nPossible to do a traverse to or from Mt.Malipunyo\n\nDayhikable\nYes (2.5-4 hrs to summit; 1.5-3 hrs down)\n\nFacilities at jump-off\nSari-sari store\nWash up/ shower places\nParking\n\nEstimated budget\n500-700 (dayhike)\n800-1000 (overnight)\n\n"
            },

            new Mountain()
            {
                MtName = "APO",
                Masl = 2956,
                Difficulty = 7,
                MtImg00 = Resource.Drawable.apo,
                Location = "KIDAPAWAN CITY AND MAGPET, NORTH COTABATO",
                JumpOff = "(Entry point) Brgy. Ilomavis, Kidapawan(Exit point) Brgy. Kisandal, Magpet",
                Description ="LLA: 7�0'30 N, 125�16'33 E, 2,956\nDays required: 3 day\nHours to summit: 10 - 11 hrs\nSpecs: Major climb, Difficulty: 7 / 9\nTrail class: 3\nFeatures: Mossy forest, lake, sulfuric rocks\n\n",
                Background ="Mt. Apo, the highest mountain in the Philippines, towering over Southern Mindanao, covering the provinces of Davao del Sur and North Cotabato. At 2,956 MASL, it possesses a formidable array of landscapes, from craggy rockscapes to virgin forests; from mossy swamps to volcanic structures. Indeed, Mt. Apo possesses the wildest spectrum of environments, and provides an experience for mountaineers that lives up to their expectations from the country�s highest.\n\nThe Kidapawan trail, one of many trails, will take you first to Lake Agko.From there, you will have to cross Marbel river in an unforgettable adventure: you have to cross the river several times by walking through coconut logs without anything to hold for support.Even here, lichens cling on the rocks, and very tall trees rise to the sky.The threat of sudden flashfloods, emphasized by the strong flow of water, will remind the intrepid hiker that he not climbing an ordinary mountain. \n\nAfter three hours of river crossing, you would reach the first campsite, at the Mainit Hot Springs.Here, there is a small pool where you could dip; the water is hot and very soothing.You must reach this campsite before 1500hr, because the next campsite is already Lake Venado, 5-6 hours away.Between the two campsites is a thick forest which you have to cross.Here, two �killer trails� are upcoming: the �87-degree� and the �90-degree� trail.Each taking around 15 minutes, these trails are known to have taken their toll on climbers.As of 2006, ropes are in place in the �90-degrees� to make it a little bit safer.\n\n",
                Itinerary ="(Via Kidapawan-Magpet Trail)\n\nDay 1\n\n0500 Take van from Davao City to Kidapawan\n0730 ETA Kidapawan City; register and secure guides at Tourism Office\n0830 Proceed to Brgy.Ilomavis\n1000 ETA Brgy.Ilomavis, start trek\n1300 ETA Mainit Hot Springs\n1700 ETA Lake Venado (2280 MASL). Set up camp.\n\nDay 2\n\n0400 Early breakfast\n0500 Start summit assault\n0800 ETA summit of Mt.Apo\n1000 Start descent to Lake Venado\n1230 ETA Lake Venado; head to Bobbong campsite\n1800 ETA Bobbong campsite\n1900 Dinner / socials\n\nDay 3\n\n0600 Wake-up call / breakfast\n0800 Start descent to Bongolanon Falls\n1200 ETA Bongolanon Falls; Lunch.\n1300 Return to Kidapawan\n1500 ETA Kidapawan\n1800 ETA Davao City",
                Practicalities ="Transportation Public (1) Via Plane to Davao (2) hire a cab to Gaisano Mall tell the driver to bring you to the van terminal for kidapawan (P150; 3 hrs)\n\nRegistration\nClimb Fee P500 per pax (P750 for foreign nationals P400 for students)\n\nGuides\nAvailable, P800 per day\nPorter: P350 per day\n\nContact Numbers\nKidapawan Tourism Officer, Joey Recimilla - 09399064243\n\nCampsites\nBobbong Campsite\n\nWater sources\nThere are water sources near the campsite\n\nCell phone signal\nCellphone signal is present in the summit and partially in Lake Venado; it is sporadic elsewhere\n\nRope Segments\nRopes are in place in the 90� trail assault after Lake Venado\n\nSidetrips\nDavao City and beaches\n\nAlternate trails\n(1) Kapatagan trail\n(2) Traverse to Mt.Talomo\n(3) Sibulan Trail\n\nDayhikable\nNo\n\nFacilities at jump-off\nSari-sari store\nWash up area\n\nEstimated budget\n1000-1500 from Davao City\n\n"
            },

            new Mountain()
            {
                MtName = "BANOI",
                Masl = 960,
                Difficulty = 3,
                MtImg00 = Resource.Drawable.banoi,
                Location = "LOBO, BATANGAS",
                JumpOff = "Sitio Malabnig, Brgy. Balatbat, Lobo",
                Description =
                    "LLA: 960 MASL\nDays required: 1 day\nHours to summit: 3 - 5 hrs\nSpecs: Minor climb, Difficulty: 3 / 9\nTrail class: 1-3\nFeatures: Woodlands, scenic views of Southern Batangas\n\n",
                Background =
                    "Mt. Banoi is part of the mountain range that surrounds the town of Lobo, which, at 30 kilometers away from Batangas City, which is one of the most distant towns of Batangas province relative to Metro Manila. Before starting the hike, you must register to the Lobo Police Station to notify them that you will hike the mountain.\n\nThe hike starts at the Chapel at the end of the road of Brgy.Balatbat, which is also the beginning of the trail to Sitio Malabnig.The trail is generally straightforward and is not particularly confusing.You can ask locals along the way; there are houses along the way.The trail passes through woodlands.Malabnig Village is the major landmark along the trail, it is actually a community of more than a dozen houses at around 400 MASL, and beyond this lies the trail to the peaks.The first peak, the Front Peak, has an electric post and can serve as a campsite.Then, beyond it and in the same direction lies Two Towers� Peak (850 MASL) which is easily identifiable with its two communications towers.The Main Peak (960 MASL) is the final peak, forested that you can see from the Main Peak.There is a small, cement landmark that can be regarded as the summit marker.Features of the mountain include the beautiful scenes of farm animals, villages, and pastoral activities along the way.Then, at the top, the whole town of Lobo can be seen, and so is Batangas City and Verde Island south of it, as well as the sea lanes.The downside of Mt.Banoi is that its views, while remarkable, are not that spectacular, and the distance (3 hours travel time) may not justify it as a dayhike venue.Yet, it is still a high peak, a worthwhile challenge.\n\n",
                Itinerary = "Dayhike\n\n" +
                            "0400 From Manila, take bus to Batangas City\n" +
                            "0530 Drop off at Balagtas.Take jeep to Lobo Jeepney terminal\n" +
                            "0600 From Lobo Jeepney Terminal, take jeep to Lobo\n" +
                            "0700 ETA Lobo Town Hall.Register at Police Station\nv" +
                            "0730 Take tricycle to \"Malabnig, Brgy.Balatbat\"\n" +
                            "0800 ETA jumpoff, Start trek\n" +
                            "0915 ETA Waiting Shed (Water Source)\n" +
                            "1000 Arrival at Malabnig Village (Last Water Source)\n" +
                            "1100 Arrival at Front Peak (770 MASL)\n" +
                            "1130 Arrival at Two Towers� Peak (850 MASL)\n" +
                            "1200 Arrival at Main Peak (960 MASL)\n" +
                            "1300 Start descent\n" +
                            "1530 Back at Jumpoff\n" +
                            "1700 Last trip Lobo to Batangas City\n" +
                            "1800 ETA Batangas City.Take jeep to Balagtas Junction\n" +
                            "1820 Dinner / Take bus back to Manila\n" +
                            "2100 ETA Manila",
                Practicalities =
                    "Transportation\nPublic (1) Take bus to Balagtas, Batangas City (2) take jeep to Lobo Jeepney Terminal (3) take a jeep to Lobo town hall (4) Tricycle to Malabnig, Brgy.Balatbat\n\nRegistration\nLogbook in Malabnig Village\n\nGuides\nAvailable in Malabnig Village, but not mandatory\n\nContact Numbers\nNoneCampsites\nFront Peak or somewhere near the village\n\nWater sources\nAt the starting point of the trail\n\nCell phone signal\nYes, Available throughout the hike\n\nRope Segments\nNone\n\nSidetrips\nBeaches of Lobo are near in the town proper or climb sidetrips in Lobo Mountains\n\nAlternate trails\nNone\n\nDayhikable\nYes (3-5 hrs ascent, 2-3 hrs down)\n\nFacilities at jump-off\nChurch\nPolice station\nSari-sari store\n\nEstimated budget\n800-900\n\n"
            },

            new Mountain()
            {
                MtName = "BATULAO",
                Masl = 811,
                Difficulty = 4,
                MtImg00 = Resource.Drawable.batulao,
                Location = "NASUGBU, BATANGAS",
                JumpOff = "Evercrest Golf Course, Nasugbu",
                Description ="LLA: 14.0408 N 120.8011 E 811 MASL \nDays required: 1 day(dayhike) 2days(overnight)\nHours to summit: 2 - 4 hrs \nSpecs: Minor climb, Difficulty: 4 / 9 \nTrail class: 3 with 60-70� assault \nFeatures: Open trails, rolling slopes, scenic views of Batangas\n\n",
                Background ="Mt. Batulao is the best place to visit and hike because the mountain is accessible near Manila and Cavite, the transportation to go there is so easy that hikers can commute in just one way trip to the jump-off point. Evercrest is the jump-off point which hikers can ride a P50 tricycle fee to the registration point of Batulao. Beginner hikers can hire a guide to accompany them during their hike on the mountain but guides are not mandatory because the mountain is a minor climb even solo or group hikes can be safe in an open trails of the mountain.\n\nThe weather in Mt.Batulao is a pleasant escape from the city because of the location of the mountain which is near Tagaytay city.The cool weather occurs during the months of January and February even in the rainy seasons.During summer the hikers can feel like they are in the desert because of the hot and humid open trails of the mountain, on the other hand the mountain makes the trail prone to muddiness during the rainy season (June to October). The landscapes of Mt.Batulao are quite remarkable it shows the whole view of its body and the rocky formations of the peaks throughout the hike; and although the view remains basically the same throughout the hike, the rolling slopes, through which trail pass by, and the new variety afforded by two major trails \"Old Trail\" and \"New Trail\", makes Batulao one of the most popular dayhikes or near Manila hikes.\n\n",
                Itinerary ="Old to New Trail \n\n0400 ETD Coastal Mall bus terminal to Nasugbu, Batangas\n0715 Arrival at Evercrest\n0730 Start trek\n0845 Arrival at Fork.Take the left, downward trail that enters the forested area\n0900 Arrival at Camp 1. Register\n1015 Arrival at Camp 8, commence final assault\n1100 Arrival at summit; lunch\n1200 Start descent via New Trail, which is opposite the Old Trail at the summit\n1300 Arrival at New Trail Campsite.Register again.\n1530 Back at Evercrest; clean-up at nearby sari-sari store\n1600 ETD for Tagaytay by jeepney(P30.00)\n1630 ETA Tagaytay; Side trips, Dinner\n1800 ETD Tagaytay city to Coastal Mall Bus Terminal\n\nNew to Old Trail\n\n0400 ETD Coastal Mall bus terminal to Nasugbu, Batangas\n0715 Arrival at Evercrest\n0730 Start trek\n0845 Arrival at Fork. Take the slightly right upward trail\n0930 Arrival at New Trail Campsite. Rest/ Register\n1030 Arrival at summit; early lunch\n1200 Start descent via Old Trail, which is opposite the New Trail at the summit\n1300 Arrival at New Trail Campsite. Register again\n1530 Back at Evercrest; clean-up at nearby sari-sari store\n1600 ETD for Tagaytay by jeepney (P30.00)\n1630 ETA Tagaytay; Side trips, Dinner\n1800 ETD Tagaytay city to Coastal Mall Bus Terminal",
                Practicalities ="Transportation\nPublic (1) Nasugbu-bound bus, Coastal Mall to Evercrest (P104) (2) Optional Tricycle, Evercrest to Registration area (P25 per pax).\nPrivate from Manila go to Tagaytay city and then proceed to Tagaytay-Nasugbu road until Evercrest Golf Course reached. Go past the gate, follow through, turn left at the fork, and then go down the rough road to the trailhead. (Approximately 2.5 hours)\n\nRegistration\nLogbook at the first registration point before starting the hike. Also, Old and New Trail campsites. Total fees per hiker P20 per pax (dayhike); P30 per pax when camping.\n\nGuides\nAvailable (P300-P400/day); not mandatory\n\nContact Numbers\nNew Trail Campsite (Roel) +639279008496\nNasugbu Police Station � (043) 931-9952\n\nCampsites\nNew Trail Campsite\nOld Trail Campsite\n\nWater sources\nAvailable in campsites � ask from caretakers.\n\nCell phone signal\nPresent in most parts of the trail\n\nRope Segments\nFixed rope in steep part of the Old Trail and before reaching the summit from New Trail\n\nSidetrips\nLunch, Dinner at Tagaytay city after the hike, Calaruega Church near the Jump-off point\n\nAlternate trails\nToong trail from New Trail to Mt. Talamitam\n\nDayhikable\nYes (2-3 hrs to summit; 1.5-2 hrs down)\n\nFacilities at jump-off\nSari-sari store, Shower facilities or Ligo for P10 per timba, Parking P50\n\nEstimated budget\n500-900\n\n"

            },

            new Mountain()
            {
                MtName = "GUITING-GUITING",
                Masl = 2058,
                Difficulty = 9,
                MtImg00 = Resource.Drawable.guiting,
                Location = "SIBUYAN ISLAND, ROMBLON",
                JumpOff = "Brgy. Tampayan, Magdiwang, Sibuyan",
                Description ="LLA: 12�24'50 N, 122�32'4'4 E, 2058 MASL\nDays required: 3 days\nHours to summit: 10-13 hrs\nSpecs: Major climb, Difficulty: 9/9\nTrail class: 5 with rock climbing/ scrambling\nFeatures: Rock formations, knife edge\n\n",
                Background ="Mt. Guiting-Guiting, one of the most difficult climbs located in Sibuyan Island, Romblon. The mountain is rated Difficulty: 9/9 because of the steep and jagged ridges of the mountain called \"Knife Edge\" which hikers must cross in order to reach the summit, not to mention the ensuing rock formations with colorful names such as \"Kiss the Wall\". On top of this challenging trail, the weather is so volatile that hikers would use absolute cut-off times to reach the summit, otherwise they would have to turn back. By implication, only hikers with enough stamina are advised to attempt to hike this mountain.\n\nIn May 1982, a combined team of the Philippine Mountaineering Society (PMS) of Bacolod City and UP Mountaineers did the first exploration of the mountain, reaching the then-unnamed Mayo�s Peak but failing to reach the summit.A few weeks later, some of them returned to make the first ascent to Mt.Guiting-Guiting summit.\n\nEven without the accomplishment of getting to the summit of Mt.Guiting-Guiting, a visit to the Sibuyan Island is already amazing and rewarding enough.To begin with, Sibuyan Island is a jewel of the seas. 187 nautical miles from Manila, the 445-sq.km island has beaches, waterfalls, and one of the cleanest rivers in the Philippines.The mountain has been called the most diverse forest in the world being the habitat of up to 54 endemic plant varieties, and home to fascinating endemic flora and fauna.These include four species of rodents and a kind of bat discovered only in the mid-1990s and found nowhere else in the world.\n\nThe climb takes three days to finish, Day 1 is the hike up to Mayo�s Peak (1550 MASL). Three streams will be crossed before reaching Camp 1, and three camps will be passed (Camp 1-3) before reaching Mayo�s Peak.The trails are surrounded by woodlands throughout the hike.Normally, Day 2 is the 4-5 hr ascend to the summit and including back.A fast descent from Mayo�s Peak will lead to the \"Knife Edge\" � here the entire trail is rocky and exposed to the sun and winds; there are ravines on both sides and the view is both breathtaking and scary.After 3-4 hrs, the Peak of Deception, an imposing sight, will be reached.They say this peak was also called \"Peak of Decision\" because from here you will have to decide whether to proceed or not, considering the time and one�s energy, and from here, it�s only 30-45 minutes away from the summit itself.The trails here are unforgiving.After passing this trail, hikers can now reach the summit.At the summit, when it is clear, you can see the neighboring peaks of the Guiting-Guiting range, as well as the seas surrounding Sibuyan Island.\n\nThe third and final day is the descent back to Magdiwang.As you leave Sibuyan Island by ferry, the towering presence of Guiting-Guiting and its saw-toothed peaks will remind you of the unforgettable adventure.\n\n",
                Itinerary ="Day 0\n\n0800 Assembly at Greenstar Liner (Buendia)\n0830 ETD Buendia to Batangas port\n1200 ETA Batangas port secure tickets to Ambulong Port (Magdiwang)\n1700 Take ferry to Magdiwang Port\n\nDay 1\n\n0800 Arrival at Magdiwang (Ambulong Port)\n0815 Proceed to Tourism Council for registration\n0900 Breakfast (magdiwang market)\n1000 Buy supplies\n1100 head to Tansiungco Residence or Sanctuary Lodge\n1200 preparation for the climb (precooking etc)\n2100 lights out\n\nDay 2\n\n0600 Wakeup call (Breakfast)\n0730 Start trek.Brace for exposed area\n1030 ETA Camp 1\n1200 ETA Camp 2 (lunch)\n1400 ETA Camp 3\n1430 ETA Bulod�s spring (Load up last watersource)\n1500 Arrival at Mayo�s Peak (1550 MASL). Rest.\n1700 Sunset Viewing @ Mayo�s Peak\n1900 Dinner\n2000 Lights out\n\nDay 3\n\n0500 Breakfast / prepare packed lunch\n0600 Commence summit assault\n0630 Begin crossing the �Knife Edge�\n0800 Arrival at \"Kiss the Wall\"\n0930 Arrival at Mabel Spring (water not always available)\n1015 ETA Peak of Deception (1959 MASL)\n1100 ETA G2 summit (2057 MASL)\n1200 Head back\n1600 Back at Mayo�s Peak\n1800 Dinner / socials\n\nDay 4\n\n0700 Breakfast\n0800 Break camp\n0900 Start descent\n1400 Back to jump-off\n\nDay 5\n\nHead back to Batangas port\n",
                Practicalities ="Transportation\nPublic (1) Bus, Buendia to Batangas Port (2) any of the following Ferry lines (MBRS Lines, Super Ferry, and Montenegro Lines)\n\nRegistration\nLogbook at Mt.Guiting-Guiting National Park P300 per person � includes climb certificate and tagalog-language booklet\n\nGuides\nP800 per day for Filipinos, P1000 per day for foreigners\nPorters: P600 per day\n\nContact Numbers\nMt.Guiting-Guiting National Park - 09284901038\n\nCampsites\n(1) Camp 1(2) Camp 2(3) Camp 3These camps can be reached before ascending to Mayo�s Peak\n\nWater sources\nThe rivers before Camp 1, very clean and you can take a refreshing dip\n\nCell phone signal\nPresent in the Park Center but sporadic even in the high elevations\n\nRope Segments\nNone\n\nSidetrips\nSibuyan Island beaches\n\nAlternate trails\nNone\n\nDayhikable\nNo\n\nFacilities at jump-off\nGuest houses with restrooms and shower P500 per room\n\nEstimated budget\n5000-6000\n\n"
            },

            new Mountain()
            {
                MtName = "HALCON",
                Masl = 2582,
                Difficulty = 9,
                MtImg00 = Resource.Drawable.halcon,
                Location = "BACO, ORIENTAL MINDORO",
                JumpOff = "Brgy. Lantuyan, Baco",
                Description ="LLA: 13�15.749 N 120�59.703 E, 2582 MASL\nDays required: 3.5 - 4 days\nHours to summit: 15 - 18 hrs\nSpecs: Major climb, Difficulty: 9 / 9\nTrail class: 2-4\nFeatures: River crossings, Mossy forest, rocky ridges\n\n",
                Background ="Mt. Halcon, home of many endemic flora and fauna in the Philippines located in Baco, Oriental Mindoro. The mountain is 2582 MASL in Mindoro Island just south of Luzon. Mt. Halcon is one of the majestic mountains and also the best hiking destination in the Philippines, featuring long and often steep through dense jungle and crystal clear waters from its rivers.\n\nBefore attempting to hike Mt.Halcon, Group hikes are required to be safe and must be oriented or experienced mountaineers.First hikers must secure a permit that they are allowed to hike in the mountain and sending an advance party to get permits on a weekday is like a prudent option rather than going directly to the place.If going there directly, best arrive on weekdays and allow on extra day for contingencies.\n\nDuring rainy season, climbing may have to be aborted when flash floods sets in making the trail crossing rivers unpassable.Another factor that adds up to the difficulty of climbing is the presence of the \"limatik\" on almost 90% of the trail.These small leeches silently clings to your body and makes their way to any exposed skin where they begin sucking your blood.Nature will always be a factor in the success of this climb.\n\n",
                Itinerary ="3 Days Lantuyan or Bayanan trail (Summit Assault)\n\nDay \n\n00600 Assembly at Buendia corner Taft\n0630 ETD Manila to Batangas City\n0930 ETA Batangas Pier, take ferry to Calapan\n1015 ETA Calapan Pier, Hire tricycle to Calapan Market Place\n1030 ETA Calapan Market Place, Ride jeepney bound for Baco\n1130 ETA Baco Municipal Hall, Arrange for permit\n1200 Lunch in Baco/ Buy final supplies\n1400 ETD Baco Municipal Hall to jump-off\n1500 ETA jump-off.Register/ Arrange for guides\n1600 Free Time, Setup Camp, Make Final Preparation\n\nDay 1 (exact landmarks vary depending on choice of trail)\n\n0600 Breakfast / Prepare for the hike\n0700 Start Trek\n1200 Lunch along the jump-off\n1300 Resume Trek\n1700 ETA Aplaya campsite\n1830 Dinner / Prepare for packed lunch the next day\n2000 Light�s Out\n\nDay 2\n\n0300 Wake-up call/ Light snacks\n0400 Start summit assault\n0700 Breakfast/ 15-minute break at Camp 1 or 2\n1000 Arrival at ridgeline\n1100 ETA summit (allow up to 1300H)/ Lunch\n1200 Start descent\n1500 Dulungan River break / swimming\n1800 Back at Aplaya campsite\n1900 Dinner / socials\n\nDay 3 (exact landmarks vary depending on choice of trail)\n\n0600 Breakfast / Break camp\n0800 Start descent\n1200 Lunch along the trail\n1600 Back at the jump-off.End of trek!\n1700 Take tricycle back to Baco then jeep back to Calapan\n1900 ETA Calapan.Dinner\n2100 Take ferry back to Batangas\n2300 ETA Batangas.Take bus back to Manila\n0130 (+1 day) ETA Manila",
                Practicalities = "Transportation\nPublic (1) Bus,Cubao or LRT-Buendia to Batangas Pier (P170,2.5 - 3 hrs) (2) Ferry,Batangas Pier to Calapan,Oriental Mindoro (P180-300,2 - 2.5 hrs) (3) Rented jeepney,Calapan to Baco Municipality and back (P2500-3000 for round trip,40minutes to Baco and 30 mins to the trailhead) Approximately 6-7 hrs time because of various stops and delays\n\nRegistration\n(1) Logbook at the Tourism Office in Baco\n(2) Logbook at the Police Station in Baco\n(3) Logbooks and possible minor fees at the jump-off/ villages\n\nGuides\nAvailable; required; Ratio of 1:7 P500 per day\nPorters: same rate as guides,maximum 15kg\n\nContact Numbers\nHalcon (Jojo � Baco Tourism Office) � 09198821442\n\nCampsites\n(1) Emergency campsites\n(2) Aplaya campsite\n(3) Camp 1\n(4) Camp 2\n(5) Summit camp\n\nWater sources\nAvailable in Aplaya camp,Camp 1 and Camp 2 and some parts of the trail\n\nCell phone signal\nSporadic in Aplaya camp\nAvailable at the summit and in some parts of the trail\n\nRope Segments\nNone but there are parts where ropes might help beginners\n\nSidetrips\nPuerto Galera (one jeepney ride from Calapan)\nOther Mindoro mountains eg.Mt.Malasimbo\n\nAlternate trails\nNone\n\nDayhikable\nNo\n\nFacilities at jump-off\nSari-sari stores\nWash up places\n\nEstimated budget\n1500-2200 per pax for group of 7 (3 days)\n\n"},
            
        };
    }
}

        
