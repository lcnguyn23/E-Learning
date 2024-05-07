using ELearning.Data.Repositories.Interfaces;
using ELearning.DomainModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Implementations
{
    public class PaymentRepository : Repository<Payment>, IPaymentRepository
    {
        private readonly ELearningDbContext _context;

        public PaymentRepository(ELearningDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<int> CreatePaymentMethodTypeAsync(PaymentMethod paymentMethod)
        {
            _context.Set<PaymentMethod>().Add(paymentMethod);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeletePaymentMethodTypeAsync(PaymentMethod paymentMethod)
        {
            _context.Set<PaymentMethod>().Remove(paymentMethod);
            return await _context.SaveChangesAsync();
        }

        public async Task<PaymentMethod> GetPaymentMethodByIdAsync(int id)
        {
            return await _context.PaymentMethods.FindAsync(id);
        }

        public async Task<PaymentMethod> GetPaymentMethodByNameAsync(string name)
        {
            return await _context.PaymentMethods.FirstOrDefaultAsync(m => m.PaymentMethodName.Equals(name));
        }

        public async Task<List<PaymentMethod>> GetAllPaymentMethodAsync()
        {
            return await _context.PaymentMethods.ToListAsync();
        }

        public async Task<int> UpdatePaymentMethodTypeAsync(PaymentMethod paymentMethod)
        {
            _context.Entry(paymentMethod).State = EntityState.Modified;
            return await _context.SaveChangesAsync();
        }
    }
}
