using System.Threading.Tasks;

namespace JWTAuthenticationDemo.Core.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        void Commit();
    }
}
