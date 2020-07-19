using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Program
    {
        /*
            Dada una List<Empleado> donde Empleado tiene las propiedades Id (int), Nombre (string),
            Sueldo (decimal). Crear un programa que acepte dar de alta Empleados en esta lista y luego
            muestre por Consola esta misma Lista ordenada por la propiedad Sueldo, tanto de manera
            ascendente como descendente.
        */
        static void Main(string[] args)
        {
            List<Empleado> empleados = Alta(new List<Empleado> { });

            Muestra(empleados);

            Console.ReadKey();
        }


        static List<Empleado> Alta(List<Empleado> empleados)
        {
            ConsoleKeyInfo respuesta;
            Console.WriteLine("Ingrese un nuevo empleado" + Environment.NewLine);
            do
            {
                Console.Write("Ingrese identificador: ");
                string identificador = Console.ReadLine();

                Console.Write("Ingrese nombre y apellido: ");
                string nombreCompleto = Console.ReadLine();

                Console.Write("Ingrese su sueldo:");
                string sueldo = Console.ReadLine();


                Console.WriteLine("Presione cualquier tecla para terminar...");
                Console.ReadKey();

                Empleado empleado = new Empleado();

                empleado.Nombre = nombreCompleto;
                empleado.Sueldo = Decimal.Parse(sueldo);
                empleado.Id = int.Parse(identificador);

                empleados.Add(empleado);


                Console.Clear();

                Console.WriteLine("Desea añadir otro? Y/N");

                respuesta = Console.ReadKey();

            } while (respuesta.Key.ToString().ToLower() == "y");

            Console.Clear();
            return empleados;
        }

        static void Muestra(List<Empleado> empleados)
        {
            Console.WriteLine("Listado ordenado de manera ascendente");
            List<Empleado> empleadosOrdenadosAscendente = empleados.OrderBy(e => e.Sueldo).ToList();

            foreach(Empleado e in empleadosOrdenadosAscendente)
            {
                Console.Write("Identificador: " + e.Id + Environment.NewLine +
                        "Nombre completo: " + e.Nombre + Environment.NewLine +
                        "Sueldo:" + e.Sueldo.ToString() + Environment.NewLine + Environment.NewLine);


            }

            Console.WriteLine("Listado ordenado de manera descendente");
            List<Empleado> empleadosOrdenadosDescendente = empleados.OrderByDescending(e => e.Sueldo).ToList();

            foreach (Empleado e in empleadosOrdenadosDescendente)
            {
                Console.Write("Identificador: " + e.Id + Environment.NewLine +
                        "Nombre completo: " + e.Nombre + Environment.NewLine +
                        "Sueldo:" + e.Sueldo.ToString() + Environment.NewLine + Environment.NewLine);
            }
        }
    } 


    class Empleado
    {
        int _id;

        string _nombre;

        decimal _sueldo;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public decimal Sueldo { get => _sueldo; set => _sueldo = value; }
        public int Id { get => _id; set => _id = value; }
    }
}
