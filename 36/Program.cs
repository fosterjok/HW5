// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int [] array = CreateArray(new Random().Next(4, 11));

PrintArray(array);
int sum=0;
for (int i = 0; i < array.Length; i++)
{ if (i % 2 != 0)
  
    sum= sum + array[i];
}

Console.Write($"{sum}");

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
    
        
    
