//Problem - http://wp.me/p42BNa-1R
using System;

class YahtzeeScore
{
    static void Main(string[] args)
    {
        int[] toss = new int[5];
        for (int i = 0; i < toss.Length; i++)
        {
            toss[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(maxPoints(toss));
    }

    public static int maxPoints(int[] toss)
    {
        Array.Sort(toss);

        int current = 0, max = 0;

        for (int i = 0; i < toss.Length - 1; i++)
        {
            if (toss[i] == toss[i + 1])
            {
                current += toss[i] + toss[i + 1];
            }
            if (max < current)
            {
                max = current;
                current = 0;
            }
        }
        return max > toss[toss.Length - 1] ? max : toss[toss.Length - 1];
    }
}