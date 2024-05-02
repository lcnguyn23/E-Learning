using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface IPaymentRepository
    {
        Task<List<Payment>> GetAllPaymentsAsync();
        Task<Payment> GetPaymentByIdAsync(int id);
        Task<int> CreatePaymentAsync(Payment payment);
        Task<int> UpdatePaymentAsync(Payment payment);
        Task<int> DeletePaymentAsync(int id);
    }
}
