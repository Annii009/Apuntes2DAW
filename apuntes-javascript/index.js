//comentarios de una linea
/*comentarios de 
varias lineas*/

/* ESTRUCTURA BASICA */
//declaracion de variables
let nombre = "Ana";
const edad = 26;
var ciudad = "Zaragoza"; // forma antigua mejor usar, let/const

/* VARIABLES Y TIPOS DE DATOS */
//numeros
let numero = 42;
let decimal = 3.14;

//cadena de texto (string)
let texto = "hello world";
let nombres = 'Ana';
let plantilla = `mi nombre es ${nombres}`;

//booleanos
let esVerdad = true;
let esFalso = false;

//arrays
let frutas = ["manzanas", "peras", "plantanos"];
let numeros = [1, 2, 3, 4];

//objetos
let persona = {
    nombre: "Carlos",
    edad: 34,
    ciudad: "Barna"
};

/* OPERADORES FUNDAMENTALES*/
//aritmetricos
let suma = 5 + 3; //8
let resta = 10 - 4; //6
let multiplicacion = 6 * 7; //42
let division = 15 / 3; //5

//comparacion
let igual = 5 == "5"; //true
let estrictamente = 5 === "5"; //false (comparacion estricta)
let mayor = 10 > 5; //true
let menor = 3 < 8; //true

//logicos
let y = true && false; //false
let o = true || false; //true
let no = !true; //false

/* ESTRUCTURA DE CONTROL */
//condicionales
if (edad >= 18){
    console.log("es mayor de edad");
} else if (edad >= 13){
    console.log("es adolescente");
} else {
    console.log("es menor");
}

//switch
switch (dia) {
    case "lunes":
        console.log("inicio de la semana");
        break;
    case "viernes":
        console.log("finde");
        break;
    default: 
        console.log("dia normal");
}

//bulces
for (let i = 0; i < 5; i++){
    console.log("numero: " + i);
}

while (contador < 10) {
    console.log(contador);
    contador++;
}

//for... of para arrays
for (let fruta of frutas){
    console.log(fruta);
}

/* FUNCIONES */
//declaración de funcion
function saludar(nombre){
    return "Hola " + nombre;
}

//fucion flecha
const multiplicar = (a, b) => a * b;

//funcion con multiples de parametros
function calcular (operacion, num1, num2){
    if(operacion === "suma"){
        return num1 + num2;
    } else if (operacion === "resta"){
        return num1 - num2;
    }
}

//llamar funciones
let mensaje = saludar ("Ana");
let resultado = multiplicar (4, 5);
console.log(mensaje); // "hola, Ana"
console.log(resultado); //20

/* MANIPULACION DE ARRAY*/
let colores = ["rojo", "verde", "azul"];

//agregar elementos
colores.push("amarillo"); //al final
colores.unshift("negro"); //al inicio

//eliminar elementos
colores.pop(); //del final
colores.shift(); //del inicio

//buscar elementos
let indice = colores.indexOf("verde"); //posicion del elemento
let existe = colores.includes("rojo"); //true/false

/* MANIPULACION DE OBJETOS */
let coche = {
    marca: "toyota",
    modelo: "corolla",
    año: 2020
};

//acceder a propiedades
console.log(coche.marca);
console.log(coche["modelo"]);

//modificar propiedades
coche.año = 2021;
coche.color = "blanco"; //agregar nueva propiedad

//eliminar propiedades
delete coche.color;

/* COMANDOS DE SALIDA BASICOS */
//mostrar en consola
console.log("mensaje en consola");
console.error("mensaje de error");
console.warn("mensaje de advertencia");

//mostrar alerta
alert("mensaje de alerta");

//pedir entrada del usuario
let nombre = prompt("¿como te llamas?");
let confirmacion = confirm("¿estas seguro?");
