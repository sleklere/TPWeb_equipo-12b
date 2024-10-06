using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPWeb_equipo_12b
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            VoucherNegocio voucherNegocio = new VoucherNegocio();
            string codigo = inputCodigo.Text;

            try
            {
                Voucher voucher = voucherNegocio.GetVoucherInDB(codigo);

                if (voucher == null)
                {
                    Response.Redirect("Error.aspx?mensaje=El código ingresado no es válido.", false);
                } else if (voucher.IdCliente != -1)
                {
                    Response.Redirect("Error.aspx?mensaje=El código ingresado ya ha sido utilizado.", false);
                }
                else
                {
                    Session["voucher"] = voucher;
                    Response.Redirect("Premios.aspx", false);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Response.Redirect("Error.aspx?mensaje=Ocurrió un error al procesar tu solicitud.", false);
            }
        }
    }
}