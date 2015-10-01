using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SelectionSort
{
    static void Main()
    {
        int[] array = { -7, -1, 61, 57, 3, 4, 9, -10, 15 };

        /* a[0] to a[n-1] is the array to sort */
        int i, j;
        int iMin;

        /* advance the position through the entire array */
        /*   (could do j < n-1 because single element is also min element) */
        for (j = 0; j < array.Length - 1; j++)
        {
            /* find the min element in the unsorted a[j .. n-1] */

            /* assume the min is the first element */
            iMin = j;
            /* test against elements after j to find the smallest */
            for (i = j + 1; i < array.Length; i++)
            {
                /* if this element is less, then it is the new minimum */
                if (array[i] < array[iMin])
                {
                    /* found new minimum; remember its index */
                    iMin = i;
                }
            }

            if (iMin != j)
            {
                Swap(array, j, iMin);
            }
        }

    }

    private static void Swap(int[] array, int j, int iMin)
    {
        int value = array[j];
        array[j] = array[iMin];
        array[iMin] = value;
    }  
}