using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity {get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category {get; set;}
    }
}