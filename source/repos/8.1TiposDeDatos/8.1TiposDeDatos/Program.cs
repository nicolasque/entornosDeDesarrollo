//Apartado 1
byte edad;
Console.WriteLine("Dime tu nombre:");
string nombre = Console.ReadLine();

Console.WriteLine("Dime tu apellido:");
string apellido = Console.ReadLine();

Console.WriteLine("Dime tu edad:");
edad = Byte.Parse(Console.ReadLine());

Console.WriteLine("Eres: " + nombre + " "+ apellido + " y tienes "+ edad + " años");

// Apartado 2
int numero1;
int numero2;

Console.WriteLine("Dime un numero:");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Dime otro numero:");
numero2 = int.Parse(Console.ReadLine());

Console.WriteLine("La suma de los dos numeros da: " + (numero1 + numero2));
Console.WriteLine("La resta de los dos numeros da: " + (numero1 - numero2));
Console.WriteLine("La multiplicacion de los dos numeros da: " + (numero1 * numero2));
Console.WriteLine("Resto de la divison de los dos numeros da: " + (numero1 % numero2));


//Apartado 3
int gradosCentigrados;
Console.WriteLine("Dime la temperatura en grados Cº:");
gradosCentigrados = int.Parse(Console.ReadLine());

Console.WriteLine("La temperatura en grados kelvin es de:" + (gradosCentigrados + 273));



//Apartado 4
float nota1;
float nota2;
float nota3;

Console.WriteLine("Dime 3 notas:");
Console.WriteLine("Nota 1:");
nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("Nota 2: ");
nota2 = float.Parse(Console.ReadLine());

Console.WriteLine("Nota 3: ");
nota3 = float.Parse(Console.ReadLine());


Console.WriteLine("La suma de las 3 notas da:" + (nota1+nota2+ nota3));
Console.WriteLine("La media de las 3 notas da:" + ((nota1 + nota2 + nota3)/3));


//Apartado 5
float precioArticulo;
float cantidadAarticulo;
Console.WriteLine("Caunto cuesta el articulo: ");
precioArticulo = float.Parse(Console.ReadLine());

Console.WriteLine("Que cantidad quieres comprar:");
cantidadAarticulo  = float.Parse(Console.ReadLine());

Console.WriteLine("Tendras que pagar: " + (precioArticulo * cantidadAarticulo));

