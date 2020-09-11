using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entrada:");
            string c = Console.ReadLine();

            List<int> numberToVerify = new List<int>(c.Select(i => Int32.Parse(i.ToString())));

            List<Contagem> numberCheckout = new List<Contagem>();
            numberToVerify.Distinct().ToList().ForEach(n => numberCheckout.Add(new Contagem { Number = n, Count = 0 }));
            numberCheckout.ForEach(contar => contar.Count = numberToVerify.Count(number => number == contar.Number));
            numberCheckout = numberCheckout.OrderByDescending(contagem => contagem.Count).ToList();
            Console.WriteLine("Saida: " + numberCheckout.FirstOrDefault().Number);
        }
    }
    public class Contagem
    {
        public int Number { get; set; }
        public int Count { get; set; }
    }
}
    
