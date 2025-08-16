using System;
using System.Diagnostics;
// test1

class Program
{
    static void Main()
    {
        Stopwatch sw = Stopwatch.StartNew();
        long total = 0;
        for (int i = 1; i <= 100_000_000; i++)
        {
            total += i;
        }
        sw.Stop();
        Console.WriteLine($"C#: {sw.Elapsed.TotalSeconds:F5} sec");
    }
}
