using System;

namespace MyGame
{       


    public class Enemy
    {
        private string name;
        private float health = 100;
        private float shield = 0;
        static int amountofpowerups;

        static void initstatic(){
            amountofpowerups = 0;
            
        }
        public Enemy(string name){
            this.name = SetName(name);
            health = 100;
            shield = 0;
            initstatic();

        } 



        public string GetName(){
            return name;
        }
        public static int Getamountofpowerups(){
            return amountofpowerups;
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
            return health;
        }
        
        public float GetShield(){
            return shield;
        }
        public string SetName(string name){
            const int MaxLength = 8;
            if (name.Length > MaxLength)
            name = name.Substring(0, MaxLength);
            return name;
        }
        public void PickupPowerUp(PowerUp po, float aumentar){
            switch (po)
            {
                case PowerUp.Health:
                    health += aumentar;
                    if(health>100) health = 100;
                    amountofpowerups += 1;
                    break;
                case PowerUp.shield:
                    shield += aumentar;
                    if(shield>100) shield = 100;
                    amountofpowerups += 1;
                    break;
                default:
                    Console.WriteLine("thats is not a powerup");
                    break;
            }
        }

    }


}