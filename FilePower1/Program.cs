using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace FilePower1
{
    class Program
    {
        static void Main(string[] args)
        { 
            Queue<string> queue = new Queue<string>();
            
            string palavras;
            do
            {
                Console.WriteLine("Digite palavras e carregue 'enter'):");
                palavras = Console.ReadLine();
                if(palavras != "")
                {
                    queue.Enqueue(palavras);
                }
            } while (palavras != "");

            File.WriteAllLines(args[0],queue);
    
        }
    }
}
