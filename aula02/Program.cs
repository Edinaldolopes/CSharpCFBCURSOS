// See https://aka.ms/new-console-template for more information

using System;

namespace aula02
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            if(args.GetLength(0)){
                
                Console.Write(args.GetValue(0));
            }
            
        }
    }
}


