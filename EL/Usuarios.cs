using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EL
{
    [Table("Usuarios")]
    public class Usuarios
    {
        [Key]
        public int IdUsuario { get; set; }
        [Required]
        [MaxLength(200)]
        public string NombreCompleto { get; set; } = string.Empty;
        [Required]
        [MaxLength(200)]
        public string Correo { get; set; } = string.Empty;
        [Required]
        [MaxLength(50)]
        public string UserName { get; set; } = string.Empty;

        [Required]
        public byte[] Password { get; set; } = [];

        [Required]
        public byte Intentos { get; set; } = 0;

        [Required]
        public bool Bloqueado { get; set; }
        [Required]
        public bool Activo { get; set; }

        [Required]
        public int UsuarioRegistra { get; set; }

        [Required]
        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        public int? UsuarioActualiza { get; set; }
        public DateTime? FechaActualizacion { get; set; }


    }
}
