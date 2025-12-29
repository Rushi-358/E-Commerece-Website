using System.ComponentModel.DataAnnotations;

namespace E_Commerece_Website.Models
{
    public class Admin
    {
        [Key]
        public int admin_id { get; set; }
        required
        public string admin_name { get; set; }
        required
        public string admin_email { get; set; }
        required
        public string admin_password { get; set; }
        required
        public string admin_image { get; set; }
        
    }
}
