using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    //scafolding  
    //https://www.w3schools.com/java/java_classes.asp clases en java
    //el compotamiento es diferente en c#
    //puedo crear varias clases en este archivo

    //internal class Persona
    //{
       
    //}

    public class Personita
    {
        //atributos el alcanze del atrburto es public
        public string nombre { get; set;}   //referencia getter y setter   en java  set recibe parametro get no
        private int edad;  //private solo sra alcnzada por medio de la clase personita
        private int _estatura;  //  se uso _ porque es una convencion  ej. 
        public int estatura { // estatura seria como la secretaria y _estatura seria como el director al cual no tenemosacceso facielmente ni directa
            get
            {
                return _estatura;
            }
            set
            {
                if (value > 0)
                    _estatura = value;
            }
        }
        //valor primitivo vacio y 0

        //uso de constructor
        //siempre de be ser publico
        public Personita(string nom,int ed)
        {
            //nombre = "N/A";
            //edad = 1;
            nombre = nom;
            edad = ed;
            estatura = 180;//cm
        }
        public Personita()
        {
            nombre = "N/A";
            edad = 1;
            estatura = 180;//cm
        }
        public Personita(string nom, int est, int ed)
        {
            nombre = nom;
            estatura = est;//cm
            edad = ed;
        }
        public Personita( int est, string nom)
        {
            nombre = nom;
            estatura = est;//cm
        }
        //Metodo  o acciones 
        public void presntarse(){
           // Console.WriteLine("Hola , me llamo " + nombre + "y tengo " + edad + "años.");
            Console.WriteLine($"Hola , me llamo {nombre} y tengo {edad} años.");
        }

        public void cambiarEDad(int edad)
        {
            if (edad >= 0)
                this.edad = edad;
            else
                Console.WriteLine($"VAlor de la edad incorrecta {edad}; se mamntiene el ");
        }

        public int CalcularIndice()
        {
            int res = div(multiplicar(edad, estatura), 2);
            //int res = multiplicar(edad, estatura) / 2;
           // int res = edad * estatura / 2;
            return res;
        }
        private int multiplicar(int a , int b)
        {
            return a * b;
        }
        private int div(int x, int y)
        {
            return x / y;
        }
    }


    public class Humano
    {
        public string nombre;
    }
}
