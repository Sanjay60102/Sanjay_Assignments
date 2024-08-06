using HandsOnApiUsingEFCodeFirst.Entities;

namespace HandsOnApiUsingEFCodeFirst.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ECommContext _context;
        public ProductRepository()
        {
            _context = new ECommContext();
        }
        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var product = _context.Products.Find(id);
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product Get(int Id)
        {
            var product = _context.Products.Find(Id);
            return product;
        }

        public void Update(Product product)
        {
            var products = _context.Products.Find(product);
            _context.SaveChanges();
        }
    }
}
