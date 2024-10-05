using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPWeb_equipo_12b
{
    public partial class Error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string mensaje = Request.QueryString["mensaje"];
            if (!string.IsNullOrEmpty(mensaje))
            {
                lblError.Text = mensaje;
            }
            else
            {
                lblError.Text = "Ocurrió un error inesperado. Por favor, intenta nuevamente.";
            }
        }
        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}