
Console.WriteLine("Ingresa el tamaño del arreglo:");
int tan = Convert.ToInt32(Console.ReadLine());

// Definir arreglo:
int[] numeros = new int[tan];

//leer datos y guardarlos en el arreglo:
for(int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("Ingresa el numero en el indice {0}", i);
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}

//Mostrar datos:
Console.WriteLine("Los datos que ingresaste son:");
MostrarArreglo(numeros);

//metodo para imprimir arreglos:
static void MostrarArreglo(int[] arreglo)
{
    foreach(int num in arreglo)
    {
        Console.Write("{0} ", num);
    }
    Console.WriteLine();
}
