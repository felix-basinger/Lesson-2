// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

System.Console.Write("Enter three-digit number: ");
int i = EnterNumber();
Check();
System.Console.WriteLine($"Your second digit is: {FindSecondDigit(i)}");

int EnterNumber()
{   
    
    return int.Parse(System.Console.ReadLine());

}
  
bool Check()
{
    if (i > 999 || i < 100)
    {
        System.Console.WriteLine("Error! It's not three digit number");
    } 
    return false;
}

int FindSecondDigit(int i)
{    
    int FirstDiv = i % 100;
    int SecondDiv = FirstDiv / 10;
    return SecondDiv;
}