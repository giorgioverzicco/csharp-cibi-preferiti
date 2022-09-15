string[] favoriteFood = { "Carbonara", "Sushi", "Pizza", "Cannelloni", "Pasta al forno" };
int len = favoriteFood.Length;

Console.WriteLine($"Length: {len}");

for (int i = 0; i < len; i++)
{
    Console.WriteLine($"{i}: {favoriteFood[i]}");
}

Console.WriteLine($"First Element: {favoriteFood[0]}");
Console.WriteLine($"Last Element: {favoriteFood[len - 1]}");

int middle = (len / 2) % 2 == 0 ? len / 2 : len / 2 - 1;
Console.WriteLine($"Bonus - Middle Element: { favoriteFood[middle]}");