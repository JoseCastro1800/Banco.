using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class CuentaPension:Cuenta
        //creacion de cuenta pension y se hereda los atributos de la clase cuenta
    {
        public DateTime Expiration { get; set; }
        public int Quotation { get; set; }
        public int NAccountPrincipal { get; set; }
    }
}
