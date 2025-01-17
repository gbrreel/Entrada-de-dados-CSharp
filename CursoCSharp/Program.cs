using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase:");
            string frase = Console.ReadLine();

            Console.WriteLine("Digite a primeira string:");
            string x = Console.ReadLine();

            Console.WriteLine("Digite a segunda string:");
            string y = Console.ReadLine();

            Console.WriteLine("Digite a terceira string:");
            string z = Console.ReadLine();

            Console.WriteLine("Digite a frase para usar o Split");
            string s = Console.ReadLine();

            string[] v = s.Split(' ');
            string g = v[0];
            string h = v[1];
            string i = v[2];
            
            Console.WriteLine("\nVoce digitou:");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);
        }
    }
}