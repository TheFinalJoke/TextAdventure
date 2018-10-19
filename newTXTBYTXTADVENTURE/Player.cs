using System;
using System.Collections.Generic;
using System.Text;
//Written by Nick Shorter
namespace newTXTBYTXTADVENTURE
{
    class Player
    {
        private int health;
        private int counter;
        private int firstRoll;

        public Player()
        {
            this.health = 0;
            this.counter = 0;
            this.firstRoll = 0;
        }
        public Player(int health, int counter, int firstRoll)
        {
            this.health = health;
            this.counter = counter;
            this.firstRoll = firstRoll;
        }

        public void setHealth(int health)
        {
            this.health = health;
        }
        public int getHealth()
        {
            return health;
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
            return ("Your health is " + health);
        }
    }
}
