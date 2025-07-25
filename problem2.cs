using System;

public class Problem2
{
    public static void move_zeros(int[] num)
    {
        int n = num.Length;
        int j = 0;
        int count = 0;
        // shift the non zero by -1 position
        for (int i = 0; i < n; i++)
        {
            if (num[i] != 0)
            {
                num[j] = num[i];
                j++;
                count++;
            }
        }
        // adding zeroes to the end
        for (int i = count; i < n; i++)
        {
            num[i] = 0;
        }

        Console.Write("[");
        for (int i = 0; i < n - 1; i++)
        {
            Console.Write(num[i]+", ");
        }
        Console.WriteLine( num[n - 1]+" ]");
    }
}
