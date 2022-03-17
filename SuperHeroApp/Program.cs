
bool menuRunning = true;
string[] superHeroArray = { "Smarty-pants", "Flash", "Captain Marvel", "Black widow" };
do
{
    Console.WriteLine("Welcome to the SuperHero application!");
    Console.WriteLine("Please select from the menu what you would like to do:");
    Console.WriteLine("1 - Show a list of superheroes");
    Console.WriteLine("2 - Show specific hero");
    Console.WriteLine("3 - Add a new a superhero");
    Console.WriteLine("4 - Delete a superhero");
    Console.WriteLine("5 - Exit");

    string menuAction = Console.ReadLine();

    switch (menuAction)
    {
        case "1":
            Console.WriteLine("==============SUPERHERO=LIST==============");
            for (int i = 0; i < superHeroArray.Length; i++)
            {
                Console.WriteLine($"{i}. {superHeroArray[i]}");
            }
            Console.WriteLine("===========================================");
            break;
        case "2":
            Console.WriteLine("==============SUPERHERO=INFORMATION==============");
            Console.WriteLine("Please write the ID number of the superhero that you want to know more about");
            Console.WriteLine("List of heroes:");
            for (int i = 0; i < superHeroArray.Length; i++)
            {
                Console.WriteLine($"{i}. {superHeroArray[i]}");
            }
            
            
            int.TryParse(Console.ReadLine(), out int superHeroID);
            Console.WriteLine($"Please select from the menu what you want to know about {superHeroArray[superHeroID]}");
            Console.WriteLine("1 - General info");
            Console.WriteLine("2 - Financial info");
            int.TryParse(Console.ReadLine(), out int menuItem);

            switch (menuItem)
            {
                case 1:
                    Console.WriteLine("=====================GENERAL=INFO=====================\n");
                    Console.WriteLine($"Hero name: {superHeroArray[superHeroID]}");
                    Console.WriteLine($"Hero age: 22");
                    Console.WriteLine($"Hero powers: HeroPower1, HeroPower2, HeroPower3");
                    Console.WriteLine("\n====================================================\n");
                    break;
                case 2:
                    Console.WriteLine("===================FINANCIAL=INFO===================\n");
                    double dailySalary2 = 80;
                    Console.WriteLine($"The hero's daily salary is {dailySalary2}");
                    Console.WriteLine($"The hero's monthly salary is {dailySalary2 * 30}");
                    double cookieCost2 = 1.29;
                    double boughtCookies2 = Math.Floor(dailySalary2 * 30 / cookieCost2);
                    Console.WriteLine($"The hero can buy {boughtCookies2} cookies from his salary");
                    Console.WriteLine("===========================================\n");

                    break;
                default:
                    Console.WriteLine("Incorrect number");
                    break;
            }
            break;

        case "3":
            Console.WriteLine("===============NEW=SUPERHERO==================");
            Console.WriteLine("Please enter the name of the new superhero!");
            string newSuperHero = Console.ReadLine();

            List<string> list2 = new List<string>(superHeroArray);
            list2.Add(newSuperHero);             
            superHeroArray = list2.ToArray();             

            break;
        case "4":
            Console.WriteLine("===============DELETE=SUPERHERO==================");
            
            for (int i = 0; i < superHeroArray.Length; i++)
            {
                Console.WriteLine($"{i}. {superHeroArray[i]}");
            }
            Console.WriteLine("\n Please enter the number of the hero that you want to delete");
            int deleteHeroNumber = Convert.ToInt32(Console.ReadLine());

            List <string> list = new List<string>(superHeroArray);
            list.RemoveAt(deleteHeroNumber);            
            superHeroArray = list.ToArray();

            Console.WriteLine("You have successfully deleted the hero");
            Console.WriteLine("===========================================");

            break;
        case "5":
            Console.WriteLine("Thank you for using SuperHero application! Goodbye!");
            menuRunning = false;
            break;
        default:
            Console.WriteLine("Please enter a correct number");
            Console.WriteLine("===========================================");
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