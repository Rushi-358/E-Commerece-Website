using System.ComponentModel.DataAnnotations;
namespace E_Commerece_Website.Migrations
{
    public class Cart
    {
        [Key]

        public int card_id { get; set; }

        public int product_id { get; set; }

        public int customer_id { get; set; }

        public int product_quantity { get; set; }

        public int cart_status { get; set; }
    }
}
