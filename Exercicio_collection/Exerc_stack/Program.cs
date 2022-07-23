using System;
using System.Collections.Generic;

namespace Exerc_stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pilha de Livros!");

            Stack<Livro> stack = new Stack<Livro>();

            stack.Push(new Livro("Senhor dos Aneis"));
            stack.Push(new Livro("O Iluminado"));
            stack.Push(new Livro("1984"));

            Console.WriteLine($"\n Quantidade de livros: {stack.Count}");

            Console.WriteLine($"\n Primeira livro da pilha: {stack.Peek()}");

            stack.Pop();

            Console.WriteLine($"\n Quantidade de livros: {stack.Count}");

            foreach (var item in stack)
            {
                Console.WriteLine($"\n Os Livros da Estante: {item.ToString()}");

            }
        }
            
            
        public class Livro
        {
            public string Nome { get; set; }

            public Livro(string nome)
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
