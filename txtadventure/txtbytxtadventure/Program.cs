using System;

namespace newTXTBYTXTADVENTURE
{
    class Program
    {
        
        private static int health;
        private static Enemy enemy = new Enemy();
        private static Player Player1 = new Player();

        //Main was written by Nick Shorter
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your Adenture!");
            string difficulty = " ";
            while (difficulty == " " || difficulty != "hard" || difficulty != "easy")
            {
                Console.Write("Do you Want a Hard and Easy Adventure -> ");
                difficulty = Console.ReadLine().ToLower();

                if (difficulty == "hard")
                {
                    health = 50;
                    Player1.setHealth(health);
                    enemy.setHealth(health * 2);
                    Console.WriteLine(Player1.toString());
                    break;
                }

                else if (difficulty == "easy")
                {
                    health = 200;

                    Player1.setHealth(health);
                    enemy.setHealth(health);
                    Console.WriteLine(Player1.toString());
                    break;
                }
                else
                {
                    Console.WriteLine("You have inputed an invaild value: Try Again");
                }

            }

            string user = " ";
            while (difficulty == " " || difficulty != "hard" || difficulty != "easy" || user != "modern" || user != "medievel")
            {
                if (difficulty == "easy")
                {
                    Console.WriteLine("This Adventure will be fairly easy. Do you want to have a Modern or Medievel -> ");
                }
                else
                {
                    Console.WriteLine("This Adventure is not for the wary! Do you want to have a Modern or Medievel -> ");
                }

                user = Console.ReadLine().ToLower();
                if (user == "modern")
                {
                    Modern();
                    break;
                }
                else if (user == "medievel")
                {
                    Medievel();
                    break;
                }
                else
                {
                    Console.WriteLine("You have inputed a wrong value");
                }

            }

            Console.WriteLine("Press any key to finish");
            Console.ReadLine();
        }//end main

        //Written by Nick Shorter
        public static void Modern()
        {
            string userInput = " ";
            while (userInput == " " || userInput != "navy" || userInput != "marines")
            {
                Console.WriteLine("Do you want a Navy or Marines -> ");
                userInput = Console.ReadLine();
                if (userInput == "navy")
                {
                    Navy();
                    break;

                }
                else if (userInput == "marines")
                {
                    Marines();
                    break;

                }
                else
                {
                    Console.WriteLine("you did not enter a correct value");
                }
            }

        }
        //Written by Nick Shorter
        public static void Marines()
        {
            Console.WriteLine("You have chosen Marines!");
            enemy.setType("Tank");
            Console.WriteLine("You are battling against a " + enemy.getType());
            string input = " ";
            while (input == " " || input != "tank" || input != "mg")
            {
                Console.WriteLine("Do you want to be in a Tank or Machine gun nest? Tank or MG -> ");
                input = Console.ReadLine().ToLower();

                if (input == "tank")
                {
                    tank();
                    break;
                }
                else if (input == "mg")
                {
                    machineGun();
                    break;
                }
                else
                {
                    Console.WriteLine("You have typed an invalid line");
                }
            }
        }
        //Written by Nick Shorter
        public static void tank()
        {
            Console.WriteLine("Man The Guns! Tank Dead ahead!");
            string user = " ";
            while (user == " " || user != "hard" || user != "easy")
            {
                Console.WriteLine("Are you ready to fire? yes or no ->");
                user = Console.ReadLine().ToLower();
                if (user == "yes")
                {
                    War();
                    break;
                }
                else if (user == "no")
                {
                    Console.WriteLine("Hurry up dummy");
                }
                else
                {
                    Console.WriteLine("You have entered a invalid argument");
                }
            }
        }
        //Written by Nick Shorter
        public static void machineGun()
        {
            Console.WriteLine("You are on a Machine Gun! GET LOCKED AND LOADED");
            string mgUser = " ";

            Console.WriteLine("Enemy is starting to fire at us!! Are you locked and loaded??");
            mgUser = Console.ReadLine().ToLower();

            while (mgUser == " " || mgUser != "yes" || mgUser != "no")
            {
                if (mgUser == "yes")
                {
                    War();
                    break;
                }
                else if (mgUser == "no")
                {
                    Console.WriteLine("ARE YOU SERIOUS CADET?????");
                }
                else
                {
                    Console.WriteLine("You have inputed an incorrect value");
                    mgUser = Console.ReadLine();
                }
            }
        }
        //Written by Nick Shorter
        public static void Navy()
        {
            Console.WriteLine("You have chosen Navy!");
            string landOrBattle = " ";

            while (landOrBattle == " " || landOrBattle != "battleship" || landOrBattle != "land")
            {

                Console.WriteLine("Do you want to be on a Battleship or Land?-> ");
                landOrBattle = Console.ReadLine().ToLower();

                if (landOrBattle == "battleship")
                {
                    battleShip();
                    break;
                }
                else if (landOrBattle == "land")
                {
                    land();
                    break;
                }
                else
                {
                    Console.WriteLine("You have inputed a invaild argument: Try Again");
                }

            }
        }

        public static void Medievel()
        {
            Console.WriteLine("You have Chosen Medievel");

        }
        //Written by Nick Shorter
        public static int random(int minValue, int maxValue)
        {
            Random myRandom = new Random();
            int random = myRandom.Next(minValue, maxValue);
            return random;
        }
        //Written by Nick Shorter
        public static void battleShip()
        {
            enemy.setType("BattleShip");
            Console.WriteLine(enemy.toString());
            string warDecision = " ";

            while (warDecision == " " || warDecision != "yes" || warDecision != "no")
            {   
                Console.WriteLine("Welcome aboard Sailor! Are you ready to go to War?");

                warDecision = Console.ReadLine();

                if (warDecision == "yes")
                {
                    War();
                    break;
                }
                else if (warDecision == "no")
                {
                    Console.WriteLine("Gear up now!");
                }
                else
                {
                    Console.WriteLine("Incorrect Response: Try Again");
                }
            }
       }
        //Written by Nick Shorter
        public static void land()
        {
            enemy.setType("Rushing Enemies");
            Console.WriteLine(enemy.toString());
            Console.WriteLine("Get in those Trenches!!!!");
            string user = " ";

            while (user == " " || user != "yes" || user != "no")
            {
                Console.WriteLine("They are rushing at us Are you ready to fire on Command?");
                user = Console.ReadLine();
                if (user == "yes")
                {
                    War();
                    break;
                }
                else if (user == "no")
                {
                    Console.WriteLine("You better hurry up fast they are running at you!!");
                }
                else
                {
                    Console.WriteLine("You have inputted an incorrect value");
                }
            }
        }
        //Written by Nick Shorter
        public static void War()
        {
            while (Player1.getHealth() >= 0 || enemy.getHealth() >= 0)
            {
                if (Player1.getHealth() <= 0 || enemy.getHealth() <= 0)
                {
                    break;
                }
                else
                {
                    Random ran = new Random();
                    int random = ran.Next(0, 10);

                    if (Player1.getCounter() >= enemy.getCounter())
                    {
                        Console.WriteLine("Enemy health is " + enemy.getHealth());

                        int enemyHealth = enemy.getHealth();
                        int enemyCounter = enemy.getCounter();

                        switch (random)
                        {
                            case 0:
                                {
                                    Console.WriteLine("Enemy has rolled a 0 and blew himself up, dummy! Reroll");
                                    break;

                                }// case 0
                            case 1:
                            case 2:
                            case 3:
                                {
                                    Console.WriteLine("Enemy has rolled a small number!");
                                    Console.WriteLine("Taken 10 Damage");
                                    enemyHealth = enemyHealth - 10;
                                    enemy.setHealth(enemyHealth);

                                    Console.WriteLine("Enemys health is now at " + enemy.getHealth());
                                    enemyCounter++;
                                    enemy.setCounter(enemyCounter);
                                    Console.Read();
                                    break;


                                }// case 1-3
                            case 4:
                            case 5:
                            case 6:
                                {
                                    Console.WriteLine("Enemy has rolled a medium number!");
                                    Console.WriteLine("Taken 35 Damage!");
                                    enemyHealth = enemyHealth - 35;
                                    enemy.setHealth(enemyHealth);

                                    Console.WriteLine("Enemys health is now at " + enemy.getHealth());
                                    enemyCounter++;
                                    enemy.setCounter(enemyCounter);
                                    Console.Read();
                                    break;

                                }// case 4-6
                            case 7:
                            case 8:
                            case 9:
                                {
                                    Console.WriteLine("Enemy has rolled a high number!");
                                    Console.WriteLine("Taken 75 Damage ");
                                    enemyHealth = enemyHealth - 75;
                                    enemy.setHealth(enemyHealth);

                                    Console.WriteLine("Enemys health is now at " + enemy.getHealth());
                                    enemyCounter++;
                                    enemy.setCounter(enemyCounter);
                                    Console.Read();
                                    break;
                                }// cases 7-9
                            case 10:
                                {
                                    Console.WriteLine("Enemy rolled a 10!");
                                    Console.WriteLine("Gained 25 Health");
                                    enemyHealth = enemyHealth + 25;
                                    enemy.setHealth(enemyHealth);

                                    Console.WriteLine("Enemys health is now at " + enemy.getHealth());
                                    enemyCounter++;
                                    enemy.setCounter(enemyCounter);
                                    Console.Read();
                                    break;


                                }// case 10
                        }// switch

                    }


                    else
                    {

                        if (Player1.getCounter() <= enemy.getCounter())
                        {
                            Console.WriteLine("Your health is " + Player1.getHealth());
                            int player1Health = Player1.getHealth();
                            int playerCounter = Player1.getCounter();
                            switch (random)
                            {
                                case 0:
                                    {
                                        Console.WriteLine("You have blew yourself up, dummy! Reroll");
                                        break;

                                    }// case 0
                                case 1:
                                case 2:
                                case 3:
                                    {
                                        Console.WriteLine("Player has rolled a small number!");
                                        Console.WriteLine("Taken 10 Damage");

                                        player1Health = player1Health - 10;
                                        Player1.setHealth(player1Health);

                                        Console.WriteLine("Player health is now at " + Player1.getHealth());
                                        playerCounter++;
                                        Player1.setCounter(playerCounter);
                                        Console.Read();
                                        break;

                                    }// case 1-3
                                case 4:
                                case 5:
                                case 6:
                                    {
                                        Console.WriteLine("Player has rolled a medium number");
                                        Console.WriteLine("Taken 35 Damage!");
                                        player1Health = player1Health - 35;
                                        Player1.setHealth(player1Health);

                                        Console.WriteLine("Player health is now at " + Player1.getHealth());
                                        playerCounter++;
                                        Player1.setCounter(playerCounter);
                                        Console.Read();
                                        break;
                                    }// case 4-6
                                case 7:
                                case 8:
                                case 9:
                                    {
                                        Console.WriteLine("Player has rolled a high number!");
                                        Console.WriteLine("Taken 75 Damage ");
                                        player1Health = player1Health - 75;
                                        Player1.setHealth(player1Health);

                                        Console.WriteLine("Player health is now at " + Player1.getHealth());
                                        playerCounter++;
                                        Player1.setCounter(playerCounter);
                                        Console.Read();
                                        break;
                                    }// cases 7-9
                                case 10:
                                    {
                                        Console.WriteLine("Player has rolled a 10!");
                                        Console.WriteLine("Player has gained 25 Health");
                                        player1Health = player1Health + 25;
                                        Player1.setHealth(player1Health);

                                        Console.WriteLine("Player health is now at " + Player1.getHealth());
                                        playerCounter++;
                                        Player1.setCounter(playerCounter);
                                        Console.Read();
                                        break;
                                    }// case 10
                            }// switch
                        }// checks who goes next. Whos ever counter is greater they will go next

                    } // end if health < 0 
                }
            }// end while
                if (Player1.getHealth() >= enemy.getHealth())
                {
                    Console.WriteLine("You have beaten the " + enemy.getType());
                    Console.Read();

                }// end if
                else
                 {
                Console.WriteLine("You have died");
                Console.Read();

                  }// end else

            }// end war
        }//end class
                        
           
     }
     
    
   

