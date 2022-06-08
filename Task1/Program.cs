Console.Write("Введите первое число: ");
string paramString1 = Console.ReadLine();
int paramInt1 = int.Parse(paramString1);
Console.Write("Введите второе число: ");
string paramString2 = Console.ReadLine();
int paramInt2 = int.Parse(paramString2);


if(paramInt1 < paramInt2)
{
    Console.Write("Большее число = ");
    Console.WriteLine(paramInt2);
    Console.Write("Меньшее число = ");
    Console.WriteLine(paramInt1);

}
else
{
    Console.Write("Большее число = ");
    Console.WriteLine(paramInt1);
    Console.Write("Меньшее число = ");
    Console.WriteLine(paramInt2);
}
