using System.ComponentModel.DataAnnotations;

namespace CatalogBackend.Data.Models
{
    public class ProductModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string name { get; set; }
        public string description { get; set; }
        [Range(1, int.MaxValue)]
        public int quantity { get; set; }
    }
}
