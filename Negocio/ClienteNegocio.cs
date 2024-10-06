using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using ManejoDB;

namespace Negocio
{
    public class ClienteNegocioo
    {
        public void AgregarCliente(Cliente cliente)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("INSERT INTO Clientes VALUES (@Documento, @Nombre, @Apellido, @Email, @Direccion, @Ciudad, @CP)");
                datos.AgregarParametro("@Id", cliente.Id);
                datos.AgregarParametro("@Documento", cliente.Documento);
                datos.AgregarParametro("@Nombre", cliente.Nombre);
                datos.AgregarParametro("@Apellido", cliente.Apellido);
                datos.AgregarParametro("@Email", cliente.Email);
                datos.AgregarParametro("@Direccion", cliente.Direccion);
                datos.AgregarParametro("@Ciudad", cliente.Ciudad);
                datos.AgregarParametro("@CP", cliente.CP);
                datos.EjecutarLectura();
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
