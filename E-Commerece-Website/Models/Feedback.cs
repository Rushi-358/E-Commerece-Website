using System.ComponentModel.DataAnnotations;
using System.Globalization;
namespace E_Commerece_Website.Migrations
{
    public class Feedback
    {
        [Key]
        public int feedback_id { get; set; }
        required
        public string user_name
        { get; set; }
        required
        public string user_message
        { get; set; }
    }
}
