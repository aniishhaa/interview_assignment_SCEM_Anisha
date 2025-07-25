using System;

public class Problem1
{
    public static bool duplicate_element(int[] num)
    {
        int n = num.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                //if number is the same 
                if (num[i] == num[j])
                {
                    return true;
                }
            }
        }
        return false;
    }
}
