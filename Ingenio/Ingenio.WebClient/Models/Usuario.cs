using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ingenio.WebClient.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Column("Usuario")]
        [StringLength(20)]
        public string Usuariox { get; set; }

        [StringLength(10)]
        public string Contraseña { get; set; }
    }
}