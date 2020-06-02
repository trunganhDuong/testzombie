using System;
using System.IO;

namespace TestZombie
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 50; i++)
            {
                Console.WriteLine("Read file");
                File.ReadAllText("");
            }
        }
    }
}
