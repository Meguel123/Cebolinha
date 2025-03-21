
Console.Clear();
Console.WriteLine("Escreva cebolinha");
string x = Console.ReadLine()!.ToUpper();
string y = x 
       .Replace("R","L")
;

Console.WriteLine($@"Vc escreveu isso {x} mas Cebolinha falaria assim {y}");
