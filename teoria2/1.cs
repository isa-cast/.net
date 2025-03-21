class Uno {
    public static void One() {
        object o1 = "A";
        object o2 = o1;
        o2 = "Z";
        Console.WriteLine(o1 + " " + o2);
    }
/* Esto es asi ya que al asignarle Z a o2, le asigna una direccion diferente*/
}