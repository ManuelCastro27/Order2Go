using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Order2Go.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }

        [Required(ErrorMessage = "El {0} es requerido.")]
        [StringLength(60, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres.", MinimumLength = 5)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El {0} es requerido.")]
        [StringLength(60, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres.", MinimumLength = 10)]
        [Display(Name = "Decripción")]
        public string Descripcion { get; set; }

        public decimal Precio { get; set; }
        public int IdComercio { get; set; }

        public virtual Restaurante Restaurante { get; set; }
    }
}
