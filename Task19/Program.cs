// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
int num = new Random().Next(1,10);
int temp, remainder, result = 0;
num = Convert.ToInt32(Console.ReadLine());
temp = num;

while (num>0)
{
    remainder = num % 10;
    result= result*10 + remainder;
    num /= 10;
}

if(temp == result)
{
    Console.WriteLine($"{temp} -> да");
}
else
{
    Console.WriteLine($"{temp} ->  нет");
}
