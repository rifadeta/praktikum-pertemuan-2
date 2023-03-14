using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, hasil; //untuk menyatakan bilangangan
            string op; //untuk menyatakan karakter

            Console.WriteLine("Calculator");

            Console.Write("a: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Pilih Operator (+, -, *, /): ");
            op = Console.ReadLine();

            Console.Write("b: ");
            b = double.Parse(Console.ReadLine());   


            //menggunakan if-else-if untuk memberi comand pilihan

            if(op == "+")
            {
                hasil = a + b;
                Console.WriteLine("= " + hasil);
            }
            else if(op == "-")
            {
                hasil = a - b;
                Console.WriteLine("= " + hasil);
            }
            else if (op == "*")
            {
                hasil = a * b;
                Console.WriteLine("= " + hasil);
            }
            else if (op == "/")
            {
                if (b == 0)
                {
                    Console.WriteLine("Invalid");
                }
                else
                {
                    hasil = a / b;
                    Console.WriteLine("= " + hasil);
                }
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.WriteLine("Tekan sembarang key untuk keluar");
            Console.ReadKey();
        }
    }
}
