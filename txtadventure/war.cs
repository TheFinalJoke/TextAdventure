using System;

namespace newTXTBYTXTADVENTURE
{
    class War {
        private object player;

        public War() {
            this.player = "";
        }
        public War(object player) {
            this.player = player;
        }

        public static int battle(int random) {
            switch(random) {
                case 0:
                    {
                        Console.WriteLine("Blew UP, Idiot");
                    }
                case 1:
                case 2:
                case 3:
                        {
                            Console.WriteLine("Enemy has rolled a small number!");
                            Console.WriteLine("Taken 10 Damage");
                            player.setHealth(player.getHealth() - 10);
                            Console.WriteLine("Enemys health is now at " + enemy.getHealth());
                            Console.Read();
                            break;
                        }// case 1-3
                case 4:
                case 5:
                case 6:
                    {
                        Console.WriteLine("STUFF");
                    }
            }
        }
    }
}