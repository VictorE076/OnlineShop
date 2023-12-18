using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Models
{
    public class TipUtilPermisAttribute : ValidationAttribute
    {
        private readonly string[] _TipUtilPermis = { "Utilizator", "Colaborator", "Administrator" };

        public override bool IsValid(object value)
        {
            if (value is string tip)
            {
                return _TipUtilPermis.Contains(tip);
            }
            return false;
        }
    }

    public class Utilizator
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tipul utilizatorului este obligatoriu")]
        [TipUtilPermis(ErrorMessage = "Tip de utilizator nepermis")]
        public string? Tip { get; set; }

        public string? Nume { get; set; }
        
        public string? Prenume { get; set; }

        [Required(ErrorMessage = "Email-ul utilizatorului este obligatoriu")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Parola este obligatorie")]
        [MaxLength(48, ErrorMessage = "Titlul nu poate avea mai mult de 48 de caractere")]
        [MinLength(8, ErrorMessage = "Lungimea minima trebuie sa fie de 8 caractere")]
        public string? Parola { get; set; }

        public string? Telefon { get; set; }
    }
}
