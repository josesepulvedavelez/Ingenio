using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ingenio.WebClient.Models
{
    public class Clima
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Ciudad { get; set; }

        public DateTime? FechaHora { get; set; }

        [Required]
        [StringLength(10)]
        public string Temperatura { get; set; }

        public double Humendad { get; set; }

        [Required]
        [StringLength(10)]
        public string Viento { get; set; }
    }
}