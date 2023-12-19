using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace OnlineShop.Models
{
    public class Review
    {
        // Composite Primary Key
        [Key, Column(Order = 0)]
        public int UtilizatorId { get; set; }

        [Key, Column(Order = 1)]
        public int ProdusId { get; set; }
        //

        public string? Continut { get; set; }
    }
}
