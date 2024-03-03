using iRacingData;
using System.Text.Json;

var JsonResponse = File.ReadAllText(@"C:\Users\zcall\car.json");
Console.WriteLine("Hello, World!");
var car = JsonSerializer.Deserialize<Car>(JsonResponse);

Console.ReadKey();