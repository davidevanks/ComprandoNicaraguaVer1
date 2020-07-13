using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComprandoNicaragua.Models
{
    public partial class CatCategorias
    {
        [Key]
        public long Id { get; set; }
        [StringLength(500)]
        public string Categoria { get; set; }
        public bool? Estado { get; set; }

        [InverseProperty("IdNavigation")]
        public virtual Tiendas Tiendas { get; set; }
    }
}
