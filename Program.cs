Console.Clear();
string[] array = Console.ReadLine().Split(" ").Select(x =>Convert.ToString(x)).ToArray();
for(int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3)
    {
        Console.WriteLine(array[i]);
    }
}