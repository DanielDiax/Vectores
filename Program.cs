using System;

namespace Vectores
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("****Actividad de Vectores****");

            Console.WriteLine("Digite 1 para para listar la edad de 5 estudiantes\n" +
                "Digite 2 para calcular promedio de alturas\n" +
                "Digite 3 para utilizar metodo Vectores Acumulados.\n" +
                "Digite 4 Para sumar dos vectores en un tercer vector.\n");



            int respuesta = Convert.ToInt32(Console.ReadLine());

            switch (respuesta)
            {
                case 1:
                    ListarEdades();
                    break;
                case 2:
                    PromedioAlturas();
                    break;
                case 3:
                    VectoresAcumulados();
                    break;
                case 4:
                    SumaVectores();
                    break;
                default:
                    Console.Write("\t Opción no válida...");
                    break;
            }

            Console.Write("\tPresione cualquier tecla para cerrar la consola...");
            Console.ReadKey();


        }

        public static void ListarEdades()
        {
            //En este ejemplo le decimos al programa a cuantas personas le vamos a preguntar la edad
            int[] edades = new int[5];


            Console.WriteLine("Ingrese la edad de los 5 estudiantes");
            for (int i = 0; i < edades.Length; i++)
            {
                //Se pide la edad de las personas para ser ingresadas por teclado
                Console.WriteLine("Ingrese la edad de el " + (i + 1) + " estudiante");
                int edad = Convert.ToInt32(Console.ReadLine());

                //Dar el valor de cadad edad (i) a cada posición de el vector
                edades[i] = edad;
            }

            for (int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine("El estudiante " + (i + 1) + " tiene " + (edades[i]) + " años");
            }
        }

        public static void PromedioAlturas()
        {
            //En este ejemplo le pedimos al usuario que dijite cuantas personas va a medir 
            decimal[] personas;

            Console.WriteLine("Porfavor ingrese el numero de personas que vamos a promediar");

            int linea = Convert.ToInt32(Console.ReadLine());
            personas = new decimal[linea];

            for (int i = 0; i < personas.Length; i ++)
            {
                Console.WriteLine("Ingrese la estatura de la persona " + (i + 1));
                decimal estatura = Convert.ToDecimal(Console.ReadLine());

                personas[i] = estatura;
            }

            decimal alt = 0;
            decimal prom = 0;

            for (int i = 0; i < personas.Length; i++)
            {
                alt += personas[i];
            }

            prom = alt / personas.Length;

            Console.WriteLine($"El promedio de las estaturas es:  {prom}");
        }


        public static void VectoresAcumulados()
        {
            int[] vector;
            int acumulador = 0;
            int acumuladorX10 = 0;
            int contadorX20 = 0;

            Console.WriteLine("Porfavor ingrese la cantidad de elementos a iterar");
            int linea = Convert.ToInt32(Console.ReadLine());
            vector = new int[linea];

            for (int i = 0; i < vector.Length; i++) 
            {
                Console.WriteLine($"Ingrese el valor de la posición {i+1}");
                int valor = Convert.ToInt32(Console.ReadLine());

                vector[i] = valor;
            }

            for (int i = 0; i < vector.Length; i++)
            {
                acumulador += vector[i];

                if (vector[i] >= 10) 
                {
                    acumuladorX10 += vector[i];
                }
                if (vector[i] >= 20)
                {
                    contadorX20++;
                }
            }

            Console.WriteLine($"El valor acumulado de todos los elementos es {acumulador}, el valor de los \n"+
                $"elementos mayores a 10 acumulados es {acumuladorX10} y el total de numeros mayores a 20 fueron: {contadorX20}");
        }

        public static void SumaVectores() 
        {

            int[] vector1;
            int[] vector2;
            int[] vector3;

            Console.Write("Ingrese la longitud de los vectores a sumar: ");
            string linea;
            linea = Console.ReadLine();
            int nlong = int.Parse(linea);
            vector1 = new int[nlong];
            vector2 = new int[nlong];
            vector3 = new int[nlong];

            Console.WriteLine("Ingresando valores al vector A");
            for (int i = 0; i < vector1.Length; i++)
            {
                Console.Write("Ingrese componente [" + (i + 1) + "]: ");
                linea = Console.ReadLine();
                vector1[i] = int.Parse(linea);
            }
            Console.WriteLine("Ingresando valores al vector B");
            for (int h = 0; h < vector2.Length; h++)
            {
                Console.Write("Ingrese componente [" + (h + 1) + "]: ");
                linea = Console.ReadLine();
                vector2[h] = int.Parse(linea);
            }

            for (int i = 0; i < vector1.Length; i++)
            {
                vector3[i] = vector1[i] + vector2[i];
            }

            Console.WriteLine("La suma de los vecores es: ");
            for (int i = 0; i < vector1.Length; i++)
            {
                Console.Write("[" + vector3[i] + "] ");
            }
        }
    }
    
}
