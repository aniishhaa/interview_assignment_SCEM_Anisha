using System;

public class P1_testing
{
    public static void Main()
    {
        //test cases
        int[] test1 = { 1, 2, 3, -1 };
        int[] test2 = { 1, 2, -3, 4 };
        int[] test3 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
        int[] test4 = { 0, 0, 0, 1 };

        Console.WriteLine("Test case 1 :" + (Problem1.duplicate_element(test1) ? "true" : "false"));
        Console.WriteLine("Test case 2: " + (Problem1.duplicate_element(test2) ? "true" : "false"));
        Console.WriteLine("Test case 3: " + (Problem1.duplicate_element(test3) ? "true" : "false"));
        Console.WriteLine("Test case 4: " + (Problem1.duplicate_element(test4) ? "true" : "false"));
    }
}