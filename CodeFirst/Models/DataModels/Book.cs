using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models.DataModels
{
    [Table("Books")]
    public class Book
    {
        [Display(Name = "Mã sách")]
        [StringLength(10)]
        public string BookId { get; set; }

        [Display(Name = "Tên sách")]
        [StringLength(200)]
        public string Title { get; set; }

        [Display(Name = "Tác giả")]
        [StringLength(100)]
        public string Author { get; set; }

        [Display(Name = "Năm xuất bản")]
        public int? Release { get; set; }

        [Display(Name = "Giá")]
        public double? Price { get; set; }

        [Display(Name = "Mô tả")]
        public string Description { get; set; }

        [Display(Name = "Hình ảnh")]
        public string Picture { get; set; }

        [Display(Name = "Mã nhà xuất bản")]
        public int? PublisherId { get; set; }

        [Display(Name = "Mã loại")]
        public int? CategoryId { get; set; }

        // Quan hệ (Navigation properties)
        public virtual Category Category { get; set; }
        public virtual Publisher Publisher { get; set; }
    }
}
