Random random = new Random();
int length = random.Next(10, 20);
int[] mas = new int[length];

for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(1, 20);
    Console.Write($"{mas[i]} ");
}
Console.WriteLine();
int q = 0;
int j=0;
Console.Write("Индекчы элементов число которых больше следущего: ");
for (int i = 0; i < mas.Length-1; i++)
{
    if (mas[i] > mas[i+1])
    {
        Console.Write($"{i} ");
        q++;
    }
}
Console.WriteLine();
Console.WriteLine($"Число таких элементов {q}");

