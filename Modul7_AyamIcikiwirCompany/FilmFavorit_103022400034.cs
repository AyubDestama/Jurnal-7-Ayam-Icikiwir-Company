using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_AyamIcikiwirCompany
{
    class FilmFavorit_103022400034
    {
        public string title {  get; set; }
        public string director { get; set; }
        public string year { get; set; }
        public string genre { get; set; }
        public double rating { get; set; }
        public int durationMinutes { get; set; }
        public bool isWatched { get; set; }
        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("jurnal7_1_103022400034.json");
            var data = JsonSerializer.Deserialize<FilmFavorit_103022400034>(jsonString);
            Console.WriteLine($"Judul : {data.title}\nDirector : {data.director}\nTahun : {data.year}" +
                $"\nGenre : {data.genre}\nRating : {data.rating}\nDurasi : {data.durationMinutes}\nStatus{data.isWatched}");
        }
    }
}
