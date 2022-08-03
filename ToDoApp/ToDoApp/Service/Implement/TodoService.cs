using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoApp.Entities;
using TodoApp.Service;
using TodoApp.UOF;
using TodoApp.ViewModel;

namespace TodoApp.Service.Implement
{
    public class TodoService : ITodoService
    {
        private readonly IUnitOfWord _unitOfWord;
        public TodoService(IUnitOfWord unitOfWord)
        {
            _unitOfWord = unitOfWord;
        }

        public async Task<TodoListItem> CompletedToDoItemAsync(int todoId)
        {
            var todo = await _unitOfWord.DataRepository.GetByIdAsync(todoId);
            if (todo == null)
            {
                return null;
            }
            else
            {
                todo.IsCompleted = true;
                await _unitOfWord.SaveChangesAsync();
                return todo;
            }
        }

        public async Task<int> CreateAsync(TodoCreateVM todoCreateVM)
        {
            var todo = new TodoListItem()
            {
                Id = await GetLastIdAsync() + 1,
                AddDate = DateTime.Now,
                Title = todoCreateVM.Title,
                IsCompleted = false,
                Index = false
            };
            await _unitOfWord.DataRepository.AddAsync(todo);
            await _unitOfWord.SaveChangesAsync();
            return todo.Id;
        }

        public async Task<int> DeleteAsync(int id)
        {
            var todo = await _unitOfWord.DataRepository.GetByIdAsync(id);
            if (todo == null)
            {
                return 0;
            }
            else
            {
                await _unitOfWord.DataRepository.DeleteAsync(id);
                await _unitOfWord.SaveChangesAsync();
                return todo.Id;
            }
        }

        public async Task<IEnumerable<TodoListItem>> GetAllAsync()
        {
            var todos = await _unitOfWord.DataRepository
                                            .GetAllAsync();
            return todos;
        }

        public async Task<TodoListItem> GetById(int id)
        {
            var todo = await _unitOfWord.DataRepository.GetByIdAsync(id);
            if (todo == null)
            {
                return null;
            }
            return todo;
        }

        public async Task<int> GetLastIdAsync()
        {
            var todo = await _unitOfWord.DataRepository.GetLastEntityAsync();
            if (todo == null)
                return 0;
            return todo.Id;
        }

        public async Task<TodoListItem> MoveUp(int id)
        {
            var todo = await _unitOfWord.DataRepository.GetByIdAsync(id);
            todo.Index = true;
            await _unitOfWord.SaveChangesAsync();
            return todo;
        }

        public async Task<TodoListItem> MoveDown(int id)
        {
            var todo = await _unitOfWord.DataRepository.GetByIdAsync(id);
            todo.Index = false;
            await _unitOfWord.SaveChangesAsync();
            return todo;
        }

        public async Task<int> UpdateAsync(TodoListItem todoUpdateVM)
        {
            var todo = await _unitOfWord.DataRepository.GetByIdAsync(todoUpdateVM.Id);
            if (todo == null)
            {
                return 0;
            }
            todo.Title = todoUpdateVM.Title;
            _unitOfWord.DataRepository.Update(todo);
            await _unitOfWord.SaveChangesAsync();
            return todo.Id;
        }

        public List<TodoCreateVM> SeedItems()
        {
            List<TodoCreateVM> listTodo = new List<TodoCreateVM>();
            for (int i = 1; i < 5; i++)
            {
                bool true_exress = false;
                if (i % 2 == 0) true_exress = false;
                TodoCreateVM item = new TodoCreateVM
                {
                    AddDate = DateTime.Now.AddDays(i),
                    Id = i,
                    IsCompleted = true_exress,
                    Title = $"Item {i}",
                    Index = true_exress
                };
                listTodo.Add(item);
            }
            return listTodo;
        }

        /*  public async Task<TodoListItem> MoveUp(int id)
          {
              var todo = await _unitOfWord.DataRepository.GetByIdAsync(id);

              var listTodos = await _unitOfWord.DataRepository
                                              .GetAllAsync();

              for (int i = 1; i < listTodos.Count; i++)
              {
                  if (listTodos[i].Id == id)
                  {
                      var temp = todo.Index;
                      todo.Index = listTodos[i - 1].Index;
                      listTodos[i - 1].Index = temp;

                      break;
                  }
              }
              await _unitOfWord.SaveChangesAsync();

              return todo;
          }

          public async Task<TodoListItem> MoveDown(int id)
          {
              var todo = await _unitOfWord.DataRepository.GetByIdAsync(id);

              var listTodos = await _unitOfWord.DataRepository
                                              .GetAllAsync();

              for (int i = 0; i < listTodos.Count - 1; i++)
              {
                  if (listTodos[i].Id == id)
                  {
                      var temp = todo.Index;
                      todo.Index = listTodos[i + 1].Index;
                      listTodos[i + 1].Index = temp;

                      break;
                  }
              }
              await _unitOfWord.SaveChangesAsync();
              return todo;
          }*/

    }
}
