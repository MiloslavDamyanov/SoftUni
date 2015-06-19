using System;

class ReturnIndex
{
    static void Main()
    {

        int[] array = new int[] { 1, 2, 3, 5 };
        Console.WriteLine(array[GetIndex(array, 3)]);
    }

    private static int GetIndex(int[] array, int index)
    {
        int newIndex = 0;
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (index > array.Length - 1)
            {
                while (count != index)
                {
                    newIndex++;
                    count++;
                    if (newIndex == array.Length)
                    {
                        newIndex = 0;
                    }
                }

                index = newIndex;
            }
        }

        return index;
    }
}