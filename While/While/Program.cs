﻿using System;
using System.Globalization;

namespace Uri1026
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, soma;

            x = int.Parse(Console.ReadLine());
            soma = 0;

            while (x != 0) {
                soma = soma + x;
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("A soma dos numeros digitas: " + soma);
        }
    }
}