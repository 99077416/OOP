// See https://aka.ms/new-console-template for more information
using Pokemon_battle3;

Trainer trainer1 = new Trainer("trainer1");
Trainer trainer2 = new Trainer("trainer2");

for  (int i = 1; i < 4; i++)
{
    Charmander charmander = new Charmander($"charmander{i}");
    Squirtle squirtle = new Squirtle($"squirtle{i}");
    Bulbasaur bulbasaur = new Bulbasaur($"bulbasaur{i}");
    Pokeball pokeball1 = new Pokeball();
    Pokeball pokeball2 = new Pokeball();
    Pokeball pokeball3 = new Pokeball();
    pokeball1.capturePokemon(charmander);
    pokeball1.capturePokemon(squirtle);
    pokeball1.capturePokemon(bulbasaur);
    trainer1.Addball(pokeball1);
    trainer1.Addball(pokeball2);
    trainer1.Addball(pokeball3);
}

