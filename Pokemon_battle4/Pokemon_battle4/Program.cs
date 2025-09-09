// See https://aka.ms/new-console-template for more information
using Pokemon_battle4;


//Console.WriteLine("trainer 1 name:");
//string name1 = Console.ReadLine();

//Console.WriteLine("trainer 2 name:");
//string name2 = Console.ReadLine();
string name1 = "a";
string name2 = "B";

Trainer trainer1 = new Trainer(name1);
Trainer trainer2 = new Trainer(name2);

for (int i = 0; i < 2; i++)
{
    Charmander charmander = new Charmander("charmander");
    Squirtle squirtle = new Squirtle("squirtle");
    Bulbasaur bulbasaur = new Bulbasaur("bulbasaur");

    Pokeball pokeball1 = new Pokeball();
    Pokeball pokeball2 = new Pokeball();
    Pokeball pokeball3 = new Pokeball();

    pokeball1.capturePokemon(charmander);
    pokeball2.capturePokemon(squirtle);
    pokeball3.capturePokemon(bulbasaur);

    trainer1.Addball(pokeball1);
    trainer1.Addball(pokeball2);
    trainer1.Addball(pokeball3);
}

for (int i = 0; i < 2; i++)
{
    Charmander charmander = new Charmander("charmander");
    Squirtle squirtle = new Squirtle("squirtle");
    Bulbasaur bulbasaur = new Bulbasaur("bulbasaur");

    Pokeball pokeball1 = new Pokeball();
    Pokeball pokeball2 = new Pokeball();
    Pokeball pokeball3 = new Pokeball();

    pokeball1.capturePokemon(charmander);
    pokeball2.capturePokemon(squirtle);
    pokeball3.capturePokemon(bulbasaur);

    trainer2.Addball(pokeball1);
    trainer2.Addball(pokeball2);
    trainer2.Addball(pokeball3);
}

Arena.CreateBattle(trainer1,trainer2);

Console.WriteLine();
Console.WriteLine(Arena.score1);
Console.WriteLine(Arena.score2);
Console.WriteLine();
Console.WriteLine(Arena.rounds);
Console.WriteLine(Arena.battles);