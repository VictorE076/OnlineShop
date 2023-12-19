using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Models
{
    public class Comanda
    {
        [Key]
        public int Id { get; set; }

        public int? Valoare { get; set; }

        public string? Stare { get; set; }

        public DateTime? Data { get; set; }

        [Required(ErrorMessage = "ID-ul utilizatorului este obligatoriu")]
        public int? UtilizatorId { get; set; }
    }
}
