Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int index = 1;
while (index <= num)
{
    int sqrt = index * index * index;
    Console.Write(sqrt + ",");
    index++;
}