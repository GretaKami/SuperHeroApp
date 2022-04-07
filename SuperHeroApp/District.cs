using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroApp
{
    internal class District
    {
        public string Title { get; set; }
        public string City { get; set; }
        public int DistrictID { get; set; }
        public List<Person> PeopleInTheDistrict { get; set; }


        public District()
        {
            Title = "No title";
            City = "No city";
            DistrictID = 0;
            PeopleInTheDistrict = new List<Person>();

        }

        public District(string title, string city, int districtID)
        {
            Title = title;
            City = city;
            DistrictID = districtID;
            PeopleInTheDistrict = new List<Person>();
        }

        
        public void addNewPerson(Person person)
        {
            PeopleInTheDistrict.Add(person);   
        }

        public void addNewPerson(List<Person> personList, List<District> districtList)
        {
            Console.WriteLine("List of free heroes and villains");
            foreach (Person person in personList)
            {
                Console.WriteLine($"{person.ID} - {person.Nickname} ({person.PersonType})");
            }
            Console.Write("\nPlease enter ID number of the person you want to add to a district: ");
            int.TryParse(Console.ReadLine(), out int personID);

            Console.WriteLine("List of districts: ");
            foreach (District district in districtList)
            {
                Console.WriteLine($"{district.DistrictID} - {district.Title} ");
            }
            Console.Write("\nPlease enter ID number of the district you want to add to: ");
            int.TryParse(Console.ReadLine(), out int districtID);

            foreach (Person person in personList)
            {
                if (personID == person.ID)
                {
                    foreach (District district in districtList)
                    {
                        if (districtID == district.DistrictID)
                        {
                            district.addNewPerson(person);
                            personList.Remove(person);
                            Console.WriteLine($"\n{person.Nickname} successfully added to {district.Title} district!");
                            break;
                        }
                    }
                    break;
                }
            }
        }

        public void removePerson (int ID)
        {
            PeopleInTheDistrict.RemoveAt(ID - 1);
        }

        public void removePerson (Person person)
        {
            PeopleInTheDistrict.Remove(person);
        }

        public void removePerson(List<Person> personList, List<District> districtList)
        {
            foreach(District district in districtList)
            {
                Console.WriteLine($"{district.DistrictID} - {district.Title}");
                district.PrintPeopleInDistrict();
                Console.WriteLine();
            }

            Console.Write("\nPlease enter ID number of the district you want to remove from: ");
            int.TryParse(Console.ReadLine(), out int districtID);

            Console.Write("\nPlease enter the nickname the person you want to remove from a district: ");
            string personNickname = Console.ReadLine();

            foreach(District district in districtList)
            {
                if(district.DistrictID == districtID)
                {
                    foreach(Person person in district.PeopleInTheDistrict)
                    {
                        if(person.Nickname == personNickname)
                        {
                            district.PeopleInTheDistrict.Remove(person);
                            personList.Add(person);
                            break;
                        }
                    }
                    break;
                }
            }


        }

       
        public float calculateAvgLevelInDistrict()
        {
            float levelSum = 0f;
            int numberOfheroes = 0;
            foreach(Person person in PeopleInTheDistrict)
            {
                if(person is Hero) 
                { 
                    levelSum += person.CalculatedLevel(); 
                    numberOfheroes++;
                }
                
            }
                       
            return levelSum/numberOfheroes;
        }

        public void PrintPeopleInDistrict()
        {
            Console.WriteLine("List of people in the district:");
            foreach (Person person in PeopleInTheDistrict)
            {
                Console.WriteLine($"{person.ID} - {person.Nickname} ({person.PersonType})");
            }
        }
        public void PrintDistrictInfo()
        {
            int totalDeedTime = 0;
            int totalCrimeTime = 0;
            int maxDeedTime = 0;
            int maxCrimeTime = 0;
            string bestHero = "";
            string worstVillain = "";
            Console.WriteLine("\n=====================DISTRICT=INFO=====================\n");
            Console.WriteLine($"Title: {Title}\n" +
                              $"City: {City}\n" +
                              $"District ID: {DistrictID}\n" +
                              $"\nHeroes in the district: ");
            
            foreach(Person person in PeopleInTheDistrict)
            {
                if(person is Hero) 
                { 
                    Console.WriteLine($"{person.ID} - {person.Nickname}");
                    Hero hero = (Hero)person;
                    totalDeedTime += hero.DeedTime;
                    if (hero.DeedTime > maxDeedTime)
                    {
                        maxDeedTime = hero.DeedTime;
                        bestHero = hero.Nickname;
                    }
                }
                
            }
            Console.WriteLine("\nVillains in the district: ");
            foreach (Person person in PeopleInTheDistrict)
            {
                if(person is Villain) 
                { 
                    Console.WriteLine($"{person.ID} - {person.Nickname}"); 
                    Villain villain = (Villain) person;
                    totalCrimeTime += villain.CrimeTime;
                    if(villain.CrimeTime > maxCrimeTime)
                    {
                        maxCrimeTime = villain.CrimeTime;
                        worstVillain = villain.Nickname;
                    }
                }
                
            }
            Console.WriteLine($"\nTotal deed time is: {totalDeedTime}");
            Console.WriteLine($"Total crime time is: {totalCrimeTime}");
            Console.WriteLine($"\nThe best hero is {bestHero} with a deed time of {maxDeedTime}");
            Console.WriteLine($"The worst villain is {worstVillain} with a crime time of {maxCrimeTime}");
            Console.WriteLine("\n======================================================\n");
        }
    }
}
