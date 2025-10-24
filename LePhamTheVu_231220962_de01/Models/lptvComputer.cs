using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace LePhamTheVu_231220962_de01.Models
{
    public class lptvComputer
    {
        [Key]
        public string LePhamTheVuComId { get; set; } = "";

        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        [StringLength(50)]
        public string LePhamTheVuComName { get; set; } = "";


        [Required]
        public decimal LePhamTheVuComPrice { get; set; }

        public string LePhamTheVuComImage { get; set; }

        [Required]
        public bool LePhamTheVuComStatus { get; set; }
    }
}
