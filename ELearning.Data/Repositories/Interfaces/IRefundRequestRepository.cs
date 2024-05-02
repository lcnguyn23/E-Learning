using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface IRefundRequestRepository
    {
        Task<List<RefundRequest>> GetAllRefundRequestsAsync();
        Task<RefundRequest> GetRefundRequestByIdAsync(int id);
        Task<int> CreateRefundRequestAsync(RefundRequest request);
        Task<int> UpdateRefundRequestByIdAsync(RefundRequest request);
        Task<int> DeleteRefundRequestByIdAsync(int id);
    }
}
