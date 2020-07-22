using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Ejercicio04
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

            SqlCommand myComando = new SqlCommand();
            myComando.CommandText = "SELECT CustomerID, CompanyName FROM Customers";

            myComando.Connection = myConn;

            SqlDataAdapter myAdap = new SqlDataAdapter("SELECT CustomerID, CompanyName FROM Customers", myConn);

            myConn.Open();

            SqlDataReader myReader = myComando.ExecuteReader();

            dtEmpresas.Load(myReader);

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
