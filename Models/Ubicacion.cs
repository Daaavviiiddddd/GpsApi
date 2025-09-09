using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GpsApi.Models
{
    [Table("ubicaciones")]
    public class Ubicacion
    {
        [Key]
        public int Id { get; set; }
        public string Telefono { get; set; } = string.Empty;
        public string IMEI { get; set; } = string.Empty;
        public decimal? Latitud { get; set; }
        public decimal? Longitud { get; set; }
        public decimal? Velocidad { get; set; }
        public DateTime? FechaHora { get; set; }
        public string MensajeCompleto { get; set; } = string.Empty;
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
