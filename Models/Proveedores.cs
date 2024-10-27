using System;
using System.ComponentModel.DataAnnotations;

namespace ApiEmpresa.Models
{
    public class Proveedores
    {
        [Key]
        public int id_proveedor { get; set; }
        
        [Required]
        [StringLength(10)]
        public string nit { get; set; }

        [Required]
        [StringLength(60)]
        public string proveedor { get; set; }
        
        [StringLength(100)]
        public string? direccion { get; set; }
        
        [StringLength(60)]
        public string? razon_social { get; set; }

        [Required]
        public DateTime fecha_creacion { get; set; }
    }
}