namespace Academy2024Lib;

public static class ArrayUtils
{
    public static int FindIndexOfMin(int[] array) =>
        FindIndexOfMin(array, 0, array.Length - 1);

    public static int FindIndexOfMin(int[] array, int from, int to)
    {
        int indexOfMin = from;

        for (int i = from + 1; i <= to; i++)
        {
            if (array[i] < array[indexOfMin])
            {
                indexOfMin = i;
            }
        }
        return indexOfMin;
    }

    public static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    public static void SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int indexOfMin = FindIndexOfMin(array, i, array.Length - 1);
            Swap(array, i, indexOfMin);
        }
    }

    public static int FindFirstIndexOfElement(int[] array, int element)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == element)
                return i;
        }
        return -1;
    }

    public static int[] CreateReversedArray(int[] source)
    {
        int n = source.Length;
        int[] dest = new int[n];

        for (int i = 0; i < n; i++)
        {
            dest[i] = source[n - i - 1];
        }
        return dest;
    }

    public static void ReverseArray(int[] array)
    {
        int length = array.Length;
        for (int i = 0; i < length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[length - i - 1];
            array[length - i - 1] = temp;
        }
    }

    public static int[] Copy(int[] source)
    {
        int n = source.Length;
        int[] dest = new int[n];

        for (int i = 0; i < n; i++)
        {
            dest[i] = source[i];
        }
        return dest;
    }

    public static int Sum(int[] array)
    {
        int sum = 0;

        foreach (var item in array)
            sum += item;

        return sum;
    }

    public static double Average(int[] array)
    {
        double sum = Sum(array);
        double average = sum / array.Length;
        return average;
    }

    public static int Max(int[] array)
    {
        int max = int.MinValue;

        foreach (var num in array)
        {
            if (max < num)
                max = num;
        }

        return max;
    }


    public static int Min(int[] array)
    {
        int min = int.MaxValue;

        foreach (var num in array)
        {
            if (min > num)
                min = num;
        }

        return min;
    }

    public static int[] MergeSortedArrays(int[] a1, int[] a2)
    {
        int[] result = new int[a1.Length + a2.Length];
        int i = 0, j = 0, k = 0;

        // Traverse both arrays and merge them
        while (i < a1.Length && j < a2.Length)
        {
            if (a1[i] <= a2[j])
            {
                result[k] = a1[i];
                i++;
            }
            else
            {
                result[k] = a2[j];
                j++;
            }
            k++;
        }

        // Copy remaining elements of a1, if any
        while (i < a1.Length)
        {
            result[k] = a1[i];
            i++;
            k++;
        }

        // Copy remaining elements of a2, if any
        while (j < a2.Length)
        {
            result[k] = a2[j];
            j++;
            k++;
        }

        return result;
    }
}
