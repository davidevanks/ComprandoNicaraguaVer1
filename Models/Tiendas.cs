using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComprandoNicaragua.Models
{
    public partial class Tiendas
    {
        [Key]
        public long Id { get; set; }
        [Required(ErrorMessage ="Seleccione una categoría")]
        public long? IdCategoria { get; set; }
        [StringLength(500)]
        [Required(ErrorMessage ="Cuenta Instagram es requerido")]
        public string CuentaInstagram { get; set; }
        [StringLength(500)]
        public string CuentaFacebook { get; set; }
        [StringLength(500)]
        public string CuentaTwitter { get; set; }
        [StringLength(100)]
        public string Telefono { get; set; }
        public bool? Aprobado { get; set; }
        public bool? Estado { get; set; }

        [ForeignKey(nameof(IdCategoria))]
        [InverseProperty(nameof(CatCategorias.Tiendas))]
        public virtual CatCategorias IdNavigation { get; set; }
    }
}
