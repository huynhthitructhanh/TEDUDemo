using TEDU.Data.Infrastructure;
using TEDU.Model.Model;

namespace TEDU.Data.Reposotpries
{
    public interface IPostRepository : IRepository<Post>
    { }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}