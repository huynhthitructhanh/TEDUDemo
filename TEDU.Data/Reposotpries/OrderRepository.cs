using TEDU.Data.Infrastructure;
using TEDU.Model.Model;

namespace TEDU.Data.Reposotpries
{
    public interface IOrderRepository : IRepository<Order>
    { }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}