using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace CharSets
{
    class Program
    {
        static void Main(string[] args)
        { 
            if(args.Length == 0)
            {
                Console.WriteLine("Não foi adicionado nenhum ficheiro.");
            }
            else
            {
                HashSet<string> conjunto = new HashSet<string>();
                string s;

                foreach (string filename in args)
                {
                    using StreamReader sr = new StreamReader(filename);

                    while ((s = sr.ReadLine()) != null)
                    {
                        conjunto.Add(s);
                    }
                }
                
            }
    
        }
    }
}
