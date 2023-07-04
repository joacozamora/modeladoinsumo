using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsumoOdontologico.BData.Data.Entity
{
    public class Insumo
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El NOMBREINSUMO es obligatorio")]
        [MaxLength(30, ErrorMessage = "Se aceptan hasta 40 caracteres en el NOMBRE")]
        public string NombreInsumo { get; set; }

        
        [Required(ErrorMessage = "El PRECIO es obligatorio")]
        public int Precio { get; set; }

        [Required(ErrorMessage = "La CANTIDAD es obligatoria")]
        public int Cantidad { get; set; }
        
        public int PersonaId { get; set; }
        public Persona Persona { get; set; }
    }
}
