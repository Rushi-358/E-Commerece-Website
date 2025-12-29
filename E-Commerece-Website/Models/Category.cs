using System.ComponentModel.DataAnnotations;
namespace E_Commerece_Website.Migrations
{
    public class Category
    {
        [Key]

        public int category_id { get; set; }

        required
        public string category_name
        { get; set; }
    }
}
