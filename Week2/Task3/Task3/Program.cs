﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public static void Ex5(DirectoryInfo dir, int level)
        {
            foreach (FileInfo f in dir.GetFiles())
            {
                PrintSpaces(level);
                Console.WriteLine(f.Name);
            }
            foreach (DirectoryInfo d in dir.GetDirectories())
            {
                PrintSpaces(level);
                Console.WriteLine(d.Name);
                Ex5(d, level + 1);
            }
        }

        public static void PrintSpaces(int level)
        {
            for (int i = 0; i < level; i++)
                Console.Write("     ");
        }

        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo("/Users/Daniyar/Desktop/pp2");
            Ex5(dir, 0);
            Console.ReadKey();
        }

    }
}
