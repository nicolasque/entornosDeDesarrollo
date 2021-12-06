int numero1;
int numero2;
int numeroSuma;
int numeroMultiplicacion;

Console.WriteLine("Dime 1 numero");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Dime otro numero");
numero2 = int.Parse(Console.ReadLine());

numeroSuma = numero1 + numero2;
numeroMultiplicacion = numero1 * numero2;

Console.WriteLine("La suma da: " + numeroSuma);
Console.WriteLine("La multiplicacion da: " + numeroMultiplicacion);