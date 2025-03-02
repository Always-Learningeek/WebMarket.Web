using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebMarket.Web.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage="عنوان دسته اجبرای هست")]
        [DisplayName("عنوان دسته")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "ترتیب نمایش اجباری هست ")]
        [DisplayName("ترتیب نمایش")]
        [Range(1, 100, ErrorMessage = "رینجش باید یک تا صد باشد")]
        public int DisplayOrder { get; set; }

        public DateTime CreateDateTime { get; set; }


    }
}