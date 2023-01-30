//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B. 
//Реализовать через функции.
// задача 1
int Input (string message)
{
    System.Console.WriteLine(message + ":");
    int number1 = Convert.ToInt32(Console.ReadLine());
    return number1;
} 
int Pow(int number1, int number2)
{
    int cou = number1;
    int result = number1;
    if (number2 > 0)
    {
        for (int i = 1; i < number2; i++)
        {
            result = result * cou;
        }
    }
    if (number2 == 0)
    {
        result = 1;
    }

    return result;
}
int number1 = Input("введите основание числа");
int number2 = Input("введите показатель числа");
if (number2 >= 0)
{
    System.Console.WriteLine(Pow(number1, number2));
}
else{
    System.Console.WriteLine("требуется ввести натуральные числа");
}
