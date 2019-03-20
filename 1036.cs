using System;

class URI
{

    static void Main(string[] args)
    {

        double A, B, C;

        String[] vet = Console.ReadLine().Split(' ');
        A = double.Parse(vet[0]);
        B = double.Parse(vet[1]);
        C = double.Parse(vet[2]);

     

        if (A == 0 || B == 0 || C == 0) 

        {
            Console.WriteLine("Impossivel calcular");
        }
        else if (((B * B) - 4 * (A * C)) < 0)
        {
            Console.WriteLine("Impossivel calcular");



        }

        else
        {
            double delta = (B * B) - (4 * A * C);
            double raiz = Math.Sqrt(delta);

            var x1 = ((-(B)) + raiz) / (2 * A);
            var x2 = ((-(B)) - raiz) / (2 * A);

            Console.WriteLine("R1 = {0:0.00000}", x1);
            Console.WriteLine("R2 = {0:0.00000}", x2);

        }


        Console.ReadLine();

    }

}
