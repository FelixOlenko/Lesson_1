Console.Write("Введите число: ");
string paramString = Console.ReadLine();
int paramInt = int.Parse(paramString);


if (paramInt % 2 == 0)
{
    Console.Write("Число чётное: ");
    Console.WriteLine(paramInt);    
}

else 
{
    Console.Write("Число нечётное: ");
    Console.WriteLine(paramInt);    
}
