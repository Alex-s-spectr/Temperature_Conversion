// See https://aka.ms/new-console-template for more information
Console.WriteLine("Degré Celsius : "); 
 
int Celsius = int.Parse(Console.ReadLine()) ;

Console.WriteLine($"Degré Fahrenheit : {(Celsius * 9/5)+32 }"+"°F");
