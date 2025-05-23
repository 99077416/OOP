// See https://aka.ms/new-console-template for more information

using Pokemon_battle1;

Console.WriteLine("charmander name: ");
string nickname = Console.ReadLine();

Charmander charmander = new Charmander(nickname, "fire", "water");
Charmander charmander2 = new Charmander("klaasje", "grass", "water");
Console.WriteLine(charmander2.name);

while (true)
{
    Console.WriteLine();
    for (int i = 0; i < 10; i++)
    {
        charmander.Battlecry();
    }
    Console.WriteLine();
    Console.WriteLine("new name: ");
    nickname = Console.ReadLine();

    charmander.name = nickname;
}


