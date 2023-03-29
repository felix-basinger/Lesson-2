// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

System.Console.Write("Enter three-digit number: ");
int i = EnterNumber();
if(i < 100 || i >= 1000)
{
    System.Console.WriteLine("Error");
    return;
}
System.Console.WriteLine($"Your second digit is: {FindSecondDigit(i)}");

int EnterNumber()
{   
    return int.Parse(System.Console.ReadLine());
}

int FindSecondDigit(int i)
{    
    int FirstDiv = i % 100;
    int SecondDiv = FirstDiv / 10;
    return SecondDiv;
}