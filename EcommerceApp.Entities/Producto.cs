using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Entities
{
    public class Producto : EntityBase
    {
        public string CodigoSku { get; set; } = null!;
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public Categoria Categoria { get; set; } = null!;
        public int CategoriaId { get; set; } //fk
        public decimal PrecioUnitario { get; set; }

    }
}
