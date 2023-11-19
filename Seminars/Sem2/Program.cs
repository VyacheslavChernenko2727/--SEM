// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98

int DeleteSecondDigit(int num)
{
    int ed = num % 10;
    int sot = num / 100;
    int result = sot * 10 + ed;
    return result;
}
// System.Console.WriteLine("input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
int num = new Random().Next(100, 999);
System.Console.WriteLine(num);
System.Console.WriteLine(DeleteSecondDigit(num));

