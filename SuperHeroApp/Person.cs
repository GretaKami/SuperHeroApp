using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroApp
{
    public enum HeroOrVillain
    {
        Hero,
        Villain
    }
    internal class Person
    {
        public string Name { get; set; }
        public string Surname {  get; set; }
        public string Nickname { get; set; }
        public int ID { get; set; }
        public List<string> SuperPowers { get; set; }
        public HeroOrVillain PersonType { get; set; }

        public Person()
        {
            Name = "John";
            Surname = "Doe";
            Nickname = "Anonymous";
            ID = 0;
            PersonType = HeroOrVillain.Hero;
            SuperPowers = new List<string>();
            SuperPowers.Add("No superpowers");
        }

        public Person(string name, string surname, string nickname,
            int id, HeroOrVillain type)
        {
            Name = name;
            Surname = surname;
            Nickname = nickname;    
            ID = id;  
            PersonType = type;
            SuperPowers = new List<string>();
        }

        

        public virtual void PrintGeneralInfo()
        {
            Console.WriteLine("\n=====================GENERAL=INFO=====================\n");
            Console.WriteLine($"Person type: {PersonType}\n" +
                              $"ID: {ID}\n" +
                              $"Name: {Name}\n" +
                              $"Surname: {Surname}\n" +
                              $"Nickname: {Nickname}\n" +
                              $"Powers:");
            foreach (string power in SuperPowers)
            {
                Console.WriteLine($" - {power}");
            }
            
            
        }

        public virtual void PrintFinancialInfo()
        {

            Console.WriteLine("\n===================FINANCIAL=INFO===================\n");
            
        }

        public void addSuperpowers(string power)
        {
            SuperPowers.Add(power);
        }

        public void addSuperpowers(string power1, string power2)
        {
            SuperPowers.Add(power1);
            SuperPowers.Add(power2);
        }

        public void addSuperpowers(string power1, string power2, string power3)
        {
            SuperPowers.Add(power1);
            SuperPowers.Add(power2);
            SuperPowers.Add(power3);
        }

        public virtual int CalculatedLevel()
        {
            return 0;
        }




    }
}
