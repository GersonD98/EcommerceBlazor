using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceBlazor.Shared.Request
{
    public class ProductoDtorequest
    {
        public string Nombre { get; set; } = null!;
        public string CodigoSku { get; set; } = null!;
        public int IdCategoria { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}
