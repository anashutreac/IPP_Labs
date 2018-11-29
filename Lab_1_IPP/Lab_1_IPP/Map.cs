using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1_IPP
{

    //Singleton Class

    class Location
    {
        private static Location map;
        private List<string> continets = new List<string>();
        private Random randomMap = new Random();

        private static object syncLock = new object();

        protected Location()
        {
            map.Add("Westeros");
            map.Add("Essos");
            map.Add("Sothoryos");
        }
        public static Location GetLocation()
        {
            if (map == null{

                lock (syncLock)
                {
                    if (map == null)
                    {
                        map = new Location();
                    }
                }
            }

            return map;

        }
        public string Continent
        {
            get
            {
                int r = random.Next(continets.Count);
                return continets[r].ToString();
            }
        }

    }
