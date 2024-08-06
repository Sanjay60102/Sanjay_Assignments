using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnApiUsingEFCodeFirst.Entities
{
    public class Product
    {
        [Key] //set Id as a Primary Key
        public int ProductId { get; set; }
        [Column(TypeName ="varchar")] //set column type as varchar
        [StringLength(50)]//set size of thr varchar
        public string Name { get; set; }//set not null constraint
        public int Price { get; set; }
        public int? Stock { get; set; }//set null constraint
    }
}
