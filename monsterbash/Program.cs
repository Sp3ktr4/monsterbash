using System;
using System.IO;

Basha theBasha = new Basha();
Monstros theMonstros = new Monstros();

Console.WriteLine($"{theMonstros.name} has {theMonstros.health} HP");
Console.WriteLine("Attack? (Y = Any key pressed)");

Console.ReadLine();

Console.WriteLine("Attacking...");
theMonstros.health -= 10;
Console.WriteLine("Montros lost 10 HP");
Console.WriteLine("Press any key to shutdown...");

Console.ReadLine();

