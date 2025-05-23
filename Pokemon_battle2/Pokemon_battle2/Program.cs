// See https://aka.ms/new-console-template for more informations
using Pokemon_battle2;


Trainer trainer1 = new Trainer("a");
Trainer trainer2 = new Trainer("b");

for (int i = 1; i < 7; i++)
{
    Charmander charmander = new Charmander($"charmander A{i}", "fire", "water");
    Pokeball pokeball = new Pokeball(charmander);
    trainer1.Addball(pokeball);

}
for (int i = 1; i < 7; i++)
{
    Charmander charmander = new Charmander($"charmander B{i}", "fire", "water");
    Pokeball pokeball = new Pokeball(charmander);
    trainer2.Addball(pokeball);

}

for (int i = 0; i < trainer1.belt.Count(); i++)
{
    Charmander pokemon = trainer1.Throw(i);
    pokemon.Battlecry();
    Charmander pokemon2 = trainer2.Throw(i);
    pokemon2.Battlecry();

    trainer1.Return(pokemon, i);
    trainer2.Return(pokemon2, i);
    Console.WriteLine();
}