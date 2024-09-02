

using DefaultNamespace;

public class Program
{
    public static void Main()
    {
        Circulo circulo = new Circulo(3.0); //crea un nuevo objeto
        Console.WriteLine(circulo.GetPerimeter());
        Console.WriteLine(circulo.GetArea());
    }


}