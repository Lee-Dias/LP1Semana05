using System;

namespace MyGame
{

    class Program
    {
        static void Main(string[] args)
        {
            PowerUp pow = PowerUp.shield;
            int e = int.Parse(args[0]);
            Enemy[] ola = new Enemy [e];
            for (int i = 0; i<=(e-1); i++){
                Console.Write($"Nome do inimigo {i+1}: ");
                string n = Console.ReadLine();
                ola[i] = new Enemy(n);
            }
            ola[0].PickupPowerUp(pow, 50);
            ola[0].TakeDamage(70);
            for (int i = 0; i<=(e-1); i++){
                Console.Write($"{ola[i].GetName()} {ola[i].GetHealth()} " );
                Console.WriteLine($"{ola[i].GetShield()}");
            }
            
            Console.WriteLine
            ($"amount of powerups used {Enemy.Getamountofpowerups()}");
        }
    }
}
