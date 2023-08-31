// Dados los catetos de un triángulo rectángulo, calcular su hipotenusa
public class Triangulo
{
    static void Main(string[] arg)
    {
        //datos de entrada
        int Cateto1, Cateto2, Hipotenusa;
        Console.WriteLine("Ingresa el valor del cateto 1");
        Cateto1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa el valor del cateto 2");
        Cateto2 = Convert.ToInt32(Console.ReadLine());
            
        //Proceso
        Hipotenusa = Cateto1*Cateto1 + Cateto2*Cateto2;

        //Salida
        Console.WriteLine("El Valor de la Hipotenusa es: "+ Hipotenusa);







    }




}
