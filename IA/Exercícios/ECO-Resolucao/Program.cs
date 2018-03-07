using System;
using System.Collections.Generic;

namespace ECO_Resolucao
{
    class Program
    {
        static IList<Objetivo> objetivos = new List<Objetivo>();
        static void Main(string[] args)
        {
            var A = new Objetivo();
            var B = new Objetivo();
            var C = new Objetivo();

            objetivos.Add(A);
            objetivos.Add(B);
            objetivos.Add(C);

            Console.WriteLine("Hello World!");
        }
    }
}
