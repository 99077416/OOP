// See https://aka.ms/new-console-template for more informations
using Pokemon_battle2;


Trainer trainer1 = new Trainer("a");
Trainer trainer2 = new Trainer("b");

for (int i = 0; i < 6; i++)
{
    Charmander charmander = new Charmander($"charmander{i}", "fire", "water");
    Pokeball pokeball = new Pokeball(charmander);
    trainer1.Addball(pokeball);

}
for (int i = 0; i < 6; i++)
{
    Charmander charmander = new Charmander($"charmander{i + 6}", "fire", "water");
    Pokeball pokeball = new Pokeball(charmander);
    trainer2.Addball(pokeball);

}

for (int i = 0; i < 6; i++)
{
    Charmander pokemon = trainer1.Throw(i);
    pokemon.Battlecry();
    Charmander pokemon2 = trainer2.Throw(i);
    pokemon2.Battlecry();

    trainer1.Return(pokemon, i);
    trainer2.Return(pokemon2, i);
    Console.WriteLine();
}