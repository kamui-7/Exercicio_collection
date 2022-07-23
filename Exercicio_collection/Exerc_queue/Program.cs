using System;
using System.Collections.Generic;

namespace Exerc_queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fila da montanha-russa.");

            Queue<Pessoa> pessoas = new Queue<Pessoa>();

            pessoas.Enqueue(new Pessoa("Joao"));
            pessoas.Enqueue(new Pessoa("Fulano"));
            pessoas.Enqueue(new Pessoa("Ciclano"));
            pessoas.Enqueue(new Pessoa("Cicrano"));
            pessoas.Enqueue(new Pessoa("Cirano"));

            Console.WriteLine($"O primeiro da fila é: {pessoas.Dequeue()}");

            pessoas.Peek();

            Console.WriteLine($"O numero de pessoas na Fila é: {pessoas.Count}");

            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa.ToString());
            }
        }

        public class Pessoa
        {
            public string Nome { get; set; }

            public Pessoa(string nome)
            {
                Nome = nome;
            }
            public override string ToString()
            {
                return $"{Nome}";
            }
        }


    }
}
