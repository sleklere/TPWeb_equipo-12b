using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Voucher
    {
        public string CodigoVoucher { get; set; }
        public int IdCliente { get; set; }
        public string FechaCanje { get; set; }
        public int IdArticulo { get; set; }

    }
}
