// Код по нахождению элемента массива с использованием генератора псевдослучайных чисел с использованием методов 
// (FillArray - заполнение массива, PrintArray - печать массива).

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
// если поискать элемент, которого точно не существует и запустить этот код, выйдет позиция 0. 
// По умолчанию мы указывали позицию 0. Очевидно, что нулевая позиция есть. Если мы ищем
// какой-то элемент, то либо он будет равен 0, либо больше 0. Но если не встречается ни одного
// элемента, то по умолчанию станем возвращать значение -1.Таким образом, если
// запустить наш код, обнаружится значение позиции, равное -1. Это значит, что такой элемент
// не найден.

    while (index<count)
    {
        if (collection [index] == find)
        {
            position = index;
            break;
            // break здесь дается чтобы получить 1 вхождение числа в массиве
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
array [4] = 4;
array [6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array,45);
Console.WriteLine(pos);