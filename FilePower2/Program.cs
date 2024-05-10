using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace FilePower2
{
    class Program
    {
        static void Main(string[] args)
        { 
            string input = " ";
            //escrever no texto.txt
            using StreamWriter sw = new StreamWriter(args[0]);

            do
            {
                Console.WriteLine("Digite palavras e carregue 'enter'):");
                if(input != "")
                {
                    input = Console.ReadLine();
                    sw.WriteLine(input);
                }
            } while (input != "");
    
        }
    }
}
