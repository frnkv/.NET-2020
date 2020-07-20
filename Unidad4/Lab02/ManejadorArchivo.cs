using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{

    class ManejadorArchivo
    {
        protected DataTable misContactos;

        public ManejadorArchivo()
        {
            this.misContactos = this.getTabla();
        }

        public virtual DataTable getTabla()
        {
            return new DataTable();
        }

        public virtual void aplicaCambios()
        {

        }

        public void Listar()
        {
            foreach (DataRow fila in this.misContactos.Rows)
            {
                if (fila.RowState != DataRowState.Deleted)
                {
                    foreach (DataColumn columna in this.misContactos.Columns)
                    {
                        Console.WriteLine("{0}: {1}", columna.ColumnName, fila[columna]);
                    }

                    Console.WriteLine();
                }
            }
        }

        public void nuevaFila()
        {
            DataRow fila = this.misContactos.NewRow();

            foreach (DataColumn col in this.misContactos.Columns)
            {
                Console.WriteLine("Ingrese {0}: ", col.ColumnName);

                fila[col] = Console.ReadLine();
            }

            this.misContactos.Rows.Add(fila);
        }

        public void editarFila()
        {
            Console.WriteLine("Ingrese el numero de fila a editar");
            int nroFila = int.Parse(Console.ReadLine());

            DataRow fila = this.misContactos.Rows[nroFila - 1];

            for (int nroCol = 1; nroCol < this.misContactos.Columns.Count; nroCol++)
            {
                DataColumn col = this.misContactos.Columns[nroCol];
                Console.WriteLine("Ingrese {0}: ", col.ColumnName);

                fila[col] = Console.ReadLine();
            }
        }

        public void EliminarFila()
        {
            Console.WriteLine("Ingrese el numero de fila a eliminar");
            int nroFila = int.Parse(Console.ReadLine());

            this.misContactos.Rows[nroFila - 1].Delete();
        }
    }
}
