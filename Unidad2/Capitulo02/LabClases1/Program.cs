using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace LabClases1
{
    class Program
    {
        static void Main(string[] args)
        {
            A instanciaA = new A();
            instanciaA.MostrarNombre();

            B instanciaB = new B();
            instanciaB.MostrarNombre();

            Console.ReadLine();
        }
    }
}
