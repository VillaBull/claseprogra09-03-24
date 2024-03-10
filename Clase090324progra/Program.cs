Console.WriteLine("Piensa en un número, y te diré cuál es...");

Console.Write("Por favor, anota un número cualquiera: ");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine("vamos a multiplicar el numero por 2");
int paso1 = numero * 2;
Console.Read();
Console.WriteLine("Ahora vamos a sumarle 8");
Console.Read();
int paso2 = paso1 + 8;
Console.Read();
Console.WriteLine("Ahora lo vamos a multiplicarlo por 5");
Console.Read();
int paso3 = paso2 * 5;
Console.Read();
Console.WriteLine(" el resultado final: "+ paso3);

// Anulamos la última cifra
int resultadoAdivinado = (paso3 / 10);
Console.WriteLine("lo dividimos en 10");
Console.Read();
// Restamos 4 al resultado
resultadoAdivinado -= 4;
Console.WriteLine("le restamos 4");
Console.Read();

Console.WriteLine("El número que pensaste es: " + resultadoAdivinado);