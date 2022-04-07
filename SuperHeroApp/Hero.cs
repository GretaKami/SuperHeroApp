using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroApp
{
    /*
    public enum HerotypeEnum
    {
        Hero,
        Villain
    }
    */
    internal class Hero : Person
    {
        
        //public HerotypeEnum HeroType { get; set; }
        public int DeedTime { get; set; }
        
        
        public Hero() : base()
        {
            
            //HeroType = (HerotypeEnum)0;
            DeedTime = 0;
           
        }

        public Hero (string name, string surname, string nickname, 
            int heroID, int DeedTime) // HerotypeEnum HeroType 
        {
            Name = name;
            Surname = surname;
            Nickname = nickname;
            ID = heroID;
            this.DeedTime = DeedTime;
            PersonType = HeroOrVillain.Hero;
            SuperPowers = new List<string>();

        }

        public override void PrintGeneralInfo()
        {
            base.PrintGeneralInfo();
            Console.WriteLine($"Deed time: {DeedTime}");
            Console.WriteLine($"Hero level: {CalculatedLevel()}");
            
        }

        public override int CalculatedLevel()
        {
            if(DeedTime < 20) { return 1; }
            else if (DeedTime >= 20 && DeedTime < 40) { return 2;}
            else { return 3;}
        }

        public override void PrintFinancialInfo()
        {
            base.PrintFinancialInfo();
            Console.WriteLine($"The hero's daily salary is {CalculatedLevel() * 5}");
            Console.WriteLine($"The hero's monthly salary is {CalculatedLevel() * 5*30}");
            double cookieCost = 1.29;
            double boughtCookies = Math.Floor((CalculatedLevel() * 5 * 30) / cookieCost);
            Console.WriteLine($"The hero can buy {boughtCookies} cookies from his salary");
            
        }

        public void createNewHero(Hero hero, List<Hero> listofheroes, List<Person> listoffreepeople)
        {
            Console.Write("Please enter name: ");
            string newName = Console.ReadLine();
            Console.Write("Please enter surname: ");
            string newSurname = Console.ReadLine();
            Console.Write("Please enter nickname: ");
            string newNickname = Console.ReadLine();
            Console.WriteLine("Please enter 3 superpowers:");
            hero.addSuperpowers(Console.ReadLine());
            hero.addSuperpowers(Console.ReadLine());
            hero.addSuperpowers(Console.ReadLine());
            Console.Write("Please enter deed time: ");
            int.TryParse(Console.ReadLine(), out int newTime);

            hero = new Hero(newName, newSurname, newNickname, listofheroes.Count + 1, newTime);
            listofheroes.Add(hero);
            listoffreepeople.Add(hero);

            Console.WriteLine($"Congratulations! You have added a new superhero \"{newNickname}\"!\n");

        }



    }
}
