// See https://aka.ms/new-console-template for more information

/*
string HeroName = "Smarty-pants";
int HeroAge = 22;
string HeroPower1, HeroPower2, HeroPower3;
HeroPower1 = "hyperthymesia";
HeroPower2 = "learns everything very fast";
HeroPower3 = "can do any mathematical calculation in their head in 0,1s";

Console.WriteLine("><><><><><><><><><><><><>GENERAL INFO<><><><><><><><><><><><><\n");
Console.WriteLine($"Hero name: {HeroName}");
Console.WriteLine($"Hero age: {HeroAge}");
Console.WriteLine($"Hero powers: {HeroPower1}, {HeroPower2}, {HeroPower3}");
Console.WriteLine("\n><><><><><><><><><><><><><><><><><><><><><><><><><\n\n\n");
*/



Console.WriteLine("><><><><><><><><><><><><>FINANCIAL INFO<><><><><><><><><><><><><\n");

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

Console.WriteLine("\n><><><><><><><><><><><><><><><><><><><><><><><><><\n");

