using System.Threading.Tasks;
using TodoApp.Repository;

namespace TodoApp.UOF
{
    public interface IUnitOfWord
    {
        IDataRepository DataRepository { get; }
        void SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
