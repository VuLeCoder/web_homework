using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models.DataModels
{
    [Table("Categories")]
    public class Category
    {
        [Display(Name = "Mã loại")]
        public int CategoryId { get; set; }

        [Display(Name = "Tên loại")]
        [StringLength(100)]
        public string CategoryName { get; set; }

        // Thuộc tính quan hệ: 1 Category có nhiều Book
        public virtual ICollection<Book> Books { get; set; }

        public Category()
        {
            Books = new HashSet<Book>();
        }
    }
}
