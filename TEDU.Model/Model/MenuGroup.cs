using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TEDU.Model.Model
{
    [Table("MenuGroups")]
    public class MenuGroup
    {
        [Key]
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }
    }
}