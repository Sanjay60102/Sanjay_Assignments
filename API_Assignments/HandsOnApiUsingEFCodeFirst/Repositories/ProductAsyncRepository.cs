using HandsOnApiUsingEFCodeFirst.Entities;
using Microsoft.EntityFrameworkCore;

namespace HandsOnApiUsingEFCodeFirst.Repositories
{
    public class ProductAsyncRepository : IProductAsyncRepository
    {
        private readonly ECommContext _context;
        public ProductAsyncRepository(ECommContext context)
        {
            _context = context;
        }


        

        public async Task<List<Product>> GetAll()
        {
            return await _context.Products.ToListAsync();
        }
        public async Task<Product> GetById(int id)
        {
            return await _context.Products.SingleOrDefaultAsync(p=>p.ProductId==id);
        }

        public async Task Update(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }
        public async Task Added(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteById(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }
    }
}
