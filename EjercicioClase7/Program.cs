/* Escribe un programa que:
1) Pida 10 números al usuario.
2) Obtener la suma de todos los números ingresados.
3) Obtener cual es el mayor de todos los números.
4) Obtener cual es el menor de todos los números.
5) Obtener el promedio de todos los números.
6) Mostrar todos los números ingresados por pantalla.
7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.
*/

double[] Numeros = new double[10];
double suma = 0;
double mayor = 0;
double menor = 0;
double promedio;
bool unicaVez = true;

for (int i = 0; i < Numeros.Length; i++)
{
    Console.WriteLine($"Ingrese el Numero {i+1} :");
    Numeros[i] = double.Parse(Console.ReadLine());
    suma = suma + Numeros[i];

    // Asigno el primer valor como mayor y menor para poder comparar, esto se hace una sola vez
    while (unicaVez == true)
    {
        mayor = Numeros[0];
        menor = Numeros[0];
        unicaVez = false;
    }

    // Comparo los N° ingresados, si es mayor se reasigna al mayor, si es menor se reasigna al menor
    if (Numeros[i] > mayor)
    {
        mayor = Numeros[i];
    }
    else if (Numeros[i] < menor)
    {
        menor = Numeros[i];
    }
}

promedio = suma / Numeros.Length;

// Se muestran todos los valores Ingresados
for (int i = 0; i < Numeros.Length; i++)
{
    Console.WriteLine($"El Numero {i+1} ingresado fue: {Numeros[i]}");
}

Console.WriteLine($"La suma de los N° ingresados es: {suma}");
Console.WriteLine($"El Mayor N° ingresado es: {mayor}");
Console.WriteLine($"El Menor N° ingresado es: {menor}");
Console.WriteLine($"El promedio de los N° ingresados es: {promedio}");
