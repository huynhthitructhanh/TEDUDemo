using TEDU.Data.Infrastructure;
using TEDU.Model.Model;


namespace TEDU.Data.Reposotpries
{
    public interface IProductRepository : IRepository<Product>
    {
    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
