using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EL
{
    [Table("Parametros")]
    public class Parametros
    {
        [Key]
        public byte IdParametro { get; set; }
        [Required]
        [MaxLength(100)]
        public string Descripcion { get; set; } = string.Empty;
        [Required]
        [MaxLength(100)]
        public string Valor { get; set; } = string.Empty;
        [Required]
        [MaxLength(100)]
        public string TipoDato { get; set; } = string.Empty;
        [Required]
        public bool Activo { get; set; }

    }
}
