using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


public class FallingRocks
{
    static int width = 32;
    static int height = 20;
    static int dwarfHorizontal = width / 2 - 2;
    static int dwarfVertical = height - 1;
    static bool run = true;
    static int rockVertical = 0;
    static int rockHorizontal = 15;
    static ConsoleColor[] newColor = new ConsoleColor[] { ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Red, ConsoleColor.DarkMagenta, ConsoleColor.White };
    static int colorIndex = 0;

    static void Main()
    {
        Console.Title = "Falling Rocks";
        Random rnd = new Random(DateTime.Now.Second);
        int rockIndex = 0;
        string dwarf = "(0)";
        int score = 0;

        Console.WindowHeight = height;
        Console.BufferHeight = height;
        Console.WindowWidth = width;
        Console.BufferWidth = width;

        char[] rock = new char[] { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ',', '-' };

        while (run)
        {
            if (Console.KeyAvailable)
            {
                Control();
            }

            if (rockHorizontal == dwarfHorizontal + 1 && rockVertical == dwarfVertical)
            {
                score++;
                rockIndex = rnd.Next(0, rock.Length);
                NewRock(rnd);
            }
            else if (rockVertical >= dwarfVertical + 1)
            {
                NewRock(rnd);
                rockIndex = rnd.Next(0, rock.Length);
            }

            // rock position and print rock
            Console.SetCursorPosition(rockHorizontal, rockVertical++);
            Console.ForegroundColor = newColor[colorIndex];
            Console.WriteLine(rock[rockIndex]);

            // dwarf position and print dwarf
            Console.SetCursorPosition(dwarfHorizontal, dwarfVertical);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(dwarf);

            Console.SetCursorPosition(0, 0);
            Console.Write(score);
            Thread.Sleep(150);
            Console.Clear();
        }

    }

    private static void NewRock(Random rnd)
    {
        Console.Clear();
        rockHorizontal = rnd.Next(1, width - 1);
        colorIndex = rnd.Next(0, newColor.Length);
        rockVertical = 0;
    }

    private static void Control()
    {
        ConsoleKeyInfo key = Console.ReadKey();
        if (key.Key == ConsoleKey.LeftArrow)
        {
            if (dwarfHorizontal > 0)
            {
                dwarfHorizontal--;
            }
        }
        else if (key.Key == ConsoleKey.RightArrow)
        {
            if (dwarfHorizontal < width - 4)
            {
                dwarfHorizontal++;
            }
        }
        else if (key.Key == ConsoleKey.Escape)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(dwarfHorizontal / 2, dwarfVertical / 2);
            Console.WriteLine("Goodbye!");
            Console.ForegroundColor = ConsoleColor.Black;
            Thread.Sleep(300);
            run = false;
        }
    }
}