int[] array = { 11, 21, 13, 14, 51, 16, 71, 81, 19 };

int n = array.Length;
int find = 51;
int index = 0;

while (index < n) 
{

    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
}
