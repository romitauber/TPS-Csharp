using System;


//EJERCICIO 1

short numero = 150;
numero += 5;
Console.WriteLine(numero);

string nombre = "Romina";
string apellido = "Tauber";
// string nombreCompleto = nombre + apellido; --> concatena simple
// string nombreCompleto = $"{nombre, -10} {apellido, 10}"; --> le agrega espacios
string nombreCompleto = $"Hola {nombre} {apellido}"; // le podes agregar mas palabras de contexto

Console.WriteLine(nombreCompleto);

//EJERCICIO 2

//Evaluar si dos números son iguales diferentes mayor o menor

int num1 = 20;
int num2 = 150;

if (num1==num2)
{
    Console.WriteLine("Son iguales");
} else if (num1>num2) {
    Console.WriteLine($"Son distintos y {num1} es mayor que {num2}");
} else {
    Console.WriteLine($"Son distintos y {num1} es menor que {num2}");
}

//EJERCICIO 3

//Definir una variable numérica. Asignarle un valor entre 1 y 10 mostrar a que grupo pertenece:
// grupo 1 (del 1 al 3) / grupo 2 (del 4 al 6) / grupo 3 (del 7 al 10)

short num3 = short.Parse(Console.ReadLine());

switch (num3)
{
    case short e when (num3<=3):
        Console.WriteLine($"El número {e} pertenece al Grupo 1");
        break;
    
    case short e when (num3>3 && num3<=6):
        Console.WriteLine($"El número {e} pertenece al Grupo 2");
        break;
    
    case short e when (num3>6):
        Console.WriteLine($"El número {e} pertenece al Grupo 3");
        break;

    default:
        Console.WriteLine ("No se puede determinar");
        break;
}

// EJERCICIO 4
// Realizar la sumatoria de 0 a 10 y devolver el valor de la misma

int n = 0;
int sumatoria = 0;


while (n<11) {
    Console.WriteLine(sumatoria += n);
    n++;
}

// EJERCICIO 5
// Generar un array con 10 números, recorrerlo e ir multiplicando todos los elementos
// finalmente obtener el producto total

int [] arrayNumeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

int producto = arrayNumeros[0];

Console.WriteLine(producto);

for (int i = 1; i < arrayNumeros.Length; i++) {

    producto *= arrayNumeros[i];
    Console.WriteLine(producto);
}
