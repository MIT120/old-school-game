using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace old_school_game
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("In this game you Play with Any key but Escape because we you it to exit \n PRESS Double Times ENTER to ENTER THE DUNGEON");
            Console.WriteLine("IN this Game you PLay With <A><S><D><W> FOr MOVEMENT ");
            Console.WriteLine("YOU YOUSE T FOR battle mode, G for attack and H for healthPotion");

            int input;
            string MoveBlock1;
            int Kills = 0;
            OnScreen Screen = new OnScreen();
            ConsoleKeyInfo input1;
            ConsoleKeyInfo input2;
            ConsoleKeyInfo input3;
            ConsoleKeyInfo input4;
            ConsoleKeyInfo input5;
           
            do
            {

                input1 = Console.ReadKey();

                while (input1.Key == ConsoleKey.Enter)
                {
                    Screen.DungeonName();

                    input3 = Console.ReadKey();
                    if (input3.Key == ConsoleKey.W)
                    {
                        Console.WriteLine("YOU have entered {0}", Screen.DungeonName());
                        Thread.Sleep(1000);
                        Console.WriteLine(Screen.DungeonLevel(ConsoleKey.W.ToString()));
                        Thread.Sleep(1000);
                        Console.WriteLine("The path is blocked by a pack of " + Screen.MonsterName());
                        Thread.Sleep(1000);
                        Console.WriteLine("Press <T> to Enter Attack GEt you sword out ");
                    
                        input2 = Console.ReadKey();
                        
                        
                            do
                        {
                            do
                            {
                                Console.WriteLine("<G> to Attack them!");
                                Thread.Sleep(1000);
                                Console.WriteLine("BeAwear The can fight back so dont forget to drink HeathPotions with <H> when you have low HP");
                                input4 = Console.ReadKey();
                                if (input4.Key == ConsoleKey.G)
                                {
                                    input = 0;
                                    Screen.Event();
                                    Console.WriteLine(Screen.EventString());
                                    Console.WriteLine(Screen.EnemyRetaliate(input));
                                    Screen.EventForLevelUP();
                                    Kills = Screen.InstanceENd();
                                }

                               else if (input4.Key == ConsoleKey.H)
                                {
                                    input = 1;
                                    Console.WriteLine(Screen.EnemyRetaliate(input));

                                }
                                else
                                {
                                    Console.WriteLine("PRESS ENTER TO MOVE TO THE NEXT LEVEL OF THE DUNGEON");
                                 
                                }
                               

                              
                            } while (Kills != 10);
                            input2 = Console.ReadKey();
                         

                        } while (input2.Key == ConsoleKey.T);


                        
                    }
                    else if (input3.Key != ConsoleKey.W)
                    {
                        Console.WriteLine(Screen.DungeonLevel(ConsoleKey.Q.ToString()));
                    }
                    input1 = Console.ReadKey();
                }
                Console.Clear();
                Console.WriteLine("You have killed the Goblins and collected thier stuff");
                Console.WriteLine("Your running to the NEXT LEVEL");
                while (input1.Key == ConsoleKey.Enter)
                {
                    Screen.DungeonName();

                    input3 = Console.ReadKey();
                    if (input3.Key == ConsoleKey.W)
                    {
                        Console.WriteLine("YOU have entered {0}", Screen.DungeonName());
                        Console.WriteLine(Screen.DungeonLevel(ConsoleKey.W.ToString()));
                        Console.WriteLine("Press T to Enter Attack GEt you sword out");
                        input2 = Console.ReadKey();
                        while (input2.Key == ConsoleKey.T)
                        {
                            input4 = Console.ReadKey();
                            if (input4.Key == ConsoleKey.G)
                            {
                                Screen.Event();
                                Console.WriteLine(Screen.EventString());
                                Screen.EventForLevelUP();
                            }

                            if (input4.Key == ConsoleKey.H)
                            {
                                input = 1;
                                Console.WriteLine(Screen.EnemyRetaliate(input));

                            }
                            else
                            {
                                input4 = Console.ReadKey();
                            }
                        }

                    }
                    else if (input3.Key != ConsoleKey.W)
                    {
                        Console.WriteLine(Screen.DungeonLevel(ConsoleKey.Q.ToString()));
                    }
                    Console.Clear();
                }
            } while (input1.Key != ConsoleKey.Escape) ;




        }
    }
}
