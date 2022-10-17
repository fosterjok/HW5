// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int [] array = CreateArray(new Random().Next(4, 11));

PrintArray(array);


int min = array [0];
int max= array [0];
foreach (var item in array)
{  if(item < min)
    min= item;
    if ( item>max)
    max=item;
}
 int r = max- min;
 Console.Write($"{r}");







int [] CreateArray ( int size)
{
    int [] _array= new int [size];
     for (int i = 0; i < size; i++)
    _array[i]= new Random().Next(0,10);
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
