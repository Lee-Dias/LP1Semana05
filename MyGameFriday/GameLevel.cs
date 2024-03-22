using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace MyGame
{       


    public class GameLevel
    {
        private Difficulty diff;
        private Enemy[] numderooms = new Enemy[1];

        
        public GameLevel(int rooms, Difficulty dif){
            numderooms = new Enemy[rooms];
            diff = dif;

        }
        public void SetEnemyInRoom(int rn, Enemy name){
            numderooms[rn] = name;
        } 

    }


}