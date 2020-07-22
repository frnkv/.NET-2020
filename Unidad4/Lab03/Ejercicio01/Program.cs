﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dtAlumnos = new DataTable();
            DataRow rwAlumno = dtAlumnos.NewRow();
            DataColumn dtcolNombre = new DataColumn();
            DataColumn dtcolApellido = new DataColumn();

            dtAlumnos.Columns.Add(dtcolNombre);
            dtAlumnos.Columns.Add(dtcolApellido);

            rwAlumno[dtcolNombre] = "Juan";
            rwAlumno[dtcolApellido] = "Perez";
            dtAlumnos.Rows.Add(rwAlumno);

            DataRow rwAlumno2 = dtAlumnos.NewRow();
            rwAlumno2[dtcolNombre] = "Marcelo";
            rwAlumno2[dtcolApellido] = "Perez";
            dtAlumnos.Rows.Add(rwAlumno2);

            Console.WriteLine("Listado de Alumnos:");

            foreach (DataRow row in dtAlumnos.Rows)
            {
                Console.WriteLine(row[dtcolApellido].ToString() + ", " + row[dtcolNombre].ToString());
            }

            Console.ReadLine();
        }
    }
}
