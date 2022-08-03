using System.Threading.Tasks;
using TodoApp.EF;
using TodoApp.Repository;
using TodoApp.Repository.Implement;

namespace TodoApp.UOF.Implement
{
    public class UnitOfWord : IUnitOfWord
    {
        private readonly TodoDbContext _context;
        private IDataRepository _dataRepository;
        public UnitOfWord(TodoDbContext context, IDataRepository dataRepository)
        {
            _context = context;
            _dataRepository = dataRepository;
        }
        public IDataRepository DataRepository
        {
            get
            {
                if (_dataRepository == null)
                {
                    _dataRepository = new DataRepository(_context);
                }
                return _dataRepository;
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
