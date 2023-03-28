//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
System.Console.Write("Enter the number of a day: ");
int day = int.Parse(Console.ReadLine());
DayOff();

void DayOff()
{
    if(day == 1 || day == 2 || day == 3 || day == 4 || day == 5)
    {
        System.Console.WriteLine("Not day off");
    }
    else if (day < 0)   
    {
        System.Console.WriteLine("Error! Enter the number of a day");
    }
    else if (day == 6 || day == 7)   
    {
        System.Console.WriteLine("It's a day off!");
    }
    else   
    {
        System.Console.WriteLine("Error! Enter the number of a day");
    }
}   
