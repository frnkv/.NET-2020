using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http.Headers;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dtAlumnos = new DataTable();

            DataColumn dtcolIDAlumno = new DataColumn("IDAlumno", typeof(int));
            dtcolIDAlumno.ReadOnly = true;
            dtcolIDAlumno.AutoIncrement = true;
            dtcolIDAlumno.AutoIncrementSeed = 0;
            dtcolIDAlumno.AutoIncrementStep = 1;

            DataColumn dtcolNombre = new DataColumn("Nombre", typeof(string));
            DataColumn dtcolApellido = new DataColumn("Apellido", typeof(string));
            dtAlumnos.Columns.Add(dtcolNombre);
            dtAlumnos.Columns.Add(dtcolApellido);
            dtAlumnos.Columns.Add(dtcolIDAlumno);

            dtAlumnos.PrimaryKey = new DataColumn[] { dtcolIDAlumno };

            DataRow rwAlumno = dtAlumnos.NewRow();
            rwAlumno[dtcolNombre] = "Juan";
            rwAlumno[dtcolApellido] = "Perez";
            dtAlumnos.Rows.Add(rwAlumno);

            DataRow rwAlumno2 = dtAlumnos.NewRow();
            rwAlumno2[dtcolNombre] = "Marcelo";
            rwAlumno2[dtcolApellido] = "Perez";
            dtAlumnos.Rows.Add(rwAlumno2);


            DataTable dtCursos = new DataTable();

            DataColumn dtcolIDCurso = new DataColumn("IDCurso", typeof(int));
            dtcolIDCurso.ReadOnly = true;
            dtcolIDCurso.AutoIncrement = true;
            dtcolIDCurso.AutoIncrementSeed = 1;
            dtcolIDCurso.AutoIncrementStep = 1;

            DataColumn dtcolCurso = new DataColumn("Curso", typeof(string));

            dtCursos.Columns.Add(dtcolIDCurso);
            dtCursos.Columns.Add(dtcolCurso);

            dtCursos.PrimaryKey = new DataColumn[] { dtcolIDCurso };

            DataRow rwCurso = dtCursos.NewRow();
            rwCurso[dtcolCurso] = "informatica";
            dtCursos.Rows.Add(rwCurso);


            DataSet dsUniversidad = new DataSet();
            dsUniversidad.Tables.Add(dtAlumnos);
            dsUniversidad.Tables.Add(dtCursos);

            DataTable dtAlumnos_Cursos = new DataTable();

            DataColumn dtcolAcAlumno = new DataColumn("IDAlumno", typeof(int));
            DataColumn dtcolAcCurso = new DataColumn("IDCurso", typeof(int));
            dtAlumnos_Cursos.Columns.Add(dtcolAcAlumno);
            dtAlumnos_Cursos.Columns.Add(dtcolAcCurso);

            dsUniversidad.Tables.Add(dtAlumnos_Cursos);

            DataRelation relAlumno_ac = new DataRelation("Alumnos_Cursos", dtcolIDAlumno, dtcolAcAlumno);
            DataRelation relCurso_ac = new DataRelation("Cursos_Alumnos", dtcolIDCurso, dtcolAcCurso);

            dsUniversidad.Relations.Add(relAlumno_ac);
            dsUniversidad.Relations.Add(relCurso_ac);


            DataRow rwAlumnosCursos = dtAlumnos_Cursos.NewRow();
            rwAlumnosCursos[dtcolAcAlumno] = 0;
            rwAlumnosCursos[dtcolAcCurso] = 1;

            DataRow rwAlumnosCursos2 = dtAlumnos_Cursos.NewRow();
            rwAlumnosCursos2[dtcolAcAlumno] = 1;
            rwAlumnosCursos2[dtcolAcCurso] = 1;

            dtAlumnos_Cursos.Rows.Add(rwAlumnosCursos);
            dtAlumnos_Cursos.Rows.Add(rwAlumnosCursos2);

            Console.Write("Por favor, escriba el nombre del curso: ");
            string materia = Console.ReadLine();

            Console.WriteLine("Listado de alumnos de la materia " + materia);

            DataRow[] row_cursoInf = dtCursos.Select("Curso = '" + materia + "'");

            foreach (DataRow rowCu in row_cursoInf)
            {
                DataRow[] row_AlumnosInf = rowCu.GetChildRows(relCurso_ac);

                foreach (DataRow rowAl in row_AlumnosInf)
                {
                    Console.WriteLine(
                        rowAl.GetParentRow(relAlumno_ac)[dtcolApellido].ToString() + ", " + 
                        rowAl.GetParentRow(relAlumno_ac)[dtcolNombre].ToString()
                    );
                }
            }

            Console.ReadLine();
        }
    }
}
