using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer print = new Printer("Red");
            RedPrinter printr = new RedPrinter("Yellow");
            printr.Print("YES");
            print.Print("ABOBA");
            Console.ReadKey();
        }
    }
    class Printer
    {
        string color;
       public void Print(string value)
        {
            switch (color)
            {
                case "Red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "Green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "Yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                  
            }
            Console.WriteLine(value);
            Console.ResetColor();
        }
        public Printer(string color)
        {
            this.color = color;
        }
    }
    class RedPrinter:Printer
    {
       public RedPrinter(string color) : base(color)
        {

        } 
    }
}
