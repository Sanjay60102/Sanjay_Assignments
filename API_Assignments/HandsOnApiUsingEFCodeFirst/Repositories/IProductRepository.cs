using HandsOnApiUsingEFCodeFirst.Entities;

namespace HandsOnApiUsingEFCodeFirst.Repositories
{
    public interface IProductRepository
    {
        void Add(Product product);
        Product Get(int Id);
        List<Product> GetAll();
        void Delete(int id);
        void Update(Product product);
    }
}
