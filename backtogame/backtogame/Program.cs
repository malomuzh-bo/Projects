List<int> ints = new List<int>(10);
List<int> ints1 = new List<int>();

Random random = new Random();

for (int i = 0; i < ints.Capacity; i++)
{
    ints.Add(random.Next(1, 20));
}

for (int i = 0; i < ints.Capacity; i++)
{
    if (ints[i] % 2 == 0)
    {
        ints1.Add(i);
    }
}

Console.WriteLine("Array 1:");
foreach (var i in ints)
{
    Console.WriteLine(i);
}

Console.WriteLine("Array 2:");
foreach (var i in ints1)
{
    Console.WriteLine(i);
}