using System;
using System.Collections.Generic;
using System.Linq;

class LightTorches
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string ld = Console.ReadLine();
        ld = CheckIsLonger(n, ld);
        List<string> direction = new List<string>();
        List<char> rooms = new List<char>();

        AddCommands(direction);
        AddLettersInRooms(rooms, ld, n);
        ReplaceLD(n, direction, rooms);

        Console.WriteLine(CountDarkRooms(rooms) * (int)'D');
    }

    private static string CheckIsLonger(int n, string ld)
    {
        if (ld.Length > n)
        {
            string temp = null;
            for (int i = 0; i < n; i++)
            {
                if (ld[i] != ' ')
                {
                    temp += ld[i];
                }
            }

            ld = temp;
        }

        return ld;
    }

    private static void ReplaceLD(int n, List<string> direction, List<char> rooms)
    {
        int currentPosition = n / 2;
        for (int i = 0; i < direction.Count; i++)
        {
            var command = direction[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            currentPosition = UpdatePosition(currentPosition, command[0], command[1], rooms);
            if (rooms[currentPosition] == 'L')
            {
                rooms[currentPosition] = 'D';
            }
            else if (rooms[currentPosition] == 'D')
            {
                rooms[currentPosition] = 'L';
            }

        }
    }

    private static int CountDarkRooms(List<char> rooms)
    {
        int count = 0;
        for (int i = 0; i < rooms.Count; i++)
        {
            if (rooms[i] == 'D')
            {
                count++;
            }
        }

        return count;
    }

    private static int UpdatePosition(int currentPosition, string positiveOrNegative, string step, List<char> rooms)
    {
        if (positiveOrNegative == "LEFT")
        {
            for (int i = 0; i < int.Parse(step) + 1; i++)
            {
                if (currentPosition > 0)
                {
                    currentPosition--;
                }
            }
        }
        else if (positiveOrNegative == "RIGHT")
        {
            for (int i = 0; i < int.Parse(step) + 1; i++)
            {
                if (currentPosition < rooms.Count - 1)
                {
                    currentPosition++;
                }
            }
        }

        return currentPosition;
    }

    private static void AddLettersInRooms(List<char> rooms, string ld, int n)
    {
        int index = 0;
        for (int i = 0; i < n; i++)
        {
            rooms.Add(ld[index]);
            if (index == ld.Length - 1)
            {
                index = 0;
            }
            else
            {
                index++;
            }

        }
    }

    private static void AddCommands(List<string> direction)
    {
        string command = Console.ReadLine();
        while (command != "END")
        {
            if (command != "END")
            {
                direction.Add(command);
            }
            command = Console.ReadLine();
        }
    }
}
