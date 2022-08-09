Console.Clear();

Console.WriteLine("Write numberOne");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Write numberTwo");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberOne == numberTwo * numberTwo)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}