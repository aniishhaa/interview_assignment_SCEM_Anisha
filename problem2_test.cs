using System;

public class P2_testing
{
    public static void Main()
    {
        //test cases
        int[] test1 = {0, 1, 0, 3, 12};
        int[] test2 = {1, 2, 3, 4};
        int[] test3 = {0, 0, 0, 0};

        Console.Write("Test case 1 :");
        Problem2.move_zeros(test1);
        Console.Write("Test case 2: ");
        Problem2.move_zeros(test2);
        Console.Write("Test case 3: ");
        Problem2.move_zeros(test3);
    }
}