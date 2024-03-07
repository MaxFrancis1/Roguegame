using Roguegame.Repository;
using Roguegame.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Roguegame
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string name = Initialise.Init();
            List<Enemy> enemies = new List<Enemy>();
            Player player = new Player(name, "Fists");
            bool validInput;

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i); //dev

                RandomService.NewEnemy(out string eName, out int eHealth, out string eWeapon);
                enemies.Add(new Enemy(i, eName, eHealth, eWeapon));
                Console.WriteLine("(Type Attack, Heal or Info)\n");
                Console.WriteLine(player.ReturnInfoAsString());
                Console.WriteLine(enemies[i].ReturnInfoAsString());
                
                string response;
                int enHealth;
                int plHealth;
                //want to create a while loop and get health so as long as its above 0 the player is able to attack.
                do 
                {
                    response = Console.ReadLine().ToUpper();
                    if (response == "ATTACK")
                    {
                        int AttackA = RandomService.RandomDamage(Weapons.returnMaxAttack(player.weapon));
                        enemies[i].Damage(AttackA);
                        Console.WriteLine($"You have attacked the {enemies[i].name} for {AttackA}. The {enemies[i].name} is now at {enemies[i].GetHealth()} health.");
                    }
                    else if (response == "HEAL")
                    {
                        int HealA = RandomService.RandomHeal();
                        player.Heal(HealA);
                        Console.WriteLine($"... You have chosen to heal for {HealA}, dissapointing. Your current health is now {player.GetHealth()}.");
                    }
                    else if (response == "INFO")
                    {
                        do
                        {
                            Console.WriteLine("Please select whether you want information about the 'Player' or 'Enemy'.");
                            response = Console.ReadLine().ToUpper();
                            validInput = false;
                            if (response == "PLAYER")
                            {
                                Console.WriteLine(player.ReturnInfoAsString());
                                validInput = true;
                            }
                            else if (response == "ENEMY")
                            {
                                Console.WriteLine(enemies[i].ReturnInfoAsString());
                                validInput = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter 'Player' or 'Enemy'.");
                            }
                        } while (!validInput);
                    }
                    else { Console.WriteLine("Invalid input. Please enter 'Attack' or 'Heal'."); }
                    enHealth = enemies[i].GetHealth();
                    plHealth = player.GetHealth();
                } while (enHealth > 0 || plHealth > 0);

                if (player.GetHealth() == 0)
                {
                    Console.WriteLine("You have died, do better...");
                    Console.ReadLine();
                } else if (enemies[i].GetHealth() == 0 && RandomService.RandomWeaponDrop())
                {
                    Console.WriteLine($"you have slain the {enemies[i].name} and his weapon has dropped, would you like to pick this up? Y/N");
                    do
                    {
                        response = Console.ReadLine();
                        validInput = false;
                        if (response.ToUpper() == "Y")
                        {
                            player.EquipWeapon(enemies[i].weapon);
                            Console.WriteLine("Weapon equipped.");
                            validInput = true;
                        }
                        else if (response.ToUpper() == "N")
                        {
                            Console.WriteLine("The weapon is left in the mud.");
                            validInput = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter 'Y' or 'N'.");
                        }
                    } while (!validInput) ;
                }
            }
        }
    }
}
