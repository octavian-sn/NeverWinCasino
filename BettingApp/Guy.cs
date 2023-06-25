using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerClasses
{
    internal class Player
    {
        public string Name { get; set; }

        public int Cash { get; set; }

        public Player(string name, int cash) { Name = name; Cash = cash; }

        public void WriteMyInfo()
        {
            Console.WriteLine($"My name is {Name} and I have {Cash} dollars.");
        }

        public int GiveCash(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine(Name + " says: " + amount + " isn't a valid amount");
                return 0;
            }
            if (amount > Cash)
            {
                Console.WriteLine(Name + " says: " + amount + " is too much, I don't have that much money!");
                return 0;
            }

            Cash -= amount;
            return amount;
        }

        public void ReceiveCash(int amount)
        {
            Cash += amount;
            Console.WriteLine($"{Name}: I got {amount} dollars! Awesome!");
        }
    }
}
