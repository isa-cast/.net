char c1 = 'A';
char c2 = 'A';
Console.WriteLine(c1 == c2);
object o1 = 'A';
object o2 = 'A';
Console.WriteLine(o1 == o2);

string[] vector = ["uno", "dos", "tres"];
foreach (string st in vector)
{
Console.WriteLine(st.ToUpper());
}
double d = 15.1;
float f = 21.2f;
double r1 = 17 / 3;
double r2 = 17 / 3.0;
double resul = 1/2;
Console.WriteLine (resul);
Console.WriteLine(r1);
Console.WriteLine(r2);

int x = 2;
int y = 5;
Console.WriteLine(x != 0 && y / x == 2);
Console.WriteLine(x != 0 & y / x == 2);
Console.WriteLine(x == 0 || y / x == 2);
Console.WriteLine(x == 0 | y / x == 2);

x = 0;
Console.WriteLine(x != 0 && y / x == 2);

x = 1;
Console.WriteLine(x++); //post incremento
Console.WriteLine(x);

Console.WriteLine(++x); //pre incremento
Console.WriteLine(x);

x = 10;
y = x--; //post decremento
Console.WriteLine(y);
Console.WriteLine(x);
y = --x; //pre decremento
Console.WriteLine(y);
Console.WriteLine(x);

x = 10;
Console.WriteLine(x++ == 10);
Console.WriteLine(x-- == 10);
Console.WriteLine(++x == 10);
Console.WriteLine(--x == 10); // preguntar 

Console.WriteLine("Ingrese su nombre");
string nombre = Console.ReadLine();
Console.WriteLine("Hola " + nombre);
