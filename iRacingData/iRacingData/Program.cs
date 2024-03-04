using iRacingData;
using System.Text.Json;

var CarJson = File.ReadAllText(@"C:\Users\zcall\car.json");
var TrackJson = File.ReadAllText(@"C:\Users\zcall\track.json");
Console.WriteLine("Hello, World!");
var track = JsonSerializer.Deserialize<Track>(TrackJson);
var car = JsonSerializer.Deserialize<Car>(CarJson);

Console.ReadKey();