class Cuatro {
    public static void Resolver () {
        object o = "Hola Mundo!";
        string st = o as string;
        int i = 12;
        byte b = (byte)i;
        double d = i;
        float f = (float)d;
        o = i;
        i = (o as int?)?? + 1;
        Console.WriteLine(i);
    }
}