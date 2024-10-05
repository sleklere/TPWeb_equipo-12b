using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using ManejoDB;

namespace Negocio
{
    public class VoucherNegocio
    {
        public Voucher GetVoucherInDB(string codigo)
        {
            AccesoDatos datos = new AccesoDatos();
            Voucher voucher = null;
            try
            {
                datos.SetearConsulta("SELECT CodigoVoucher, IdCliente, FechaCanje, IdArticulo FROM Vouchers WHERE CodigoVoucher = @CodigoVoucher");
                datos.AgregarParametro("@CodigoVoucher", codigo);
                datos.EjecutarLectura();

                if (datos.Lector.Read())
                {
                    voucher = new Voucher();
                    voucher.CodigoVoucher = (string)datos.Lector["CodigoVoucher"];
                    voucher.IdCliente = datos.Lector["IdCliente"] != DBNull.Value ? (int)datos.Lector["IdCliente"] : -1;
                    voucher.IdArticulo = datos.Lector["IdArticulo"] != DBNull.Value ? (int)datos.Lector["IdArticulo"]: -1;
                }

                return voucher;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }


        }
    }
}
