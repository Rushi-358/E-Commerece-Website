using System.ComponentModel.DataAnnotations;
using System.Globalization;
namespace E_Commerece_Website.Models
{
    public class Product
    {
        [Key]
        public int product_id { get; set; }
        required
        public string product_string { get; set; }
        required
        public string product_price { get; set; }
        required
        public string product_description { get; set; }
        required 
        public string product_image { get; set; }
        
        public int cat_id { get; set; }
    }
}
