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
    public class QuestionRepository : Repository<Question>, IQuestionRepository
    {
        private readonly ELearningDbContext _context;

        public QuestionRepository(ELearningDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<int> CreateQuestionTypeAsync(QuestionType questionType)
        {
            _context.Set<QuestionType>().Add(questionType);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteQuestionTypeAsync(QuestionType questionType)
        {
            _context.Set<QuestionType>().Remove(questionType);
            return await _context.SaveChangesAsync();
        }

        public async Task<QuestionType> GetQuestionTypeByIdAsync(int id)
        {
            return await _context.QuestionTypes.FindAsync(id);
        }

        public async Task<QuestionType> GetQuestionTypeByNameAsync(string name)
        {
            return await _context.QuestionTypes.FirstOrDefaultAsync(m => m.TypeName.Equals(name));
        }

        public async Task<List<QuestionType>> GetAllQuestionTypeAsync()
        {
            return await _context.QuestionTypes.ToListAsync();
        }

        public async Task<int> UpdateQuestionTypeAsync(QuestionType questionType)
        {
            _context.Entry(questionType).State = EntityState.Modified;
            return await _context.SaveChangesAsync();
        }
    }
}
