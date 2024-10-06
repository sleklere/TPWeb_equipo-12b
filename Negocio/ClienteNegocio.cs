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
        public int AgregarCliente(Cliente cliente)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("INSERT INTO Clientes (Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP) " +
                    "OUTPUT INSERTED.Id VALUES (@Documento, @Nombre, @Apellido, @Email, @Direccion, @Ciudad, @CP)");
                datos.AgregarParametro("@Id", cliente.Id);
                datos.AgregarParametro("@Documento", cliente.Documento);
                datos.AgregarParametro("@Nombre", cliente.Nombre);
                datos.AgregarParametro("@Apellido", cliente.Apellido);
                datos.AgregarParametro("@Email", cliente.Email);
                datos.AgregarParametro("@Direccion", cliente.Direccion);
                datos.AgregarParametro("@Ciudad", cliente.Ciudad);
                datos.AgregarParametro("@CP", cliente.CP);

                int id = (int)datos.EjecutarEscalar();
                return id;
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

        public Cliente BuscarClienteByDNI(int dni)
        {
            AccesoDatos datos = new AccesoDatos();
            Cliente cliente = null;

            try
            {
                datos.SetearConsulta("SELECT * FROM Clientes WHERE Documento = @Documento");
                datos.AgregarParametro("@Documento", dni);
                datos.EjecutarLectura();

                if (datos.Lector.Read())
                {
                    cliente = new Cliente();
                    cliente.Nombre = (string)datos.Lector["Nombre"];
                    cliente.Apellido = (string)datos.Lector["Apellido"];
                    cliente.Email = (string)datos.Lector["Email"];
                    cliente.Direccion = (string)datos.Lector["Direccion"];
                    cliente.Ciudad = (string)datos.Lector["Ciudad"];
                    cliente.CP = (int)datos.Lector["CP"];
                    
                    return cliente;
                }
                else
                {
                    return null;
                }
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
