﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribir();
            //Leer();

            Console.WriteLine("Presione una tecla para generar el archivo agendaxml.xml con los datos de agenda.txt");
            Console.ReadKey();
            EscribirXML();

            Console.WriteLine("archivo agendaxml.xml generado correctamente \n\n Presione una tecla para ver su contenido");
            Console.ReadKey();
            Console.WriteLine();
            LeerXML();

            Console.ReadKey();
        }

        private static void Leer()
        {
            StreamReader lector = File.OpenText("agenda.txt");

            string linea;

            Console.WriteLine("Nombre\tApellido\te-mail\t\t\tTeléfono");
            do
            {
                linea = lector.ReadLine();

                if (linea != null)
                {
                    string[] valores = linea.Split(';');
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", valores[0], valores[1], valores[2], valores[3]);
                }

            } while (linea != null);

            lector.Close();
        }

        private static void Escribir()
        {
            StreamWriter escritor = File.AppendText("agenda.txt");
            Console.WriteLine("Ingrese nuevo contacto: ");
            string rta = "S";

            while (rta == "S")
            {
                Console.Write("Ingrese nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Ingrese apellido: ");
                string apellido = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Ingrese e-mail: ");
                string email = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Ingrese teléfono: ");
                string telefono = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();

                escritor.WriteLine(nombre + ";" + apellido + ";" + email + ";" + telefono);

                Console.Write("Desea ingresar otro contacto? (S/N)");

                rta = Console.ReadLine();
            }

            escritor.Close();
        }

        private static void EscribirXML()
        {
            XmlTextWriter escritorXML = new XmlTextWriter("agendaxml.xml", null);
            escritorXML.Formatting = Formatting.Indented;
            escritorXML.WriteStartDocument(true);
            escritorXML.WriteStartElement("DocumentElement");

            StreamReader lector = File.OpenText("agenda.txt");

            string linea;

            do
            {
                linea = lector.ReadLine();

                if (linea != null)
                {
                    string[] valores = linea.Split(';');

                    escritorXML.WriteStartElement("contactos");

                    escritorXML.WriteStartElement("nombre");
                    escritorXML.WriteValue(valores[0]);
                    escritorXML.WriteEndElement();

                    escritorXML.WriteStartElement("apellido");
                    escritorXML.WriteValue(valores[1]);
                    escritorXML.WriteEndElement();

                    escritorXML.WriteStartElement("e-mail");
                    escritorXML.WriteValue(valores[2]);
                    escritorXML.WriteEndElement();

                    escritorXML.WriteStartElement("telefono");
                    escritorXML.WriteValue(valores[3]);
                    escritorXML.WriteEndElement();

                    escritorXML.WriteEndElement();
                }

            } while (linea != null);

            escritorXML.WriteEndElement();

            escritorXML.WriteEndDocument();

            escritorXML.Close();

            lector.Close();
        }

        private static void LeerXML()
        {
            XmlTextReader lector = new XmlTextReader("agendaxml.xml");

            string tagAnterior = "";

            while (lector.Read())
            {
                if (lector.NodeType == XmlNodeType.Element)
                {
                    tagAnterior = lector.Name;
                }
                else if (lector.NodeType == XmlNodeType.Text)
                {
                    Console.WriteLine(tagAnterior + ": " + lector.Value);
                }
            }

            lector.Close();
        }
    }
}
