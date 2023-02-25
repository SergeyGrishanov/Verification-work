// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// Пример массива {"458", "1991", "hello", "world", "mas", "science", "47"};
Console.Clear();

Console.WriteLine("Введите элементы массива через пробел: ");
string EnterArray = Console.ReadLine()!;

string[] array1 = EnterArray.Split(" "); 
string[] array2 = new string[array1.Length];
void ResultArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ResultArray(array1, array2);
PrintArray(array2);