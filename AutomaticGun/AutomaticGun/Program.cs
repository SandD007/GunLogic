// See https://aka.ms/new-console-template for more information
using AutomaticGun;

int numberOfBalls = ReadInt(20, "Кiлькiсть патронiв");
int magazineSize = ReadInt(18, "Розмiр магазину");
Console.WriteLine($"магазин [false]: ");
bool.TryParse(Console.ReadLine(), out bool isLoaded);
PaintBallGun gun = new PaintBallGun(numberOfBalls, magazineSize, isLoaded);


while (true)
{
    Console.WriteLine($"Всього {gun.Balls} патронiв, в магазинi {gun.BallsLoaded} патронiв.");
    if (gun.IsEmty())
    {
        Console.WriteLine($"МАГАЗИН ПОРОЖНIЙ!");
    }
    Console.WriteLine($"Пробiл для пострiлу, r для перезарядки, + щоб додати патронiв, q для виходу.");
    char key = Console.ReadKey(true).KeyChar;

    if (key == ' ')
    {
        Console.WriteLine($"Пострiл {gun.Shoot()}");
        Console.Clear();
    }
    if (key == 'r')
    {
        gun.Reload();
        Console.Clear();
    }
    if(key == '+')
    {
        gun.Balls += gun.MagazineSize;
        Console.Clear();
    }
    if(key== 'q')
    {
        return;
    }
}
static int ReadInt(int lastUsedValue, string prompt)
{
    Console.WriteLine(prompt + " " + "[" + lastUsedValue + "]:");
    string answer = Console.ReadLine();
    if (int.TryParse(answer, out int resut))
    {
        Console.WriteLine("   using value " + resut);
        return resut;
    }
    else
    {
        Console.WriteLine("   using value " + lastUsedValue);
        return lastUsedValue;
    }
}
