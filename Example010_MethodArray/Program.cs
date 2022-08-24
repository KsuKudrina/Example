//
int[] array = {14, 62, 53, 49, 5, 16, 7, 28};

int n = array.Length;
int find = 28;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;
}
