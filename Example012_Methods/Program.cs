// Группы методов:

//1 вид. Первая группа методов — не принимает никаких аргументов и ничего не возвращают.
// void Method1()
// {
//     Console.WriteLine("Author...");
// }
// Method1();

//2 вид. Вторая группа методов — принимает какие-то аргументы, но ничего не возвращают.
// void Method2(string msg)
// {
// Console.WriteLine(msg);
// }
// Method2("Text of message");

// void Method21(string msg, int count)
// {
//     int i =0;
//     while(i<count)
//     {
//        Console.WriteLine(msg);
//        i++;
//     }
// }
// Method21(msg: "Text", count: 5);

//3 вид. Третья группа методов — может что-то возвращать, но не принимает никаких аргументов.
//Например, может служить для генерации случайных данных.
//ниже вывод даты-текущего года
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

//4вид.Четвёртая группа методов — что-то принимает (аргументы, данные). И что-то
//возвращает для дальнейшей работы.
//ниже пример вывода строки count раз, с использованием цикла while
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i<count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string result = Method4(10, "Z");
// Console.WriteLine(result);

//ниже пример вывода строки count раз, с использованием цикла for
// string Method41(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string result = Method41(10, "Z");
// Console.WriteLine(result);


//Циклы в цикле, ниже пример вывода таблицы умножения на экран:
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i}*{j} = {i*j}"); 
//     }
//     Console.WriteLine();
// }

//Задача. Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к»
//заменить большими «К», а большие «С» заменить на маленькие «с».
//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.

// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?" ;

// //если будет какая-то строка, то для этой строки есть некоторое количество вспомогательного функционала.
// //если требуется обратиться к конкретному символу строки, мы можем это делать,
// //начиная отсчитывать позицию символов с 0. То есть «q» — это 0, «w» — 1, «e» — 2 и так далее.
// // string s = "qwerty"
// //             012345
// // s[3] = r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replace(text, ' ', '|' );
// newText = Replace(newText, 'к', 'K' );
// newText = Replace(newText, 'с', 'С' );
// Console.WriteLine(newText);

//Задача. Упорядочивание данных внутри массива, алгоритм сортировки методом выбора.Ниже алгоритм:
//1. Найти позицию минимального элемента в неотсортированной части массива.
//2. Произвести обмен этого значения со значением первой неотсортированной позиции.
//3. Повторять пока есть неотсортированные элементы.
// Было: 6 8 3 2 1 4 5 7
// Результат: 1 2 3 4 5 6 7 8
//ниже решение - упорядочивание, начиная с минимального элемента массива
// int [] array = {6, 8, 3, 2, 1, 4, 5, 7};

// void PrintArray(int [] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int [] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i+1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition]) minPosition =j;
//         }
//         int temp = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temp;
//     }
// }
// PrintArray(array);
// SelectionSort(array);
// PrintArray(array);


//ниже решение - упорядочивание, начиная с максимального элемента массива
int [] array = {6, 8, 3, 2, 1, 4, 5, 7};

void PrintArray(int [] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int [] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition =j;
        }
        int temp = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temp;
    }
}
PrintArray(array);
SelectionSort(array);
PrintArray(array);