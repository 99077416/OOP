// See https://aka.ms/new-console-template for more information

using Pokemon_battle4;

Trainer trainer1 = new Trainer("trainer1");
Trainer trainer2 = new Trainer("trainer2");

for (int i = 1; i < 3; i++)
{
    Charmander charmander = new Charmander($"charmander a{i}");
    Squirtle squirtle = new Squirtle($"squirtle a{i}");
    Bulbasaur bulbasaur = new Bulbasaur($"bulbasaur a{i}");
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

for (int i = 1; i < 3; i++)
{
    Charmander charmander = new Charmander($"charmander b{i}");
    Squirtle squirtle = new Squirtle($"squirtle b{i}");
    Bulbasaur bulbasaur = new Bulbasaur($"bulbasaur b{i}");
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

Battle.startBattle(trainer1,trainer2);
