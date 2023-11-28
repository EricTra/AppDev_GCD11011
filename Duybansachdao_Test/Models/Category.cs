using System.ComponentModel.DataAnnotations;

namespace Duybansachdao_Test.Models
{
    public class Category
    {
        [Key] // nho set khoa chinh
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="Please enter category name")] //not null
        public string Name { get; set; }
        public string Description { get; set; }
        [Range(1,100)]
        public int DisplayOrder { get; set; }
       
    }
}
