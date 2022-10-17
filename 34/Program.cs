/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/

int [] array = CreateArray (5);
PrintArray(array);
int even=0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2==0 )
    even= even+ 1;
}
Console.Write($"Количество четных чисел = {even}");

int [] CreateArray ( int size)
{
    int [] _array= new int [size];
     for (int i = 0; i < size; i++)
    _array[i]= new Random().Next(100,1000);
    return _array;
    
}

void PrintArray(int [] _array)
{
    Console.Write("[");
    foreach (var item in array)
    Console.Write($"{item} ");
    Console.Write("]");
    Console.WriteLine();
}
    
        
    
