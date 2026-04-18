using System;
using System.Globalization;
using System.Text.Json;

class FilmFavorit_103022400103()
{
    public string title { get; set; }
    public string director { get; set; }
    public int year { get; set; }
    public string genre { get; set; }
    public int durationMinutes { get; set; }
    public double rating { get; set; }
    public bool isWatched { get; set; }
    public static void ReadJson()
    {
        string jsonString = File.ReadAllText("jurnal7_1_103022400103.json");
        var data = JsonSerializer.Deserialize<FilmFavorit_103022400103>(jsonString);

        Console.WriteLine($"title : {data.title}");
        Console.WriteLine($"director : {data.director}");
        Console.WriteLine($"year : {data.year}");
        Console.WriteLine($"genre : {data.genre}");
        Console.WriteLine($"duration : {data.durationMinutes} minutes");
        Console.WriteLine($"rating : {data.rating}/10");
        Console.WriteLine($"isWatched : {(data.isWatched ? "Yes" : "No")}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        FilmFavorit_103022400103.ReadJson();

    }
}
