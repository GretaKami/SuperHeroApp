using SuperHeroApp;

bool menuRunning = true;

Hero Superman = new Hero("Clark", "Kent", "Superman", 1, 40); // "X-ray vision", "Laserbeam", "Can fly"; (HerotypeEnum)0
Hero Batman = new Hero("John", "Wane", "Batman", 2, 20); // "Has cool gadgets", "Sense of justice", "Wears all black"
Hero SmartyPants = new Hero("Greta", "Kami", "Smarty-pants", 3, 35); //"hyperthymesia", "learns everything very fast", "can do any mathematical calculation in their head in 0,1s"
Villain Joker = new Villain("Arthur", "Fleck", "Joker", 1, 15); // "Crazy", "Unpredictible", "Has many clown minions"
Villain Loki = new Villain("Loki", "Odinoon", "Loki", 2, 40);
Superman.addSuperpowers("X-ray vision", "Laserbeam", "Can fly");
Batman.addSuperpowers("Has cool gadgets", "Sense of justice", "Wears all black");
SmartyPants.addSuperpowers("hyperthymesia", "learns everything very fast", "can do any mathematical calculation in their head in 0,1s");
Joker.addSuperpowers("Crazy", "Unpredictible", "Has many clown clown minions");
Loki.addSuperpowers("Teleportation", "Can create illiusions", "Very smart");

District Gotham = new District("Gotham", "Metropole", 1);
Gotham.addNewPerson(Superman);
Gotham.addNewPerson(SmartyPants);
Gotham.addNewPerson(Joker);

District Silvercity = new District("Silvercity", "Metropole", 2);
Silvercity.addNewPerson(Batman);
Silvercity.addNewPerson(Loki);

Hero hero = new Hero();
Villain villain = new Villain();

List<Hero> listOfHeroes = new List<Hero> { Superman, Batman, SmartyPants };
List<Villain> listOfVillains = new List<Villain> { Joker, Loki};
List<District> listOfDistricts = new List<District> { Gotham, Silvercity };
List<Person> listOfFreePeople = new List<Person>();

Console.WriteLine("Welcome to the SuperHero application!");
do
{
    
    GeneralFunctions.PrintMenu();
    string menuAction = Console.ReadLine();

    switch (menuAction)
    {
        case "1":
            Console.WriteLine("\n==============SUPERHERO=AND=VILLAIN=LIST==============");
            GeneralFunctions.PrintHeroesFromList(listOfHeroes);
            GeneralFunctions.PrintVillainFromList(listOfVillains);
            
            break;

        case "2":
            Console.WriteLine("\n==============SUPERHERO/VILLAIN=INFORMATION==============");
            Console.WriteLine("Please select if you wnat to know more about heroes or villains\n" +
                "Enter 1 for heroes\n" +
                "Enter 2 for villains");
            int.TryParse(Console.ReadLine(), out int selection);

            int selectedID = 0;
            switch (selection)
            {
                case 1:
                    GeneralFunctions.PrintHeroesFromList(listOfHeroes);
                    Console.Write("Please write the ID number of the superhero that you want to know more about: ");
                    int.TryParse(Console.ReadLine(), out selectedID);
                    Console.WriteLine($"Please select from the menu what you want to know about {listOfHeroes[selectedID - 1].Nickname}");
                    break;
                case 2:
                    GeneralFunctions.PrintVillainFromList(listOfVillains);
                    Console.Write("Please write the ID number of the villain that you want to know more about: ");
                    int.TryParse(Console.ReadLine(), out selectedID);
                    Console.WriteLine($"Please select from the menu what you want to know about {listOfVillains[selectedID - 1].Nickname}");
                    break;
                default:
                    Console.WriteLine("Incorrect number");
                    break;

            }
                        
            Console.WriteLine("1 - General info");
            Console.WriteLine("2 - Financial info");
            int.TryParse(Console.ReadLine(), out int menuItem);

            switch (menuItem)
            {
                case 1:
                    if (selection == 1) { listOfHeroes[selectedID - 1].PrintGeneralInfo(); }
                    else if (selection == 2) { listOfVillains[selectedID - 1].PrintGeneralInfo(); }                 
                    break;
                case 2:
                    if (selection == 1) { listOfHeroes[selectedID - 1].PrintFinancialInfo(); }
                    else if (selection == 2) { listOfVillains[selectedID - 1].PrintFinancialInfo(); }
                    break;
                default:
                    Console.WriteLine("Incorrect number");
                    break;
            }
            break;

        case "3":
            Console.WriteLine("\n===============NEW=SUPERHERO/VILLAIN==================");
            Console.WriteLine("Would you like to create a new superhero or a new villain?\n" +
                "For a new superhero write 1\n" +
                "For a new villain write 2");
            int.TryParse(Console.ReadLine(), out int villainOrHero);
            
           
            switch (villainOrHero)
            {
                case 1:
                    // Hero Console.ReadLine() = new Hero();
                    hero.createNewHero(hero, listOfHeroes, listOfFreePeople); 
                    break;
                case 2:
                    villain.createNewVillain(villain, listOfVillains, listOfFreePeople);
                    break;
                default:
                    Console.WriteLine("Incorrect number");
                    break;
            }
            
            break;
        case "4":
            Console.WriteLine("\n===============DELETE=SUPERHERO/VILLAIN==================");
            Console.WriteLine("*** You can only delete heroes and villains that aren't in any district! ***");

            Console.WriteLine("List of free heroes and villains: ");
            GeneralFunctions.PrintPeopleFromList(listOfFreePeople);

            Console.Write("Please enter the nickname of the person you want to delete: ");
            string deletePerson = Console.ReadLine();

            foreach(Person person in listOfFreePeople)
            {
                if(person.Nickname == deletePerson)
                {
                    Console.WriteLine($"You have successfully deleted \"{person.Nickname}\"!");
                    listOfFreePeople.Remove(person);
                }
                break;
            }
            
            break;
        case "5":
            Console.WriteLine("\n===================DISTRICTS====================");
            string bestDistrictName = "";
            float bestAvgDistrictLevel = 0f;
            foreach (District district in listOfDistricts)
            {
                Console.WriteLine($"{district.DistrictID} - {district.Title} ({district.PeopleInTheDistrict.Count} people)");
                if(district.calculateAvgLevelInDistrict() > bestAvgDistrictLevel)
                {
                    bestAvgDistrictLevel = district.calculateAvgLevelInDistrict();
                    bestDistrictName = district.Title;
                }
            }
            Console.WriteLine($"\nThe strongest district is: {bestDistrictName} with an average level of {bestAvgDistrictLevel}");
            Console.WriteLine("=====================================================\n");
            break;
        case "6":
            Console.WriteLine("\n===================LIST=OF=DISTRICTS===================\n");
            foreach (District district in listOfDistricts)
            {
                Console.WriteLine($"{district.DistrictID} - {district.Title} ");
            }
            Console.Write("Please enter ID number of the district you want to know more about: ");
            int.TryParse(Console.ReadLine(), out int wantedDistrict);

            foreach(District district in listOfDistricts)
            {
                if(district.DistrictID == wantedDistrict) 
                { 
                    district.PrintDistrictInfo();
                    Console.WriteLine($"Average level in the district is: {district.calculateAvgLevelInDistrict()}");
                }
            }
            Console.WriteLine("=====================================================\n");
            break;
        case "7":
            Console.WriteLine("\n===================ADD=TO=DISTRICT===================\n");
            if (listOfFreePeople.Count > 0)
            {
                Gotham.addNewPerson(listOfFreePeople, listOfDistricts);

            }
            else
            {
                Console.WriteLine("Currently there are no free heroes or villains. \nPlease try again later\n");
                Console.WriteLine("===========================================\n");
            }
           
            break;
        case "8":
            Console.WriteLine("===================REMOVE=FROM=DISTRICT===================\n");
            Gotham.removePerson(listOfFreePeople, listOfDistricts);

            break;
        case "9":
            Console.WriteLine("Thank you for using SuperHero application! Goodbye!");
            menuRunning = false;
            break;
        default:
            Console.WriteLine("Please enter a correct number");
            Console.WriteLine("===========================================\n");
            break;
    }

}
while (menuRunning == true);


/*
//GENERAL INFO
string HeroName = "Smarty-pants";
int HeroAge = 22;
string HeroPower1, HeroPower2, HeroPower3;
HeroPower1 = "hyperthymesia";
HeroPower2 = "learns everything very fast";
HeroPower3 = "can do any mathematical calculation in their head in 0,1s";

Console.WriteLine("=====================GENERAL=INFO=====================\n");
Console.WriteLine($"Hero name: {HeroName}");
Console.WriteLine($"Hero age: {HeroAge}");
Console.WriteLine($"Hero powers: {HeroPower1}, {HeroPower2}, {HeroPower3}");
Console.WriteLine("\n====================================================\n\n");


//FINANCIAL INFO
Console.WriteLine("===================FINANCIAL=INFO===================\n");

int workingHoursInDay;
Console.Write("Please enter hero working hours: ");
int.TryParse(Console.ReadLine(), out workingHoursInDay);
int dailySalary = 0;

if (workingHoursInDay <0 && workingHoursInDay > 24)
{
    bool correctHours = false;
    while (correctHours == false)
    {
        Console.WriteLine("Please enter correct working hours");
        int.TryParse(Console.ReadLine(), out workingHoursInDay);

        if (workingHoursInDay > 0 && workingHoursInDay <= 24)
        {
            correctHours = true;
        }

    }
    
}

if (workingHoursInDay <= 8)
{
    dailySalary = workingHoursInDay * 10;
}
else if (workingHoursInDay > 8)
{
    dailySalary = 80 + (workingHoursInDay - 8) * 15;
}

Console.WriteLine($"The hero's daily salary is {dailySalary}");
Console.WriteLine($"The hero's monthly salary is {dailySalary * 30}");


int deedTimeInHours1 = 5;
int deedTimeInHours2 = 8;
int deedTimeInHours3 = 3;

int totalTimeSpentOnDeeds = deedTimeInHours1 + deedTimeInHours2 + deedTimeInHours3;
double averageTimeSpentOnDeeds = Math.Round((double) totalTimeSpentOnDeeds / 3, 2);
int rewardCookies = totalTimeSpentOnDeeds * 5;
Console.WriteLine($"Total time spent on deeds was : {totalTimeSpentOnDeeds}");
Console.WriteLine($"Average time spent on deeds was: {averageTimeSpentOnDeeds}");
Console.WriteLine($"Reward in cookies for good deeds: The hero recieved {rewardCookies} cookies!");

double cookieCost = 1.29;
double boughtCookies = Math.Floor(dailySalary*30 / cookieCost);
Console.WriteLine($"The hero can buy {boughtCookies} cookies from his salary");

bool isEvil = false;
if (!isEvil)
{
    Console.WriteLine("The hero does good deeds and earns his cookies");
}
else
{
    Console.WriteLine("The hero is actually a vilain and steels from cookie supply");
}

Console.WriteLine("\n====================================================\n");

*/



