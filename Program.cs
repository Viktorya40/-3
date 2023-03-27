Console.Clear( );
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 5 || n == 5)
Console.WriteLine ($"Будни");
else
Console.WriteLine ($"Выходной");


