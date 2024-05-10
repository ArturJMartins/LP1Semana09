using System;
using System.Collections.Generic;

namespace IntCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int> {1, 10, -30, 10 , -5 };
            // uma forma de inicializar a stack
            Stack<int> pilha = new Stack<int>(lista);
            // ou
            Stack<int> pilha2 = new Stack<int>();
            pilha2.Push(1);
            pilha2.Push(10);
            pilha2.Push(-30);
            pilha2.Push(10);
            pilha2.Push(-5);

            Queue<int> queue = new Queue<int> (lista);
            HashSet<int> hashSet = new HashSet<int> (lista);

            Console.Write("Lista: ");
            foreach (int l in lista)
            {
                Console.Write(l + " ");
            }

            Console.WriteLine("");
            Console.Write("Stack: ");

            foreach (int l in pilha)
            {
                Console.Write(l + " ");
            }

            Console.WriteLine("");
            Console.Write("Queue: ");

            foreach (int l in queue)
            {
                Console.Write(l + " ");
            }

            Console.WriteLine("");
            Console.Write("HashSet: ");

            foreach (int l in hashSet)
            {
                Console.Write(l + " ");
            }
            
        }
    }
}
