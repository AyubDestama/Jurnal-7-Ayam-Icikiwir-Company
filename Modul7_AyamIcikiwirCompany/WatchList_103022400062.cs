using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_AyamIcikiwirCompany
{
    internal class WatchList_103022400062
    {
        public string watchlistName { get; set; }
        public string createdBy { get; set; }
        public List<Movie> movies { get; set; }
        public class Movie
        {
            public string title { get; set; }
            public string director { get; set; }
            public int year { get; set; }
            public string genre { get; set; }
            public double rating { get; set; }
        }
        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("jurnal7_2_103022400062.json");
            var data = JsonSerializer.Deserialize<WatchList_103022400062>(jsonString);
            Console.WriteLine("watchlistName " + data.watchlistName);
            Console.WriteLine("createdBy " + data.createdBy);
            Console.WriteLine("Movie :");
            foreach (var item in data.movies)
            {
                Console.WriteLine("title " + item.title);
                Console.WriteLine("director " + item.director);
                Console.WriteLine("year " + item.year);
                Console.WriteLine("genre " + item.genre);
                Console.WriteLine("rating " + item.rating);
            }

        }
    }
}
