using TEDU.Data.Infrastructure;
using TEDU.Model.Model;

namespace TEDU.Data.Reposotpries
{
    public interface IFooterRepository : IRepository<Footer>
    {
    }

    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}