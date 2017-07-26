using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEDU.Model.Model
{
    public class Order
    {
        public int ID { set; get; }
        public string CustomerName { set; get; }
        public string CustomerAddress { set; get; }
        public string CustomerEmail { set; get; }
        public string CustomerMobile{ set; get; }
        public string CustomerMessage { set; get; }
        public DateTime CreateDate { set; get; }
        public string CreateBy { set; get; }
        public string PaymentMethod { set; get; }
        public string PaymentStatus { set; get; }
        public bool Status { set; get; }
    }
}
