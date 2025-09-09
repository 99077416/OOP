// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;
using Pokemon_battle3;

Console.WriteLine("trainer 1 name:");
string name1 = Console.ReadLine();

Console.WriteLine("trainer 2 name:");
string name2 = Console.ReadLine();

Trainer trainer1 = new Trainer(name1);
Trainer trainer2 = new Trainer(name2);


for (int i = 1; i < 3; i++)
{
    Charmander charmander = new Charmander($"charmander A{i}");
    Squirtle squirtle = new Squirtle($"squirtle A{i}");
    Bulbasaur bulbasaur = new Bulbasaur($"bulbasaur A{i}");
    Charmander charmander2 = new Charmander($"charmander B{i}");
    Squirtle squirtle2 = new Squirtle($"squirtle B{i}");
    Bulbasaur bulbasaur2 = new Bulbasaur($"bulbasaur B{i}");
    Pokeball pokeball1 = new Pokeball();
    Pokeball pokeball2 = new Pokeball();
    Pokeball pokeball3 = new Pokeball();
    Pokeball pokeball4 = new Pokeball();
    Pokeball pokeball5 = new Pokeball();
    Pokeball pokeball6 = new Pokeball();
    pokeball1.capturePokemon(charmander);
    pokeball2.capturePokemon(squirtle);
    pokeball3.capturePokemon(bulbasaur);
    pokeball4.capturePokemon(charmander2);
    pokeball5.capturePokemon(squirtle2);
    pokeball6.capturePokemon(bulbasaur2);
    trainer1.Addball(pokeball1);
    trainer1.Addball(pokeball2);
    trainer1.Addball(pokeball3);
    trainer2.Addball(pokeball4);
    trainer2.Addball(pokeball5);
    trainer2.Addball(pokeball6);
}

for (int i = 0; i < 6; i++)
{
    Pokemon pokemon = trainer1.Throw(i);
    pokemon.Battlecry();
    Pokemon pokemon2 = trainer2.Throw(i);
    pokemon2.Battlecry();

    trainer1.Return(pokemon, i);
    trainer2.Return(pokemon2, i);
    Console.WriteLine();
}
