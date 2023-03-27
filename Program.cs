Console.Clear( );
Console.Write("Введите трехзначное число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = n1 / 10 % 10;
Console.WriteLine (n2);