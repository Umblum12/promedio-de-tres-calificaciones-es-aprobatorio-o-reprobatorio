using System;

namespace promedio_de_tres_calificaciones_es__aprobatorio__o__reprobatorio_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarado de variables
            Double Cal1, Cal2, Cal3, resultado;
            //ingresar los valores de variables
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Ingresa la primer calificacion: ");
            Cal1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa la segunda calificacion: ");
            Cal2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa la tercer calificacion: ");
            Cal3 = Convert.ToDouble(Console.ReadLine());
            //Colocar el procedimiento
            resultado = (Cal1 + Cal2 + Cal3) / 3;
            //Imprimir en pantalla el resultado
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("El promedio de las trescalificaciones la calificacion 1 es: " + Cal1 + " + " + " la calificacion 2 es: " + Cal2 + " + " + "la calificacion 3 es: " + Cal3 + " entre 3 es: " + resultado);
            Console.WriteLine("--------------------------------------------");
            if (resultado >= 10)
            {
                Console.WriteLine("Tu calificacion es aprovatoria: ");
            }
            Console.ReadKey(true);
        }
    }
}
