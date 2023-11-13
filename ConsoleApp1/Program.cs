using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static int x = 6; 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(777);//entero intger ->int
            Console.WriteLine(0.0888888888);//doble precision -> double
            Console.WriteLine(-70.0888888888f);// float
            Console.WriteLine(4+8);
            Console.WriteLine(true);
            Console.WriteLine(4 > 8);
            //llamada a metodo
            magico(args);

            //POO 
            //declaro varible pers de tipo personita   =  instancia
            Personita pers = new Personita("PePE",21);
            pers.presntarse();
            pers.nombre = "Ana";
            //pers.edad = -5;
            pers.cambiarEDad(-5);
            //pers.estatura = 28;
            pers.estatura = -28;
            pers.presntarse();

            Console.WriteLine(pers.nombre);
            Console.WriteLine(pers.estatura);


            Console.WriteLine("el indice es: "+ pers.CalcularIndice());

            /*int calc = pers.div(11, 2);*///no se debe hacer
            //pers.
            //pilares de la programacion
            // SET ASIGNAR UN VALOR A 
            //GET RETORNO AL USUARIO

            Humano Hum = new Humano();
            Cliente cl1 = new Cliente();
            cl1.nombre = "rocky";
            cl1.cambiarEDad(29);
            cl1.correo = "rocky@gmail.com";
            cl1.presntarse();
            //pilares de la programacion POO  1   ENCAPSULAMIENTO  2 HRERNCIA   3 
            //encapsulamiento (proteger los datos)   ,abstraccion (simplificar)
        }
       // string nombre = "";
        public static void magico(string[] y )
        {
            int cantidadArgs = y.Length;
            if (cantidadArgs==0)
            {

            }
        }
    }
}
