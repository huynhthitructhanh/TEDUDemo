﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TEDU.Model.Model
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        [Column(Order = 1)]
        public int OrderID { set; get; }

        [Key]
        [Column(Order = 2)]
        public int ProductID { set; get; }

        public int Quantity { set; get; }
        public decimal Price { set; get; }

        [ForeignKey("OrderID")]
        public virtual Order Orders { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Products { set; get; }
    }
}