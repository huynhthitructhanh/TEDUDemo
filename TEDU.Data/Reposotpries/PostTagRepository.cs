using TEDU.Data.Infrastructure;
using TEDU.Model.Model;

namespace TEDU.Data.Reposotpries
{
    public interface IPostTagRepository : IRepository<PostTag>
    {
    }

    public class PostTagRepository : RepositoryBase<PostTag>, IPostTagRepository
    {
        public PostTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
