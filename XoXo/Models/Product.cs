using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace XoXo.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }


        [ForeignKey("Category")]
        public int? CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
