using System.Collections.Generic;
using System.Threading.Tasks;
using TodoApp.Entities;

namespace TodoApp.Repository
{
    public interface IDataRepository
    {
        Task AddAsync(TodoListItem createVM);
        void Update(TodoListItem entity);
        Task<List<TodoListItem>> GetAllAsync();
        Task<TodoListItem> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task<TodoListItem> GetLastEntityAsync();
    }
}
