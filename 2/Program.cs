// Напишите программу, которая принимает на вход 
//число и выдаёт сумму цифр в числе.
//задача 2
int Input (string message)
{
    System.Console.WriteLine(message + ":");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int Sum(int number)
{
    int sum = 0;
    while(number > 0)
    {
        int digit = number % 10;
        sum = sum + digit;
        number = number / 10;
    }
    return sum;
}
int number = Input("введите число");
System.Console.WriteLine(Sum(number));