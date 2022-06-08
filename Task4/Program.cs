Console.Write("Введите число: ");
string paramString = Console.ReadLine();
int paramInt = int.Parse(paramString);

for (int i = 2; i <= paramInt; i += 2) Console.WriteLine(i);