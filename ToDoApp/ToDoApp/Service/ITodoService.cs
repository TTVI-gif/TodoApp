using System.Collections.Generic;
using System.Threading.Tasks;
using TodoApp.Entities;
using TodoApp.ViewModel;

namespace TodoApp.Service
{
    public interface ITodoService
    {
        Task<IEnumerable<TodoListItem>> GetAllAsync();
        Task<int> CreateAsync(TodoCreateVM todo);
        Task<int> UpdateAsync(TodoListItem todo);
        Task<int> DeleteAsync(int id);
        Task<int> GetLastIdAsync();
        Task<TodoListItem> GetById(int id);
        Task<TodoListItem> CompletedToDoItemAsync(int todoId);
        Task<TodoListItem> MoveUp(int id);
        Task<TodoListItem> MoveDown(int id);
        List<TodoCreateVM> SeedItems();
    }
}
