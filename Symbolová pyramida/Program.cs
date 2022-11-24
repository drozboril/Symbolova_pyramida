using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symbolová_pyramida
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte počet řádků");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte symbol");
            char symbol = char.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.SetCursorPosition(50, 9 + i);
                for (int j = 1; j < num - i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("{0}", symbol);
                    Console.Write(" ");
                }
                Console.ReadLine();
            }
        } 
    }
}