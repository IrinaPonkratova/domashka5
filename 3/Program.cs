//Напишите программу, которая выводит массив из 8 элементов, 
//заполненный случайными числами. 
//Оформите заполнение массива и вывод в виде функции 
int [] CreateArray(int size)
{
    int [] mass = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = rnd.Next(0, 100);
    }
    return mass;
}
void PrintArray (int []array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++ )
    {
        
        System.Console.Write(array[i] + " ");
    }
    System.Console.Write("]");

}
int [] array = CreateArray(8);
PrintArray(array);
