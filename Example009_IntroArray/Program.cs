// ниже команды для вывода определенного элемента массива, в [] индекс элемента массива, через Console.WriteLine будет выведено значние в заданном индексе массива
// в строке array [0] = 55 - каким образом можно обратиться к массиву и записать его значение
// в строке Console.WriteLine(array[0]) - каким образом можно обратиться к массиву и получить значение соответ-го элемента по указанному индексу
// int[] array = { 11, 21, 13, 14, 51, 16, 71, 81, 19 };
// array [0] = 55;
// Console.WriteLine(array[0]);


// int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
// Console.WriteLine(max);

// ниже поиск максимума из 9 значений массива
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int[] array = { 11, 21, 13, 14, 51, 16, 71, 81, 159 };

int max = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8])    
);
Console.WriteLine(max);