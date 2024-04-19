using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DomainModels
{
    public class PaymentMethod
    {
        public int PaymentMethodId { get; set; }
        public string PaymentMethodName { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;


        // relationships
        public IEnumerable<Payment> Payments { get; set; }
    }
}
