Console.Write("Введите элементы(через пробел): ");
double[] arr = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Кол-во элементов больше нуля: {count}");