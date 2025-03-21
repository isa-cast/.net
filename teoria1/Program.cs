/* 1) System.Console.Write() Method	
Escribe texto en la consola sin añadir un salto de línea al final

System.Console.WriteLine() Method
Escribe texto en la consola añadiendo un salto de línea al final

System.Console.ReadKey() Method	
Obtiene la siguiente tecla de carácter o de función presionada por el usuario. 
La tecla presionada se muestra en la ventana de la consola.
*/

using System.Timers;

Console.Write("Hola");
Console.ReadKey();
Console.Write("Mundo!");

/* 2) \n: Salto de línea (nuevo renglón).
\t: Tabulación (espacio de tabulador).
\": Comilla doble (").
\\: Barra invertida (\), para escapar el carácter de barra invertida.
*/

Console.WriteLine("Hola \n Mundo!!");
Console.WriteLine("Hola \t Mundo!");
Console.WriteLine("Hola \" Mundo!!");
Console.WriteLine("Hola \\ Mundo!");

/* 3)
 */
{
string st = @"c:\windows\system";
Console.WriteLine(st);
Console.WriteLine ("c:\\windows\\system");
}
/* 4)
*/
{
string st = Console.ReadLine();
// string str = (st != " ") ? (Console.WriteLine ("Hola " + st)) : (Console.WriteLine ("Hola Mundo!"));
if (st != " ")
{
    Console.WriteLine ("Hola " + st);
}
else
{
    Console.WriteLine ("Hola Mundo");
}
}

/* 5) 
*/
{
string st = Console.ReadLine();
if (st == "Juan")
{
    Console.WriteLine ("¡Hola amigo!");
}
else if (st == "Maria")
{
    Console.WriteLine ("Buen dia señora");
}
else if (st == "Alberto")
{
    Console.WriteLine ("Hola Alberto");
}
else if (st == " ")
{
    Console.WriteLine ("¡Buen dia Mundo!");
}
else 
{
    Console.WriteLine ("Buen dia " + st);
}
}

/* 6)
*/

{
string st = Console.ReadLine();
while (st != " ") 
{
    Console.WriteLine("La cadena ingresada tiene: " + st.Length + " caracteres");
    st= Console.ReadLine();
}
}
 /* 7) La instruccion nos brinda la cantidad de caracteres del string ingresado,
 en este caso al poner 100 nos dira 3 ya que 100 tiene 3 caracteres.
 */
{
    Console.WriteLine("100".Length);
}

/* 8) Es valido iniciar una variable de esa manera, si.
*/
{
    string st;
    Console.WriteLine(st=Console.ReadLine());
}

/* 9)Escribir un programa que lea dos palabras separadas por un blanco que terminan con <ENTER>, y
determinar si son simétricas (Ej: 'abbccd' y 'dccbba' son simétricas).
Tip: si st es un string, entonces st[0] devuelve el primer carácter de st, y st[st.Length-1]
devuelve el último carácter de st.
*/
{
string st1 = Console.ReadLine();
string st2 = Console.ReadLine();
if (st1.Length == st2.Length) 
{
    int i= 0;
    int j = st2.Length - 1;
    while (i < st1.Length) {
        if (st1[i] == st2[j]) {
            i++;
            j--;
        }
        else {
            Console.WriteLine("No son simetricas");
            break;
        }
    }
    if (i == st1.Length) {
        Console.WriteLine ("Son simetricas");
    }
}
else {
    Console.WriteLine ("No son simetricas");
}
}

// 10)
{
for (int i= 1; i < 1001; i++) {
    if ((i % 17)== 0) {
        Console.WriteLine ("El numero " + i + " es multiplo de 17");
    }
    else if (i % 29 == 0) {
        Console.WriteLine ("El numero " + i + " es multiplo de 29");
    }
    }
}

/* 11) a- el operador / depende de los tipos ingresados.
       b- el operador + entre un string y un dato numerico lo que hace es concatenar
       el dato numerico al string.
*/
{
Console.WriteLine("10/3 = " + 10 / 3);
Console.WriteLine("10.0/3 = " + 10.0 / 3);
Console.WriteLine("10/3.0 = " + 10 / 3.0);
int a = 10, b = 3;
Console.WriteLine("Si a y b son variables enteras, si a=10 y b=3");
Console.WriteLine("entonces a/b = " + a / b);
double c = 3;
Console.WriteLine("Si c es una variable double, c=3");
Console.WriteLine("entonces a/c = " + a / c);
}

/* 12) Escribir un programa que imprima todos los divisores de un número entero ingresado desde la
consola. Para obtener el entero desde un string st utilizar int.Parse(st).
*/
{
string aux = Console.ReadLine();
for (int i= 0; i<int.Parse(aux); i++) {
    if (i % int.Parse(aux) == 0) {
        Console.WriteLine ("El numero: " + i + " es divisor de " + aux);
        //--aux; // como resuelvo esto??
    }
}
}

/* 13) Si a y b son variables enteras, identificar el problema (y la forma de
 resolverlo) de la siguiente expresión. Tip: observar qué pasa cuando b = 0.
 if ((b != 0) & (a/b > 5)) Console.WriteLine(a/b);
*/
{
    int a = 30;
    int b = 4;
    if ((b != 0) & (a/b > 5)) Console.WriteLine(a/b); // no entendi xd
}

/* 14) Utilizar el operador ternario condicional (switch) para establecer el contenido de una variable entera con el
menor valor de otras dos variables enteras.
*/
{
int a = 10;
int b = 5;
int menor = (a < b) ? a : b;      
 Console.WriteLine("El menor valor es: " + menor);
}

/* 15) esto se soluciona borrando el int o declarando el int dentro del for
*/
{
int i = 0;
//for (int i = 1; i <= 10;) 
{
Console.WriteLine(i++);
}
}

/* 16) En el primer if imprime 0, en el segundo tambien. Sin embargo el auxiliar
no fue modificado.
*/

{
int i = 1;
if (--i == 0)
{
Console.WriteLine("cero");
}
if (i++ == 0)
{
Console.WriteLine("cero");
}
Console.WriteLine(i);
}