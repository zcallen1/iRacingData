using iRacingData;
using System.Text;
using System.Text.Json;
using System.Security.Cryptography;

var CarJson = File.ReadAllText(@"C:\Users\zcall\car.json");
var TrackJson = File.ReadAllText(@"C:\Users\zcall\track.json");
Console.Write("Enter username: ");
string username = Console.ReadLine();
string password = "";
Console.Write("Enter password: ");
ConsoleKeyInfo keyInfo;

do
{
    keyInfo = Console.ReadKey(true);
    // Skip if Backspace or Enter is Pressed
    if (keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter)
    {
        password += keyInfo.KeyChar;
        Console.Write("*");
    }
    else
    {
        if (keyInfo.Key == ConsoleKey.Backspace && password.Length > 0)
        {
            // Remove last charcter if Backspace is Pressed
            password = password.Substring(0, (password.Length - 1));
            Console.Write("\b \b");
        }
    }
}

// Stops Getting Password Once Enter is Pressed
while (keyInfo.Key != ConsoleKey.Enter);
string encodedPassword = FormatAPIPassword(username, password);
var body = new { email = username, password = encodedPassword };
Console.WriteLine();
Console.WriteLine("---------------------------");
Console.WriteLine("Welcome " + username + ",");
Console.WriteLine("Encoded Password is : " + body.password);

var track = JsonSerializer.Deserialize<Track>(TrackJson);
var car = JsonSerializer.Deserialize<Car>(CarJson);

static string FormatAPIPassword(string username, string password)
{
    using var sha256 = SHA256.Create();
    var hashedPasswordAndEmailBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password + username.ToLower()));
    var _encodedPassword = System.Convert.ToBase64String(hashedPasswordAndEmailBytes);
    return _encodedPassword;
}

Console.ReadKey();