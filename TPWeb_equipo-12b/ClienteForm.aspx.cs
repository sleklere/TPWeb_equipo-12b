using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPWeb_equipo_12b
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ClienteNegocioo service = new ClienteNegocioo();
            VoucherNegocio serviceVoucher = new VoucherNegocio();

            string dni = txtDNI.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string email = txtEmail.Text;
            string direccion = txtDireccion.Text;
            string ciudad = txtCiudad.Text;
            string cp = txtCP.Text;
            bool terminosAceptados = chkTerminos.Checked;

            if (string.IsNullOrWhiteSpace(dni) ||
                string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(direccion) ||
                string.IsNullOrWhiteSpace(ciudad) ||
                string.IsNullOrWhiteSpace(cp) ||
                !terminosAceptados)
            {
                lblError.Text = "Por favor, completa todos los campos y acepta los términos y condiciones para participar.";
                lblError.Visible = true;
            }
            else
            {
                lblError.Visible = false;

                int dniParsed = int.Parse(dni);
                Cliente clienteExistente = service.BuscarClienteByDNI(dniParsed);

                if (clienteExistente != null)
                {
                    Console.WriteLine(clienteExistente.Id);
                    Voucher voucher = (Voucher)Session["voucher"];
                    voucher.IdCliente = clienteExistente.Id;
                    serviceVoucher.AsociarConCliente(voucher.CodigoVoucher, clienteExistente.Id);

                    Response.Redirect("Exito.aspx");
                }
                else
                {
                    Cliente cliente = new Cliente();
                    cliente.Documento = dniParsed;
                    cliente.Nombre = nombre;
                    cliente.Apellido = apellido;
                    cliente.Email = email;
                    cliente.Direccion = direccion;
                    cliente.Ciudad = ciudad;
                    cliente.CP = int.Parse(cp);

                    int clienteId = service.AgregarCliente(cliente);

                    if (clienteId != -1)
                    {
                        Voucher voucher = (Voucher)Session["voucher"];
                        voucher.IdCliente = clienteId;
                        serviceVoucher.AsociarConCliente(voucher.CodigoVoucher, clienteId);

                        Response.Redirect("Exito.aspx");
                    }
                }
            }
        }

        protected void dni_onBlur(object sender, EventArgs e)
        {
            int dni = int.Parse(txtDNI.Text);
            ClienteNegocioo service = new ClienteNegocioo();
            Cliente cliente = service.BuscarClienteByDNI(dni);

            if (cliente != null)
            {
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtEmail.Text = cliente.Email;
                txtDireccion.Text = cliente.Direccion;
                txtCiudad.Text = cliente.Ciudad;
                txtCP.Text = cliente.CP.ToString();
            }
        }
    }
}