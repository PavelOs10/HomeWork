// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

   

void PrintArrayReversed(int[] array, int index)
    {
    if (index < 0)
        {
        Console.WriteLine();
        return;
        }
        Console.Write(array[index]);
    if (index > 0)
         Console.Write(", ");
        PrintArrayReversed(array, index - 1);
    }

int[] array = { 1, 2, 3, 4, 5 };

PrintArrayReversed(array, array.Length - 1);