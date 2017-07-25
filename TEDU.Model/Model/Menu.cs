using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TEDU.Model.Model
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }
        public string URL { set; get; }
        public int? DisplayOrder { set; get; }
        public int GroupID { set; get; }
        public string Target { set; get; }
        public bool Status { set; get; }
    }
}