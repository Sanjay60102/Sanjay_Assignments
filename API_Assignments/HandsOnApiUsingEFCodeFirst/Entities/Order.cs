using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

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

        //Navigation Property
        [JsonIgnore]
        public Product? Product { get; set; }
        [ForeignKey("UserId")] //ForeignKey
        [JsonIgnore]
        public User? User { get; set; }
    }
}
