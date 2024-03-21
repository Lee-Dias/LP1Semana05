﻿using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int e = int.Parse(args[0]);
            Enemy[] ola = new Enemy [e];
            for (int i = 0; i<=(e-1); i++){
                Console.Write($"Nome do inimigo {i+1}: ");
                string n = Console.ReadLine();
                ola[i] = new Enemy(n);
            }
            for (int i = 0; i<=(e-1); i++){
                Console.WriteLine($"{ola[i].GetName()} {ola[i].GetHealth()} {ola[i].GetShield()}" );
            }
        }
    }
}
