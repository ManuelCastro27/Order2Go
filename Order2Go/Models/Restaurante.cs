using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Order2Go.Models
{
    public class Restaurante
    {
        [Key]
        public int IdRestaurante { get; set; }

        [Required(ErrorMessage = "El {0} es requerido.")]
        [StringLength(60, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres.", MinimumLength = 5)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El {0} es requerido.")]
        [StringLength(90, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres.", MinimumLength = 10)]
        [Display(Name = "Decripción")]
        public string Descripcion { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "El {0} es requerido.")]
        [StringLength(8, ErrorMessage = "El {0} debe tener un maximo de {1} caracteres.")]
        public int Telefono { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }


    }
}
