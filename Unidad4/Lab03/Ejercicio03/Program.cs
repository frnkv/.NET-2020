using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet1 miUniversidad = new DataSet1();

            DataSet1.dtAlumnosDataTable dtAlumnos = new DataSet1.dtAlumnosDataTable();
            DataSet1.dtCursosDataTable dtCursos = new DataSet1.dtCursosDataTable();

            DataSet1.dtAlumnosRow rowAlumno = dtAlumnos.NewdtAlumnosRow();
            rowAlumno.Apellido = "Pérez";
            rowAlumno.Nombre = "Juan";
            dtAlumnos.AdddtAlumnosRow(rowAlumno);

            DataSet1.dtCursosRow rowCurso = dtCursos.NewdtCursosRow();
            rowCurso.Curso = "informatica";

            dtCursos.AdddtCursosRow(rowCurso);

            DataSet1.dtAlumnos_CursosDataTable dtALumnos_Cursos = new DataSet1.dtAlumnos_CursosDataTable();

            dtALumnos_Cursos.AdddtAlumnos_CursosRow(rowAlumno, rowCurso);

            DataSet1.dtAlumnosRow rowAlumno2 = dtAlumnos.NewdtAlumnosRow();
            rowAlumno2.Apellido = "Pérez";
            rowAlumno2.Nombre = "Macerlo";
            dtAlumnos.AdddtAlumnosRow(rowAlumno2);

            dtALumnos_Cursos.AdddtAlumnos_CursosRow(rowAlumno2, rowCurso);
        }
    }
}
