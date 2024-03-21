using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string olas = "3";
            int e = int.Parse(olas);
            Enemy[] ola = new Enemy [e];
            for (int i = 0; i<=(e-1); i++){
                Console.Write($"Nome do inimigo {i+1}: ");
                string n = Console.ReadLine();
                Enemy ene = new Enemy(n);
                ola[i] = ene;
            }
        }
    }
}
