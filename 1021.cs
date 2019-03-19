using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n100, n50, n20, n10, n5, n2;
            int m1, m50, m25, m10, m05, m01;
            double notas;

            int notas1=0;
            int moedas=0;
            
            notas = Double.Parse(Console.ReadLine());

            notas1 = (int)notas;
            moedas = (int)((notas - notas1) * 100);

            n100 = notas1 / 100;
            notas1 = notas1 % 100;
            n50 = notas1 / 50;
            notas1 = notas1 % 50;
            n20 = notas1 / 20;
            notas1 = notas1 % 20;
            n10 = notas1 / 10;
            notas1 = notas1 % 10;
            n5 = notas1 / 5;
            notas1 = notas1 % 5;
            n2 = notas1 / 2;
            notas1 = notas1 % 2;

            m1 = notas1;
            m50 = moedas / 50;
            moedas = moedas % 50;
            m25 = moedas / 25;
            moedas = moedas % 25;
            m10 = moedas / 10;
            moedas = moedas % 10;
            m05 = moedas / 5;
            moedas = moedas % 5;
            m01 = moedas;
            
            Console.WriteLine("NOTAS:");
            Console.WriteLine(n100 + " nota(s) de R$ 100.00");
            Console.WriteLine(n50 + " nota(s) de R$ 50.00");
            Console.WriteLine(n20 + " nota(s) de R$ 20.00");
            Console.WriteLine(n10 + " nota(s) de R$ 10.00");
            Console.WriteLine(n5 + " nota(s) de R$ 5.00");
            Console.WriteLine(n2 + " nota(s) de R$ 2.00");

            Console.WriteLine("MOEDAS:");
            Console.WriteLine(m1 + " moeda(s) de R$ 1.00");
            Console.WriteLine(m50 + " moeda(s) de R$ 0.50");
            Console.WriteLine(m25 + " moeda(s) de R$ 0.25");
            Console.WriteLine(m10 + " moeda(s) de R$ 0.10");
            Console.WriteLine(m05 + " moeda(s) de R$ 0.05");
            Console.WriteLine(m01 + " moeda(s) de R$ 0.01");

            Console.ReadLine();





        }
    }
}
