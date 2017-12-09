using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int checkSum = 0;
            var path = AppDomain.CurrentDomain.BaseDirectory + "input.csv";
            int[][] lines = File.ReadLines(path)
                .Select(s => Array.ConvertAll(s.Split("\t"), int.Parse))
                .ToArray();

            foreach (var line in lines)
            {
                checkSum += (line.Max() - line.Min());
            }

            System.Console.WriteLine(checkSum);
        }
    }
}
