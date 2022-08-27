Console.WriteLine("Введите цифру от 1 до 7, обозначающую день недели, чтобы узнать, является ли этот день выходным:");
int a = int.Parse(Console.ReadLine());

while (a < 1 || a > 7)
{
    Console.WriteLine("Введите цифру от 1 до 7:");
    a = int.Parse(Console.ReadLine());
}

if (a > 0 && a < 6)
{
    Console.WriteLine(a + "-> рабочий");
}
else
{
    Console.WriteLine(a + "-> выходной");
}