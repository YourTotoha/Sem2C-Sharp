int[] array = { 1, 232, 37, 12, 35, 66, 75, 84, 12 };

int n = array.Length;
int find = 12;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}