using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandsOnApiUsingEFCodeFirst.Entities
{
    public class Order
    {
        [Key] //Primary Key
        public Guid OrderId { get; set; }
        [ForeignKey("Product")] //ForeignKey
        public int ProductId { get; set; }
        [Column(TypeName ="Date")]
        public DateTime OrderDate { get; set; }

        public int UserId { get; set; }

        //Navigation Peoperty
        public Product Product { get; set; }
        [ForeignKey("UserId")] //ForeignKey
        public User User { get; set; }
    }
}
