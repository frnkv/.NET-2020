using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ejercicio05
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

            Console.ReadLine();
        }
    }
}
