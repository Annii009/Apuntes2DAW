// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");


/* ESTRUCTURA BASICA DEL CODIGO*/
using System; //importar namespaces

namespace MiPrograma // espacio de nombres
{
    class Program //clase principal
    {
        static void Main(string[] args) //metodo principal
        {
            //tu codigo aqui
            Console.WriteLine("Hola mundo");
        }
    }
}

/* VARIABLES Y TIPOS DE DATOS*/
//numeros enteros
int numero = 42;
long numeroGrande = 12345678L;
short numeroCorto = 3245;

//numeros decimales
float decimal1 = 3.14f;
double decimal2 = 3.15433;
decimal dinero = 99.99m; //para valores monetarios

//cadenas de texto
string nombre = "Juan";
string apellido = "Perez";
string completo = $"mi nombre es {nombre} {apellido}"; //interpolacion

//caracteres
char inicial = 'J';

//booleanos
bool esVerdad = true;
bool esFalso = false;

//arrays
int[] numeros = { 1, 2, 3, 4, 5 };
string[] frutas = { "manzanas", "banana", "naranja" };
int[] arrayVacio = new int[10]; //array de 10 elementos

//declaracion con var
var edad = 25; //el compilador infiere que es int
var texto = "hola"; //el compilador infiere que es string

/* OPERADORES FUNDAMENTALES*/
//arritmetricos
int suma = 5 + 3; //8
int resta = 10 - 4; //6
int multiplicacion = 6 * 7; //42
int division = 15 / 3; //5
int modulo = 10 % 3; //1

//comparacion
bool igual = 5 == 5; //true
bool diferente = 5 != 3; //true
bool mayor = 10 > 5; //true
bool menor = 3 < 8; //true
bool mayorIgual = 5 >= 5; //true

//logicos
bool y = true && false; //false
bool o = true || false; //true
bool no = !true; //false

//incremento/decremento
int contador = 5;
contador++; //contador = 6
contador--; //contador =5

/* ESTRUCTURAS DE CONTROL*/
//condicionales
int edad = 18;
if (edad >= 18)
{
    Console.WriteLine("es mayor de edad");
}
else if (edad >= 13)
{
    Console.WriteLine("Es adolescente");
}
else
{
    Console.WriteLine("es menor");
}

//switch
string dia = "lunes";
switch (dia)
{
    case "lunes":
        Console.WriteLine("inicio de semana");
        break;
    case "viernes":
        Console.WriteLine("finde");
        break;
    default:
        Console.WriteLine("dia normal");
        break;
}

//bucles
//for tradicional
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"numero: {i}");
}

//while
int contador = 0;
while (contador < 10)
{
    Console.WriteLine(contador);
    contador++;
}

//do-while
int numero;
do
{
    Console.WriteLine("ingrese un numero mayor a 0.");
    numero = int.Parse(Console.ReadLine());
} while (numero <= 0);

//foreach para arrays
string[] colores = { "rojo", "verde", "azul" };
foreach (string color in colores)
{
    Console.WriteLine(color);
}

/* METODOS (FUNCIONES) */
//metodo que no retorna nada
static void Saludar(string nombre)
{
    Console.WriteLine($"hola, {nombre}");
}

//metodo que retorna un valor
static int Sumar(int a, int b)
{
    return a + b;
}

//metodo con parametros opcionales
static void MostrarInfo(string nombre, int edad = 0)
{
    Console.WriteLine($"nombre: {nombre}, edad: {edad}");
}

//metodo con multiples valores de retorno
static (int suma, int producto) Calcular(int a, int b)
{
    return (a + b, a * b);
}

//llamar metodos
Saludar("Ana");
int resultado = Sumar(5, 3);
var (suma, producto) = Calcular(4, 5);

/* MANIPULACION DE ARRAYS*/
int[] numeros = { 1, 2, 3, 4, 5 };
