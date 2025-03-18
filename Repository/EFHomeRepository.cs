using LeMinhQuy_2280602656_Tuan03.Models;
using Microsoft.EntityFrameworkCore;

namespace LeMinhQuy_2280602656_Tuan03.Repository
{
    public class EFHomeRepository : IHomeRepository
    {
        private readonly ApplicationDbContext _context;
        public EFHomeRepository(ApplicationDbContext context)
        {
            context = _context;
        }
        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
