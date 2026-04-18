using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_AyamIcikiwirCompany
{
    internal class Watchlist_103022400059
    {
        class Watchlist
        {
            public string Watchlisname { get; set; }
            public string Createdby { get; set; }
            public List<movies> list { get; set; } = new List<movies>();

        }
        class movies
        {
            public string id { get; set; }
            public string title { get; set; }
            public int year { get; set; }
            public string genre { get; set; }
            public double rating { get; set; }
        }
        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("jurnal7_2_103022400059.json");
            Watchlist data = JsonSerializer.Deserialize<Watchlist>(jsonString);
            Console.WriteLine($"ID: {data.Watchlisname} \ntitle: {data.Createdby}");

            for (int i = 0; i < data.list.Count; i++)
            {
                Console.WriteLine($"ID: {data.list[i].id} \ntitle: {data.list[i].title} \n year: {data.list[i].year} \n genre: {data.list[i].genre} \n " +
                $"rating: {data.list[i].rating}");
            }
        }

    }
}
