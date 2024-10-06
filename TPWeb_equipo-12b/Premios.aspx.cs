using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPWeb_equipo_12b
{
    public partial class Premios : System.Web.UI.Page
    {
        public List<Articulo> listaArticulos;
        private void Cargar()
        {
            ArticuloNegocio service = new ArticuloNegocio();
            try
            {
                listaArticulos = service.listarArticulos();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}