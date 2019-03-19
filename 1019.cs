using System;

class URI
{

    static void Main(string[] args)
    {
        int horas;
        int minutos;
        int segundos;
        int tempo = 0;

        string calculo;
        calculo = Console.ReadLine();
        tempo = int.Parse(calculo);

        horas = tempo / 3600;
        minutos = (tempo % 3600) / 60;
        segundos = (tempo % 3600) % 60;

        Console.WriteLine("" + horas + ":" + minutos + ":" + segundos);
        Console.ReadLine();
    }

}