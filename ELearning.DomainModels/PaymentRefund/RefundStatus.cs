using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DomainModels
{
    public class RefundStatus
    {
        public int RefundStatusId { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }

        // relationships
        public IEnumerable<RefundRequest> RefundRequests { get; set; }
    }
}
