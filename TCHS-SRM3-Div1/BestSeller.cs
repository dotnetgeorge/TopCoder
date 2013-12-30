//Problem - http://wp.me/p42BNa-1Z
using System;

class BestSeller
{
    static void Main(string[] args)
    {
        string[] items = new string[] {"icecream", "peanuts", "peanuts", "chocolate", "candy", "chocolate", "icecream", "apple"};
        Console.WriteLine(findBestSeller(items));
    }
    public static string findBestSeller(string[] items)
    {
        Array.Sort(items);
        string bestWord = "", currentWord = "";
        int current = 0, max = 0;
        for (int i = 0; i < items.Length - 1; i++)
        {
            if (items[i].Equals(items[i + 1]))
            {
                currentWord = items[i];
                current++;
            }
            else
            {
                current = 0;
            }
            if (current > max)
            {
                max = current;
                bestWord = currentWord;
                
            }
        }

        return bestWord;
    }
}