using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Entities
{
    public class Categoria : EntityBase
    {
        public int Id { get; set; }
        public string NombreCategoria { get; set; } = null!;
    }
}
