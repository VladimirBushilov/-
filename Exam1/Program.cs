Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
if(a == b * b)
{
    Console.WriteLine("первое число Является квадратом второго");
}
else 
{
    Console.WriteLine("первое число не является квадратом второго");
}