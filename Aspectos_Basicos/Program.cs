using System;

namespace Aspectos_Basicos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Repaso de ciclo for clasico

            // for(variable ; condicion ; paso){}

            //for (int i = 100; i <= 1000; i = i + 100)
            //{
            //    Console.WriteLine(i);
            //}

            // Ciclo while

            // while(condicion){}

            /*
            bool condicion; // Declarando

            condicion = true; // Inicializando

            int contador = 0;

            while (condicion)
            {
                Console.WriteLine(contador + "Me voy a ejecutar finitamente");
                contador += 1;
                if (contador == 10)
                {
                    condicion = false;
                }
            }

            Console.WriteLine("Programa finalizado...");
            */

            /*
            int contador = 0;

            while(contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }
            */

            // Ciclo do while

            /*
            do
            {
                //code block


            } while (condition);
            */
            /*
            bool condicion = false;

            do
            {
                Console.WriteLine("Me ejecuto una vez");
            } while (condicion);
            */
            // Ejemplo Nros primos

            /*
            Console.Write("Porfavor ingrese un número: ");

            string texto_numerico = Console.ReadLine();

            int n = int.Parse(texto_numerico);
            
            Console.WriteLine("El texto ingresado fue: "+ (n+10));
            */
            /*
            Console.Write("Porfavor ingrese un número: ");
            int n = int.Parse(Console.ReadLine());

            int contador_division_exacta = 0;

            for (int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    contador_division_exacta++;
                }
            }

            if (contador_division_exacta == 2)
            {
                Console.WriteLine("Ese numero querido es primo!");
            }
            else
            {
                Console.WriteLine("Ese numero NO es primo!");
            }

            */

            // introduccion a arrays

            /*
            string a = "Daniel";
            string b = "María";
            string c = "Noelia";

            string[] nombres;
            nombres = new string[4];

            nombres[0] = "Andrés";
            nombres[1] = "Daniel";
            nombres[2] = "María";
            nombres[3] = "Noelia";

            string[] apellidos = new string[3] { "Castaño", "Zapata", "Rodriguez" };

            Console.WriteLine(apellidos.Length);

            for (int i = 0; i<apellidos.Length; i++)
            {
                Console.WriteLine(apellidos[i]);
            }

            */

            /*
            Console.WriteLine("Escribe el número de usuarios que vas a ingresar: ");
            int nro_usuarios = int.Parse(Console.ReadLine());
            string[] usuarios = new string[nro_usuarios];

            for (int i = 0; i < nro_usuarios; i++)
            {
                Console.WriteLine("Porfavor ingrese el nombre del usuario " + i + ": ");
                usuarios[i] = Console.ReadLine();
            }

            Console.WriteLine("Los nombres de los usuarios ingresados son: ");

            for (int i = 0; i < usuarios.Length; i++)
            {
                Console.WriteLine(usuarios[i]);
            }

            */

            //Console.WriteLine(nombres[0]);

            // Variables implicitas

            // Arrays impicitos (no especifica ni tipo de dato ni cantidad de datos)

            // var datos = new[] { "Noelia", 1, 1.323, '@' }; Error

            // var datos = new[] { 2, 1, 1.323, 3 };

            // Introducción ciclo for each

            // string[] apellidos = new string[5] { "Castaño", "Zapata", "Rodriguez", "Pérez", "Valderrama" };

            // Vas a trabajar con los elementos de la lista directamente

            /*
            foreach (string i in apellidos)
            {
                Console.WriteLine(i);
            }

            // Necesitas información de los índices de la lista
            for (int i = 0; i < apellidos.Length; i++)
            {
                Console.WriteLine(apellidos[i]);
            }

            */

            // Introducción user forms
        }
    }
}
