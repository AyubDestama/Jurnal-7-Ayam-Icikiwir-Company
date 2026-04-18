using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_AyamIcikiwirCompany
{
    class Watchlist_103022400034
    {
        public string watchlistName { get; set; }
        public string createdBy {  get; set; }
        public List <Movie>movies { get; set; }
        public class Movie
        {
            public string title { get; set; }
            public string id { get; set; }
            public string year { get; set; }
            public string genre { get; set; }
            public double rating { get; set; }
        }
        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("jurnal7_2_103022400034.json");
            var data = JsonSerializer.Deserialize<Watchlist_103022400034>(jsonString);
            Console.WriteLine("Watchlist name : " + data.watchlistName);
            Console.WriteLine("Created by : " + data.createdBy);
            Console.WriteLine("Movies : ");
            
            foreach (var item in data.movies)
            {

                Console.WriteLine(item.id+" "+item.title+" ("+item.year+" - "+item.rating+")");

            }
        }
    }
   
}
