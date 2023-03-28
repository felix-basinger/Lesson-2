// System.Console.Write("Enter three-digit number: ");
// int i = EnterNumber();
// System.Console.WriteLine($"Your second digit is: {FindSecondDigit(i)}");

// int EnterNumber()
// {
//     return int.Parse(System.Console.ReadLine());
// }

// int FindSecondDigit(int i)
// {
//     if (i > 999 || i < 100)
//     {
//         while(i > 999 || i < 100)
//         {
//             System.Console.WriteLine("Error! It's not three digit number");
//             return EnterNumber();
//         }
//     }
//     else
//     {
//         int FirstDiv = i % 100;
//         int SecondDiv = FirstDiv / 10;
//         return SecondDiv;
//     }
// }



System.Console.Write("Enter three-digit number: ");
int i = EnterNumber();
Check();
System.Console.WriteLine($"Your second digit is: {FindSecondDigit(i)}");

int EnterNumber()
{
    return int.Parse(System.Console.ReadLine());
}
  
void Check()
{
    while (i > 999 || i < 100)
    {
        System.Console.WriteLine("Error! It's not three digit number");
        EnterNumber();
    }
}

int FindSecondDigit(int i)
{
    int FirstDiv = i % 100;
    int SecondDiv = FirstDiv / 10;
    return SecondDiv;
}