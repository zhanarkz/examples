int [] array = {10, 25, 13, 43, 53, 65, 76, 84,10};

int n = array.Length;
int find = 10;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index+1;
    index++;
}