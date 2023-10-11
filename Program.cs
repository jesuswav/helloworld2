// 1. Declarar un vector el cual debe almacenar el nombre de 5 personas y despues ordearlos aflabeticamente.
Console.WriteLine("1. ORDENAR NOMBRES");

string[] nombres = new string[5] { "Jaime", "Liz", "Kari", "Wendy", "Gabriel" };

Array.Sort(nombres);

Console.WriteLine(string.Join(", ", nombres));

// 2. Ingresar un vector de n elementos de tipo entero. Ordenar posteriormente el vector en forma ascentente.
Console.WriteLine("1. ORDENAR NÚMEROS");

int[] numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Array.Sort(numeros);
Array.Reverse(numeros);

Console.WriteLine(string.Join(", ", numeros));

// 3. Ingresa por teclado 10 números del 1 al 50 y mostrar la suma de dichos números.
Console.WriteLine("1. SUMAR NÚMEROS DE UN ARRAY");

int[] array = new int[10];
int numero = 0;
int contador = 0;
int suma = 0;

do
{
    Console.WriteLine("Ingresa un número: " + "[" + (contador + 1) + "]");
    numero = Int32.Parse(Console.ReadLine());

    if (numero >= 1 && numero <= 50)
    {
        array[contador] = numero;
        contador++;
    }
    else if (numero == -45)
    {
        contador = 10;
    }
    else
    {
        Console.WriteLine("El número tiene que estar entre el 1 y el 50");
    }

} while (contador < 10);

Console.WriteLine("Contador: " + contador);

for (int i = 0; i < array.Length; i++)
{
    suma += array[i];
    Console.Write(array[i] + " ");
}

Console.WriteLine("Suma de los números: " + suma);

// 4. Cree un programa que solicite 5 calificaciones y al final imprima todas las calificaciones y el promedio de estas.
Console.WriteLine("4. PROMEDIO DE CALIFICACIONES");

float[] calificaciones = new float[5];
int contador_cal = 0;
float calificacion = 0;
float suma_cal = 0;
float promedio = 0;

do
{
    Console.WriteLine("Ingresa una calificación: " + "[" + (contador_cal + 1) + "]");
    calificacion = Int32.Parse(Console.ReadLine());

    if (calificacion >= 0 && calificacion <= 10)
    {
        calificaciones[contador_cal] = calificacion;
        contador_cal++;
    }
    else if (calificacion == -45)
    {
        contador_cal = 5;
    }
    else
    {
        Console.WriteLine("La calificación tiene que estar entre el 0 y el 10");
    }

} while (contador_cal < 5);

for (int i = 0; i < calificaciones.Length; i++)
{
    suma_cal += calificaciones[i];
    promedio = suma_cal / calificaciones.Length;
    Console.WriteLine("Calificacion: " + "[" + (i + 1) + "] " + calificaciones[i]);

}


Console.WriteLine("Promedio: " + promedio);

// 5. Cree un programa que permita saber cuál es el número mayor y menor de un grupo de números ingresados por el usuario.
Console.WriteLine("4. NÚMERO MAYOR Y NÚMERO MENOR");

int numeros_usuario = 0;
int numero_ingresado = 0;
int contador_numeros = 0;

Console.WriteLine("¿Cuántos números quieres ingresar?");
numeros_usuario = Int32.Parse(Console.ReadLine());

int[] numeros_ingresados = new int[numeros_usuario];

do
{
    Console.WriteLine("Ingresa un número: " + "[" + (contador_numeros + 1) + "]");
    numero_ingresado = Int32.Parse(Console.ReadLine());

    if (numero_ingresado == -45)
    {
        contador_numeros = numeros_usuario;
    }
    else
    {
        numeros_ingresados[contador_numeros] = numero_ingresado;
        contador_numeros++;
    }

} while (contador_numeros < numeros_usuario);

Array.Sort(numeros_ingresados);

Console.WriteLine(string.Join(" ", numeros_ingresados));
Console.WriteLine("Número menor: " + numeros_ingresados[0]);
Console.WriteLine("Número mayor: " + numeros_ingresados[numeros_ingresados.Length - 1]);


// 5. Diseñe el siguiente arreglo bidimensional y ordene los números del 1 al 25 en forma de espiral.

Console.WriteLine("5. ESPIRAL");

int row = 5;
int column = 5;
int[,] spiral = new int[row, column];
int count = 1;

for (int x = 0; x < row; x++)
{
    for (int y = 0; y < column; y++)
    {
        spiral[x, y] = 0;
    }
}

int top = 0;
int bottom = row - 1;
int left = 0;
int right = column - 1;

while (count <= row * column)
{
    for (int i = 0; i < column; i++)
    {
        if (spiral[top, i] == 0)
        {
            spiral[top, i] = count;
            count++;
        }
    }
    top++;

    for (int i = 0; i < row; i++)
    {
        if (spiral[i, right] == 0)
        {
            spiral[i, right] = count;
            count++;
        }
    }
    right--;

    for (int i = column - 1; i >= 0; i--)
    {
        if (spiral[bottom, i] == 0)
        {
            spiral[bottom, i] = count;
            count++;
        }
    }
    bottom--;

    for (int i = row - 1; i >= 0; i--)
    {
        if (spiral[i, left] == 0)
        {
            spiral[i, left] = count;
            count++;
        }
    }
    left++;
}

for (int x = 0; x < row; x++)
{
    for (int y = 0; y < column; y++)
    {
        Console.Write($"{spiral[x, y]} ");
    }
    Console.WriteLine();
}