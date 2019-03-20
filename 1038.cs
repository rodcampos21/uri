using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Produto
    {
        public int code { get; set; }
        public string especification { get; set; }
        public decimal price { get; set; }

        public Produto(int pCode, string pEspecification, decimal pPrice)
        {
            this.code = pCode;
            this.especification = pEspecification;
            this.price = pPrice;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();

            

            var split = input.Split(new char[] { ' ' });
            var codigo = Int32.Parse(split[0]);
            var quantidade = Int32.Parse(split[1]);

            var valor = ObterProduto(codigo).price;

            decimal total = (valor * quantidade);

            Console.WriteLine("Total: R$ {0}", total.ToString("N2").Replace(',', '.'));
           

            Console.ReadLine();

        }

        public static Produto ObterProduto(int pCodigo)
        {
            List<Produto> listItens = new List<Produto>();

            listItens.Add(new Produto(1, "Cachorro Quente", 4.00M));
            listItens.Add(new Produto(2, "X-Salada", 4.50M));
            listItens.Add(new Produto(3, "X-Bacon", 5.00M));
            listItens.Add(new Produto(4, "Torrada Simples", 2.00M));
            listItens.Add(new Produto(5, "Refrigerante", 1.50M));

            return listItens.Find(x => x.code == pCodigo);

        }
        
    }
    
}