using System;
using System.Collections.Generic;

using ConsoleApp1.Name;

using ConsoleApp1.Shield;
using ConsoleApp1.Weapon;

using ConsoleApp1.Potion;
using ConsoleApp1.HealthPotion;
using ConsoleApp1.StrenghtPotion;

using ConsoleApp1.IGetName;
using ConsoleApp1.IUseSkill;

using ConsoleApp1.CombatSkill;
using ConsoleApp1.Hook;
using ConsoleApp1.Energyball;
using ConsoleApp1.Kraccbacc;

using ConsoleApp1.BasePerson;
using ConsoleApp1.Player;
using ConsoleApp1.Tank;
using ConsoleApp1.Rogue;
using ConsoleApp1.Barbar;
using ConsoleApp1.Monster;

using ConsoleApp1.Engine;

namespace Program
{
    

    internal class Program
    {
        static string inputText(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }

        static void Main()
        {
            Engine engine = new Engine(new Random());
            Player player = engine.createPlayer(inputText("Enter you nickname: "), inputText("Enter your new character(barbar, tank, rogue): "));
            Console.Clear();

            string choose2 = inputText(engine.generateWeaponShopText());

            if (engine.checkWeapon(choose2))
            {
                player.setWeapon(engine.createWeapon(choose2));
            }
            else
            {
                Console.WriteLine("Wrong value! Try again!");
                return;
            }

            Console.Clear();

            string choose1 = inputText(engine.generateArmorShopText());

            if (engine.checkArmor(choose1))
            {
                player.setShield(engine.createShield(choose1));
            }
            else
            {
                Console.WriteLine("Wrong value! Try again!");
                return;
            }


            Console.Clear();
            player.showInfo();
            player.showEquipment();
        }
    }
}
