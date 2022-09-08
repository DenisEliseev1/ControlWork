string[] arrayWorld = new string[6];
int lenghtArray = 0;
for (int i = 0; i < 6; i++)
{
    Console.WriteLine($"Напишите слово {i + 1}");
    arrayWorld[i] = Console.ReadLine();
    if (arrayWorld[i].Length <= 3)
    {
        lenghtArray++;
    }
}
string[] arrayMin = new string[lenghtArray];
Console.WriteLine("Массив:");
PrintArray (arrayWorld);
lenghtArray = 0;
for (int i = 0; i < 6; i++)
{
    if (arrayWorld[i].Length <= 3)
    {
        arrayMin[lenghtArray] = arrayWorld[i];
        lenghtArray++;
    }
}
Console.WriteLine();
Console.WriteLine("Ответ:");
PrintArray (arrayMin);

void PrintArray(string [] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write ($"{array [i]}  ");
    }
}