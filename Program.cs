using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deliverable_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string eventType;
            int tempFar;


            Console.WriteLine("What would you like to do today? Type 1 for Action, 2 for Chilling, 3 for Danger, or 4 for Good Food.");
            eventType = Console.ReadLine();

            if (eventType == "1")
            {
                Console.WriteLine("Go watch some Stock Car Racing");
            }
            else if (eventType == "2")
            {
                Console.WriteLine("Go Hiking!");
            }
            else if(eventType == "3")
            {
                Console.WriteLine("Skydiving is an EXCELLENT idea!");
            }
            else if(eventType == "4")
            {
                Console.WriteLine("To (anywhere BUT) Taco Bell. You're welcome, America.");
            }
            else
            {
                Console.WriteLine("I have no idea what you want to do.");
            }

            Console.WriteLine("How many people are going?");
            tempFar = Convert.ToInt32(Console.ReadLine());

            if (tempFar == 0)
            {
                Console.WriteLine("Just wear sneakers. No one's going anywhere.");
            }
            else if (tempFar >= 1 && tempFar <= 4)
            {
                Console.WriteLine("Take a Sedan to your exciting destination!");
            }
            else if (tempFar >= 5 && tempFar <= 10)
            {
                Console.WriteLine("Hippies would use a Volkswagen bus in this situation. You should too.");
            }
            else if (tempFar >= 11)
            {
                Console.WriteLine("Y'all should take an airplane! You big party planner, you.");
            }
            else
            {
                Console.WriteLine("You can't have negative people, dog.");
            }

            Console.WriteLine("Thank you so much! Enjoy your activity.");

            Console.ReadKey();
        }
    }
}
