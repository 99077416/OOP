// See https://aka.ms/new-console-template for more information
using Pokemon_battle3;

Trainer trainer1 = new Trainer("trainer1");
Trainer trainer2 = new Trainer("trainer2");

for  (int i = 1; i < 4; i++)
{
    Charmander charmander = new Charmander($"charmander {i}");
    Squirtle squirtle = new Squirtle($"squirtle {i}");
    Bulbasaur bulbasaur = new Bulbasaur($"bulbasaur {i}");
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


for (int i = 0; i < trainer1.belt.Count(); i++)
{
    Pokemon pokemon = trainer1.Throw(i);
    pokemon.Battlecry();
    //Pokemon pokemon2 = trainer2.Throw(i);
    //pokemon2.Battlecry();

    trainer1.Return(pokemon, i);
    //trainer2.Return(pokemon2, i);
    Console.WriteLine();
}