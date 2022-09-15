string[] favoriteFood = { "Carbonara", "Sushi", "Pizza", "Cannelloni", "Pasta al forno", "A" };
int len = favoriteFood.Length;

Console.WriteLine($"Length: {len}");

for (int i = 0; i < len; i++)
{
    Console.WriteLine($"{i}: {favoriteFood[i]}");
}

Console.WriteLine($"First Element: {favoriteFood[0]}");
Console.WriteLine($"Last Element: {favoriteFood[len - 1]}");

if (len % 2 == 0)
{
    int firstMiddleIdx = len / 2 - 1;
    int secondMiddleIdx = len / 2;
    Console.WriteLine($"Bonus - Middle Element #1: { favoriteFood[firstMiddleIdx]}");
    Console.WriteLine($"Bonus - Middle Element #2: {favoriteFood[secondMiddleIdx]}");
}
else
{
    int middleIdx = len / 2;
    Console.WriteLine($"Bonus - Middle Element: { favoriteFood[middleIdx]}");
}
