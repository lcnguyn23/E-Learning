using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface IPaymentRepository : IRepository<Payment>
    {

        // Payment method
        Task<List<PaymentMethod>> GetAllPaymentMethodAsync();
        Task<PaymentMethod> GetPaymentMethodByIdAsync(int id);
        Task<PaymentMethod> GetPaymentMethodByNameAsync(string name);
        Task<int> CreatePaymentMethodTypeAsync(PaymentMethod paymentMethod);
        Task<int> UpdatePaymentMethodTypeAsync(PaymentMethod paymentMethod);
        Task<int> DeletePaymentMethodTypeAsync(PaymentMethod paymentMethod);
    }
}
