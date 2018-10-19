using System;
using System.Collections.Generic;
using System.Text;

//Written by Nick Shorter
namespace newTXTBYTXTADVENTURE
{
    public class Enemy
    {
        private int health;
        private String type;
        private int counter;
        private int firstRoll;

        public Enemy()
        {
            this.health = 0;
            this.type = " ";
            this.counter = 0;
            this.firstRoll = 0;
        }//default constructor
        public Enemy(int health, String type, int counter, int firstRoll)
        {
            this.health = health;
            this.type = type;
            this.counter = counter;
            this.firstRoll = firstRoll;
        }// end constructor

        public void setHealth(int health)
        {
            this.health = health;
        }
        public int getHealth()
        {
            return health;
        }
        public void setType(String type)
        {
            this.type = type;
        }
        public String getType()
        {
            return type;
        }
        public void setCounter(int counter)
        {
            this.counter = counter;
        }
        public int getCounter()
        {
            return counter;
        }
        public void setFirstRoll(int firstRoll)
        {
            this.firstRoll = firstRoll;
        }
        public int getFirstRoll()
        {
            return firstRoll;
        }
        public String toString()
        {
            return ("You are fighting a " + type + " and its health is " + health);
        }
    }
}
