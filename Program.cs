string[] favoriteFood = { "Carbonara", "Sushi", "Pizza", "Cannelloni", "Pasta al forno", "A" };
int len = favoriteFood.Length;

Console.WriteLine($"Length: {len}");

for (int i = 0; i < len; i++)
{
    Console.WriteLine($"{i}: {favoriteFood[i]}");
}

Console.WriteLine($"First Element: {favoriteFood[0]}");
Console.WriteLine($"Last Element: {favoriteFood[len - 1]}");

int middleIdx = len / 2;

if (len % 2 == 0)
{
    Console.WriteLine($"Bonus - Middle Element #1: {favoriteFood[middleIdx]}");
    Console.WriteLine($"Bonus - Middle Element #2: {favoriteFood[middleIdx - 1]}");
}
else
{
    Console.WriteLine($"Bonus - Middle Element: {favoriteFood[middleIdx]}");
}
