using HandsOnApiUsingEFCodeFirst.Entities;

namespace HandsOnApiUsingEFCodeFirst.Repositories
{
    public interface IProductAsyncRepository
    {
        Task<List<Product>> GetAll();
        Task<Product> GetById (int id);
        Task Update (Product product);
        Task DeleteById (int id);
        Task Added(Product product);
    }
}
