/*namespace Learn_UrFU
{
    internal class Benford
    {
        public static int[] GetBenfordStatistics(string text)
        {
            var statistics = new int[10];
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < 10; j++)
                { 
                    if ((text[i] == Convert.ToChar(48+j)) & ((i == 0) || (text[i - 1] == ' ')))
                        statistics[j]++;
                }
            }
            return statistics;
        }

        public static void PrintNumbers(int[] array)
        { 
            int n = 0;
            foreach (int i in array)
                Console.WriteLine(n++ + "   " + i);
            Console.WriteLine();
        }

        public static void Main()
        {
            string tallestBuildings = "Burj Khalifa 830\r\nPetronius (oil platform) 640\r\nTokyo Skytree 634\r\nKVLY-TV mast 629\r\nCanton Tower 604\r\nAbraj Al Bait Towers 601\r\nBullwinkle (oil platform) 529\r\nTroll A platform 472\r\nLualualei VLF transmitter 458\r\nPetronas Twin Towers 452\r\nWillis Tower 442\r\nEkibastuz GRES-Two Power Station 420\r\nDimona Radar Facility 400\r\nKiev TV Tower 385\r\nZhoushan Island Overhead Powerline Tie 370\r\nGerbrandy Tower 367\r\nTV Tower Vinnytsia 354\r\nMillau Viaduct 342\r\nAmazon Tall Tower Observatory 325\r\nLakihegy Tower 314\r\nJinping-I Dam 305\r\nStar Tower 291\r\nH-One Tower 274\r\nDjamaa el Djazaïr 265\r\nMohammed bin Rashid Al Maktoum Solar Park 262\r\nLR 248\r\nGE wind turbine at Naturstromspeicher Gaildorf 247\r\nStatue of Unity 240\r\nNoble Lloyd Noble 214\r\nKalisindh Thermal Power Station 202\r\nGateway Arch 192\r\nMain tower of Kuwait Towers 187\r\nAnaconda Smelter Stack 178\r\nOlympic Stadium 175\r\nSan Jacinto Monument 174\r\nNiederaussem Power Station 172\r\nJeddah Flagpole 171\r\nHigh Roller 168\r\nMole Antonelliana 168\r\nUlmer Münster 162\r\nVehicle Assembly Building 160\r\nSanta Cruz del Valle de los Caídos 152\r\nArecibo Telescope 150\r\nKingda Ka 139\r\nGreat Pyramid of Giza 139\r\nKuala Lumpur International Airport Two Control Tower 141\r\nZumanjaro: Drop of Doom 139\r\nKockums Crane 138\r\nJetavanaramaya 122\r\nGliwice Radio Tower 118\r\nGasometer Oberhausen 118\r\nSchapfen Mill Tower 115\r\nPillar of third section of Gletscherbahn Kaprun 114\r\nJoseph Chamberlain Memorial Clock Tower 100\r\nÉole 96\r\nMjøstårnet 85\r\nEricsson Globe 85\r\nÎle Vierge Lighthouse 83\r\nMurudeshwara Temple 76";
            
            //PrintNumbers(GetBenfordStatistics("1"));
            //PrintNumbers(GetBenfordStatistics("abc"));
            //PrintNumbers(GetBenfordStatistics("123 456 789"));
            //PrintNumbers(GetBenfordStatistics("abc 123 def 456 gf 789 i"));
            PrintNumbers(GetBenfordStatistics(tallestBuildings));
        }
    }
}*/
