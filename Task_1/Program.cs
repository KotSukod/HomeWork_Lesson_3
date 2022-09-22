Console.Write("Введите пятизначное число:");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 10000) Console.WriteLine("Число меньше пяти знаков");
int[] numbers = new int[5];

int num1 = (num / 10000);
numbers[0] = num1;
int num2 = ((num - (num1 * 10000)) / 1000);
numbers[1] = num2;
int num3 = ((num - (num1 * 10000)-(num2 * 1000)) / 100);
numbers[2] = num3;
int num4 = ((num - (num1 * 10000)-(num2 * 1000)-(num3 * 100)) / 10);
numbers[3] = num4;
int num5 = num % 10;
numbers[4] = num5;

if (numbers[0] == numbers[4])
{
    if (numbers[1] == numbers[3]) 
    {
        Console.WriteLine("Число является палиндромом");
    }
    
}
else Console.WriteLine("Число не является палиндромом");


