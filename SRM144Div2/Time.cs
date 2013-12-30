//Problem - http://wp.me/p42BNa-1P
using System;

class Time
{
    static void Main(string[] args)
    {
        int seconds = int.Parse(Console.ReadLine());
        Console.WriteLine(whatTime(seconds));
    }
    public static string whatTime(int seconds)
    {
        TimeSpan ts = TimeSpan.FromSeconds(seconds);
        string result = ts.Hours + ":" + ts.Minutes + ":" + ts.Seconds;
        return result;
    }
}