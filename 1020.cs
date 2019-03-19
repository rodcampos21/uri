using System;

class URI
{

    static void Main(string[] args)
    {
        int ano;
        int mes;
        int dia;
        int idade = 0;

        string calculo;
        calculo = Console.ReadLine();
        idade = int.Parse(calculo);

        ano = idade / 365;
        mes = (idade % 365) / 30;
        dia = (idade % 365) % 30;

        Console.WriteLine($"{ano} ano(s)\n{mes} mes(es)\n{dia} dia(s)");
        Console.ReadLine();
    }

}