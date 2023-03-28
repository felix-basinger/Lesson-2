// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

System.Console.Write("Enter a number: ");
int i = int.Parse(Console.ReadLine());
string str = i.ToString();
ThirdDigit();

void ThirdDigit()
{   
    int length = str.Length;
    if(length > 2) System.Console.WriteLine($"Your digit is {str[2]}");
    else System.Console.WriteLine("Error");
}

 