using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{

    public class A
    {
        string nombreInstancia;

        public A()
        {
            nombreInstancia = "Instancia sin nombre";
        }

        public A(string nombre)
        {
            nombreInstancia = nombre;
        }

        public void MostrarNombre()
        {
            M1();
            M2();
            M3();
            Console.WriteLine(nombreInstancia);
        }

        void M1()
        {
            Console.WriteLine("El metodo MostrarNombre fue invocado");
        }

        void M2()
        {
            Console.WriteLine("El metodo MostrarNombre fue invocado");
        }

        void M3()
        {
            Console.WriteLine("El metodo MostrarNombre fue invocado");
        }

    }
}
