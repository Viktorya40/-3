Console.Clear( );
Console.WriteLine("Введите число: ");
string n = Console.ReadLine( );

if (n[0] == n[4] && n[1] == n[3])
    Console.WriteLine ( "Да" );
else 
    Console.WriteLine ( "Нет" );