using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroApp
{
    internal class Villain : Person
    {
        
        //public VillaintypeEnum VillainType { get; set; }
        public int CrimeTime { get; set; }
        


        public Villain() 
        {
            Name = "John";
            Surname = "Doe";
            Nickname = "Anonymous";
            ID = 0;
            PersonType = HeroOrVillain.Hero;
            SuperPowers = new List<string>();
            SuperPowers.Add("No superpowers");
            PersonType = HeroOrVillain.Villain;
            CrimeTime = 0;

        }

        public Villain(string name, string surname, string nickname,
            int villainID, int crimeTime) 
        {
            Name = name;
            Surname = surname;
            Nickname = nickname;
            ID = villainID;
            PersonType = HeroOrVillain.Villain;
            SuperPowers = new List<string>();
            CrimeTime = crimeTime;

        }

        public override void PrintGeneralInfo()
        {
            base.PrintGeneralInfo();
            Console.WriteLine($"Crime time: {CrimeTime}");
            Console.WriteLine($"Villain level: {CalculatedLevel()}");
            
        }

        public override int CalculatedLevel()
        {
            if (CrimeTime < 20) { return 1; }
            else if (CrimeTime >= 20 && CrimeTime < 40) { return 2; }
            else { return 3; }
        }

        public override void PrintFinancialInfo()
        {
            base.PrintFinancialInfo();
            Console.WriteLine($"The villain's daily salary is {CalculatedLevel() * 5}");
            Console.WriteLine($"The villain's monthly salary is {CalculatedLevel() * 5 * 30}");
            double cookieCost = 1.29;
            double boughtCookies = Math.Floor((CalculatedLevel() * 5 * 30) / cookieCost);
            Console.WriteLine($"The villain can buy {boughtCookies} cookies from his salary");
            
        }

        public void createNewVillain(Villain villain, List<Villain> list, List<Person> listoffreepeople)
        {
            Console.Write("Please enter name: ");
            string newName = Console.ReadLine();
            Console.Write("Please enter surname: ");
            string newSurname = Console.ReadLine();
            Console.Write("Please enter nickname: ");
            string newNickname = Console.ReadLine();
            Console.WriteLine("Please enter 3 superpowers:");
            villain.addSuperpowers(Console.ReadLine());
            villain.addSuperpowers(Console.ReadLine());
            villain.addSuperpowers(Console.ReadLine());
            Console.Write("Please enter crime time: ");
            int.TryParse(Console.ReadLine(), out int newTime);

            villain = new Villain(newName, newSurname, newNickname, list.Count + 1, newTime);
            list.Add(villain);
            listoffreepeople.Add(villain);

            Console.WriteLine($"Congratulations! You have added a new villain \"{newNickname}\"!\n");

        }
    }
}
