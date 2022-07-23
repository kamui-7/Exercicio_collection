using System;
using System.Collections.Generic;

namespace Exerc_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de Animais");

            List<string> listaanimais = new List<string>();

            listaanimais.Add("Lobo");
            listaanimais.Add("Mabeco");
            listaanimais.Add("Coiote");
            listaanimais.Add("Lobo Guará");

            listaanimais.Insert(1, "Leão");

            listaanimais.Remove("Lobo Guará");

            listaanimais.RemoveAt(1);

            foreach (string s in listaanimais)
            {
                Console.WriteLine($"Canideos: {s}");
            }

        }
    }
}
