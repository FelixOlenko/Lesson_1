Console.Write("Введите первое число: ");
string paramString1 = Console.ReadLine();
int paramInt1 = int.Parse(paramString1);

Console.Write("Введите второе число: ");
string paramString2 = Console.ReadLine();
int paramInt2 = int.Parse(paramString2);

Console.Write("Введите третье число: ");
string paramString3 = Console.ReadLine();
int paramInt3 = int.Parse(paramString3);

int max = paramInt1;

if (max < paramInt2)
{
    max = paramInt2;    
}

if (max < paramInt3)
{
    max = paramInt3;

}

    Console.Write("Максимальное число: ");
    Console.WriteLine(max);
