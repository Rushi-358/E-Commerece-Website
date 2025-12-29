using System.ComponentModel.DataAnnotations;
namespace E_Commerece_Website.Models
{
    public class Customer
    {
        [Key]

        public int customer_id { get; set; }
        required
        public string customer_name { get; set; }
        required
        public string customer_phone { get; set; }
        required
        public string customer_email { get; set; }
        required
        public string customer_password { get; set; }
        required
        public string customer_gender { get; set; }
        required
        public string customer_country { get; set; }
        required
        public string customer_city { get; set; }
        required
        public string customer_address { get; set; }
        required
        public int customer_image { get; set; }


    }
}
