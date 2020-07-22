using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dtEmpresas = new DataTable();
            dtEmpresas.Columns.Add("CustomerID", typeof(string));
            dtEmpresas.Columns.Add("CompanyName", typeof(string));

            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=Northwind;Integrated Security=true";


            SqlDataAdapter myAdap = new SqlDataAdapter("SELECT CustomerID, CompanyName FROM Customers", myConn);

            myConn.Open();

            myAdap.Fill(dtEmpresas);

            myConn.Close();

            Console.WriteLine("Listado de empresas: ");

            foreach (DataRow rowEmpresa in dtEmpresas.Rows)
            {
                string idEmpresa = rowEmpresa["CustomerID"].ToString();
                string nombreEmpresa = rowEmpresa["CompanyName"].ToString();

                Console.WriteLine(idEmpresa + " - " + nombreEmpresa);
            }

            Console.WriteLine("Escriba el CustomerID que desea modificar: ");
            string custid = Console.ReadLine();

            DataRow[] rwEmpresas = dtEmpresas.Select("CustomerID = '" + custid + "'");

            if (rwEmpresas.Length != 1)
            {
                Console.WriteLine("CustomerID no encontrado");
                Console.ReadLine();
                return;
            }

            DataRow rowMiEmpresa = rwEmpresas[0];

            string nombreActual = rowMiEmpresa["CompanyName"].ToString();
            Console.WriteLine("Nombre actual de la empresa: " + nombreActual);

            Console.WriteLine("Escriba el nuevo nombre: ");
            string nuevoNombre = Console.ReadLine();

            rowMiEmpresa.BeginEdit();

            rowMiEmpresa["CompanyName"] = nuevoNombre;

            rowMiEmpresa.EndEdit();

            SqlCommand updCommand = new SqlCommand();

            updCommand.CommandText = "UPDATE Customers SET CompanyName = @CompanyName WHERE CustomerID = @CustomerID ";
            updCommand.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 50, "CompanyName");
            updCommand.Parameters.Add("@CustomerID", SqlDbType.NVarChar, 5, "CustomerID");

            myAdap.UpdateCommand = updCommand;

            myAdap.Update(dtEmpresas);

            Console.ReadLine();
        }
    }
}
