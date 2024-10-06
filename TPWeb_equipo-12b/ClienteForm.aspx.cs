﻿using Dominio;
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
                Cliente cliente = new Cliente();
                cliente.Documento = int.Parse(dni);
                cliente.Nombre = nombre;
                cliente.Apellido = apellido;
                cliente.Email = email;
                cliente.Direccion = direccion;
                cliente.Ciudad = ciudad;
                cliente.CP = int.Parse(cp);

                service.AgregarCliente(cliente);
                Response.Redirect("Exito.aspx");
            }
        }
    }
}