﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TEDU.Model.Model
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        public int ID { set; get; }

        [Required]
        public string Content { set; get; }
    }
}