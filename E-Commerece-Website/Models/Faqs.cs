using System.ComponentModel.DataAnnotations;
namespace E_Commerece_Website.Models
{
    public class Faqs
    {
        [Key]
        public int faq_id { get; set; }
        required
        public string faq_question { get; set; }
        required
        public string faq_answer { get; set; }

    }
}
