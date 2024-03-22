using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace MyGame
{       


    public class GameLevel
    {
        private Difficulty diff;
        private Enemy[] numderooms = new Enemy[1];
        private int enemyam = 0;
        

        
        public GameLevel(int rooms, Difficulty dif){
            numderooms = new Enemy[rooms];
            diff = dif;

        }
        public void SetEnemyInRoom(int rn, Enemy name){
            numderooms[rn] = name;
            enemyam += 1;
        } 
        public string GetDifficulty(){
            string d = "";
            if(diff == Difficulty.Easy){
                d = "Easy";
            }else if(diff == Difficulty.Medium){
                d = "Medium";
            }else{
                d = "Hard";
            }
            return d;
        } 
        public int GetNumRooms(){
            return numderooms.Length;
        } 
        public int GetNumEnemies(){
            return enemyam;
        } 
        public void PrintEnemies(){
            Console.WriteLine("has enemies");
        } 

    }


}