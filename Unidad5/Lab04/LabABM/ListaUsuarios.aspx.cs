using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace LabABM
{
    public partial class ListaUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                cargarDiasCalendario();
            }

            bool edicion = PaginaEnEstadoEdicion();

            if (edicion == true)
            {
                Usuario u = CargarDatosUsuario(int.Parse(Request.QueryString["id"]));
                this.lblAccion.Text = "Editar Usuario " + u.Id.ToString();
            } else
            {
                this.lblAccion.Text = "Agregar Nuevo Usuario ";
            }
        }

        private bool PaginaEnEstadoEdicion()
        {
            if (Request.QueryString["id"] != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void cargarDiasCalendario()
        {
            int[] values = Enumerable.Range(1, 32 - 1).ToArray();

            foreach (int v in values)
            {
                this.ddlDiaFechaNacimiento.Items.Add(new ListItem(v.ToString(), v.ToString()));
            }
        }


        private Usuario CargarDatosUsuario(int idUsuario)
        {
            ManagerUsuarios manager = new ManagerUsuarios();

            Usuario u = manager.GetUsuario(idUsuario);
            this.txtNombre.Text = u.Nombre;
            this.txtApellido.Text = u.Apellido;
            this.txtAnioFechaNacimiento.Text = u.FechaNac;
            this.txtCelular.Text = u.Celular;
            this.txtClave.Text= u.Clave;
            this.txtConfirmarClave.Text = u.Clave;
            this.txtDirección.Text = u.Direccion;
            this.txtEmail.Text = u.Email;
            this.txtNroDocumento.Text = u.NroDoc.ToString();
            this.txtTelefono.Text = u.Telefono;

            return u;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            ManagerUsuarios manager = new ManagerUsuarios();

            Usuario u = new Usuario();

            u.Nombre = this.txtNombre.Text;
            u.Apellido = this.txtApellido.Text;
            u.FechaNac = this.txtAnioFechaNacimiento.Text;
            u.Celular = this.txtCelular.Text;
            u.Clave = this.txtClave.Text;
            u.Direccion = this.txtDirección.Text;
            u.Email = this.txtEmail.Text;
            u.NroDoc = int.Parse(this.txtNroDocumento.Text);
            u.Telefono = this.txtTelefono.Text;

            manager.AgregarUsuario(u);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ListaUsuarios.aspx");
        }
    }
}