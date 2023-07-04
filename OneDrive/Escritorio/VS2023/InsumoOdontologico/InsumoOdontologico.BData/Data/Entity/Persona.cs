using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsumoOdontologico.BData.Data.Entity
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        

        [Required(ErrorMessage = "El NOMBRE es obligatorio")]
        [MaxLength(30, ErrorMessage = "Se aceptan hasta 30 caracteres en el NOMBRE")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El APELLIDO es obligatorio")]
        [MaxLength(30, ErrorMessage = "Se aceptan hasta 30 caracteres en el APELLIDO")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El ROL es obligatorio")]
        [MaxLength(20, ErrorMessage = "Se aceptan hasta 20 caracteres en el ROL")]
        public string Rol { get; set; }

          
        public Insumo Insumo { get; set; }



    }
}
