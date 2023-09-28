using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyPasswordBeetch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (bool i = false; i != true; i = i) {
                Console.WriteLine("GUESS MY PASSWORD BEETCH");
                string items = "ALPHA";
                string Awnser;
                Console.WriteLine("ENTER PASSWORD:");
                Awnser = Console.ReadLine();
                if (Awnser == items)
                {
                    Console.WriteLine("GG");
                    i = true;
                } else
                {
                    Console.WriteLine("Back to step 1");
                    i = false;
                }
            }
        }
    }
}
