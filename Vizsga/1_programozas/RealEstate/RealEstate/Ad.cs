using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    internal class Ad
    {
        int area;
        Category category;
        DateTime createat;
        string description;
        int floors;
        bool freeofcharge;
        int id;
        string imageurl;
        string latlong;
        int rooms;
        Seller seller;
        public static List<Ad> load(string path)
        {
            List<Ad> ads = new List<Ad>();
            string[] sorok = File.ReadAllLines(path);
            for (int i = 1; i < sorok.Length; i++)
            {
                string[] adatok = sorok[i].Split(";");
                ads.Add(new Ad(
                    int.Parse(adatok[0]),
                    int.Parse(adatok[1]),
                    adatok[2],
                    int.Parse(adatok[3]),
                    int.Parse(adatok[4]),
                    adatok[5],
                    adatok[6] == "1",
                    adatok[7],
                    DateTime.Parse(adatok[8]),
                    new Seller(int.Parse(adatok[9]), adatok[10], adatok[11]),
                    new Category(int.Parse(adatok[12]), adatok[13])
                ));
            }

            return ads;
        }
        public Ad(int id, int rooms, string latlong, int floors, int area, string description, bool freeofcharge, string imageurl, DateTime createat, Seller seller, Category category)
        {
            this.area = area;
            this.category = category;
            this.createat = createat;
            this.description = description;
            this.floors = floors;
            this.freeofcharge = freeofcharge;
            this.id = id;
            this.imageurl = imageurl;
            this.latlong = latlong;
            this.rooms = rooms;
            this.seller = seller;
        }

        public int getFloors()
        {
            return this.floors;
        }
        public int getArea()
        {
            return this.area;
        }
        public string getDetails()
        {
            return area.ToString() + ", " + category.ToString() + ", " + createat.ToString() + ", " + description.ToString() + ", " + floors.ToString() + ", " + freeofcharge.ToString() + ", " + id.ToString() + ", " + imageurl.ToString() + ", " + latlong.ToString() + ", " + rooms.ToString() + ", " + seller.ToString();
        }
        public double distanceTo(string koordinata)
        {
            string[] lonlat = koordinata.Split(",");
            double lon = double.Parse(lonlat[0].Replace('.', ','));
            double lat = double.Parse(lonlat[1].Replace('.', ','));

            string[] ezlonlat = this.latlong.Split(",");
            double ezlon = double.Parse(ezlonlat[0].Replace('.', ','));
            double ezlat = double.Parse(ezlonlat[1].Replace('.', ','));

            return Math.Sqrt(Math.Pow(Math.Abs(ezlat - lat), 2) + Math.Pow(Math.Abs(ezlon - lon), 2));
            
        }
    }
}
