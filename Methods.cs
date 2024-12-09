// methods
public class Methods
{
    public static void Game()
    {
        int x = 0;
        int y = 0;

        Console.Clear();

        Console.Write("How many Lemmings do you want?: ");
        int Amount = int.Parse(Console.ReadLine());
        Console.WriteLine($"you have now {Amount} Lemming(s)!");
        while (true)
        {
            Console.WriteLine("What should they do?:");
            Console.WriteLine("=====================");
            Console.WriteLine("1. exploder");
            Console.WriteLine("2. jumper");
            Console.WriteLine("3. digger");
            Console.WriteLine("4. leave game");
            Console.WriteLine($"x-coordinates: {x}");
            Console.WriteLine($"y-coordinates: {y}");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("say what now?");
                    x++;
                    break;
            }
        }
        return;
    }

    public static void InfoGame()
    {
        Console.Clear();
        Console.WriteLine("This is just a diagnostic test");
        Console.WriteLine("There will be no graphical like the original game");
        Console.WriteLine("So everything is just a description :(");
        Console.WriteLine("press enter to return");
        Console.ReadLine();
        return;
    }

    static void Lemming()
    {

    }
}