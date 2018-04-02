using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_7._1._2 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Skriv ett tal: ");
            string firstStringNumber = Console.ReadLine();

            Console.Write("Skriv ett till tal: ");
            string secondStringNumber = Console.ReadLine();

            int firstNumber = Convert.ToInt32(firstStringNumber);
            int secondNumber = Convert.ToInt32(secondStringNumber);
            int addNumber = firstNumber+secondNumber;

            Console.WriteLine("Du valde {0} och {1}, om vi adderar dom får vi {2}", firstNumber, secondNumber, addNumber);
            Console.ReadLine();
        }
    }
}
