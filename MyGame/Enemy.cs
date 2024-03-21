using System;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health = 100;
        private float shield = 0;
        public Enemy(){
            this.name = SetName();
            health = 100;
            shield = 0;

        } 

        public string GetName(){
            return name;
        }

        public void TakeDamage(float damage){
            shield -= damage;
            if (shield<0){
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if(health<0)health = 0;
            }
        }
        public float GetHealth(){
            return health += 50;
        }
        
        public float GetShield(){
            return shield += 50;
        }
        public string SetName(){
            const int MaxLength = 8;
            if (name.Length > MaxLength)
            name = name.Substring(0, MaxLength);
            return name;
        }
        static void Main(string[] args)
        {
            int e = int.Parse(args[0])-1;
            int[][] ola = new int [e-1] [];
            for (int i = 0; i<e; i++){
                Console.Write($"Nome do inimigo {i+1}: ");
            }
            
        }

    }


}