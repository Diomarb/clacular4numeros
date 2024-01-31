using System;
class Calcular
{
    static void Main(string[] args)


    {

        try
        {
            //Solicitar los 4 numeros//
            Console.WriteLine("Ingrese el primer valor numerico");
            string entrada1 = Console.ReadLine();
            double Numero1 = Convert.ToDouble(entrada1);

            Console.WriteLine("Ingrese el segundo valor numerico");
            string entrada2 = Console.ReadLine();
            double Numero2 = Convert.ToDouble(entrada2);

            //Resultado de la suma//

            double suma = Numero1 + Numero2;
            Console.WriteLine($"El rersultado de la suma es: {suma}");
        
            Console.WriteLine("Ingrese el tercer valor numerico");
            string entrada3 = Console.ReadLine();
            double Numero3 = Convert.ToDouble(entrada3);

            Console.WriteLine("Ingrese el cuarto valor numerico");
            string entrada4 = Console.ReadLine();
            double Numero4 = Convert.ToDouble(entrada4);

            //resultado de el producto
            double producto = Numero3 * Numero4;
            Console.WriteLine($"El resultado del producto es: {producto}");


         //capturar exepciones//
         
        }
        catch (FormatException)
        {
            Console.WriteLine("Error. Solo se permite valor numerico");
        }
        Console.WriteLine("Enter para salir...");
        Console.ReadLine();
    }
}









