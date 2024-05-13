using NewRandomneSample;
using System.Security.Cryptography;

int[] array = [1, 2, 3, 4, 5];
Random.Shared.Shuffle(array);

foreach (int i in array)
{
    Console.WriteLine(i);
}
Span<Pie> allPies = new[]
{
        new Pie(1, "Strawberry cheesecake", 12.95M),
        new Pie(2, "Apple pie", 17.95M),
        new Pie(3, "Chocolate pie", 18.95M),
        new Pie(4, "Birthday cake", 28.95M)

};
Random.Shared.Shuffle<Pie>(allPies);

foreach (Pie p in allPies)
{
    Console.WriteLine(p.Name);
}
int[] selectedInts = Random.Shared.GetItems(array, 2);

foreach (int i in selectedInts)
{
    Console.WriteLine(i);
}

Pie[] selectedPies = Random.Shared.GetItems(allPies.ToArray(), 20);

foreach (Pie p in selectedPies)
{
    Console.WriteLine(p.Name);
}
var allCharacters = "abcdefghijklmnopqrstuvwxyz0123456789";

var randomString = RandomNumberGenerator.GetString(allCharacters, 20);

Console.WriteLine(randomString);