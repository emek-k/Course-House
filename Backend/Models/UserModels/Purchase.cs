using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CourseHouse.Models;

namespace CourseHouse.Models
{
    [Table("Purchases")]
    public class Purchase
    {
        [Key]
        public int PurchaseId { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        [ForeignKey("CreditCard")]
        public int CreditCardId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime PurchasedOn { get; set; } = DateTime.Now;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Spend { get; set; }
    }
}
