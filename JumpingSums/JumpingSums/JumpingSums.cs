using System;

class JumpingSums
{
    static void Main()
    {
        string input = "1 2 3 5";
        int numberOfjumps = 4;

        string[] array = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] intArr = new int[array.Length];

        for (int i = 0; i < intArr.Length; i++)
        {
            intArr[i] = int.Parse(array[i].ToString());
        }

        int sum = 0;
        int stepCount = 0;
        int numCount = 0;
        int newIndex = 0;


        for (int i = 0; i < numberOfjumps; i++)
        {
            sum = intArr[i];
            newIndex = intArr[i];
            for (int j = 0; j < numberOfjumps; j++)
            {
                sum += intArr[GetIndex(intArr, intArr[newIndex])];
                newIndex = GetIndex(intArr, intArr[newIndex]);                
            }
        }
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