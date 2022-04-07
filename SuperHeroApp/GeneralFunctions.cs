using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroApp
{
    internal static class GeneralFunctions
    {
        public static void PrintMenu()
        {
            Console.WriteLine("\n================MENU================");
            Console.WriteLine("1 - Show a list of superheroes and villains");
            Console.WriteLine("2 - Show specific person");
            Console.WriteLine("3 - Add a new a superhero/villain");
            Console.WriteLine("4 - Delete a superhero/villain");
            Console.WriteLine("5 - Show a list of districts");
            Console.WriteLine("6 - Show specific district's info");
            Console.WriteLine("7 - Add hero/villain to a district");
            Console.WriteLine("8 - Remove hero/villain from a district");
            Console.WriteLine("9 - Exit\n");
            Console.Write("Please select from the menu what you would like to do: ");
        }

        public static void PrintHeroesFromList(List<Hero> heroList)
        {
            Console.WriteLine("Heroes: ");
            foreach (Hero hero in heroList)
            {
                Console.WriteLine($"{hero.ID} - {hero.Nickname}");
            }
            Console.WriteLine();

        }

        public static void PrintVillainFromList(List<Villain> villainList)
        {
            Console.WriteLine("Villains: ");
            foreach (Villain villain in villainList)
            {
                Console.WriteLine($"{villain.ID} - {villain.Nickname}");
            }
            Console.WriteLine();

        }

        public static bool PrintPeopleFromList(List<Person> personList)
        {
            if (personList.Count > 0)
            {
                foreach (Person person in personList)
                {
                    Console.WriteLine($"{person.ID} - {person.Nickname}");
                }
                Console.WriteLine();
                return true;
            }
            else { Console.WriteLine("Currently everyone is in districts.\nTry again later"); return false; }
            
        }
    }
}
