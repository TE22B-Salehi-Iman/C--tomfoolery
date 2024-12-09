using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

Console.Clear();

while (true)
{
    Console.Clear();
    Console.WriteLine("Welcome to the game Lemmings!");
    Console.WriteLine("=============================");
    Console.WriteLine("|Please choose your option: |");
    Console.WriteLine("|1. Play the game           |");
    Console.WriteLine("|2. Info                    |");
    Console.WriteLine("|3. Quit the game           |");
    Console.WriteLine("=============================");
    Console.Write("Your choice(1-3): ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Methods.Game();
            break;
        case "2":
            Methods.InfoGame();
            break;
        case "3":
            Console.WriteLine("Goodbye! See you later!");
            return;
        default:
            Console.WriteLine("Tf is that answer?");
            break;
    }

}