using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.EF;
using TodoApp.Entities;

namespace TodoApp.Repository.Implement
{
    public class DataRepository : IDataRepository
    {
        private readonly TodoDbContext _context;

        public DataRepository(TodoDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(TodoListItem entity)
        {
            await _context.AddAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var items = await _context.TodoListItems.FirstOrDefaultAsync(x => x.Id == id);
            if (items != null)
            {
                _context.TodoListItems.Remove(items);
            }
        }

        public async Task<List<TodoListItem>> GetAllAsync()
        {
            /* 
             1 a,2000
             2 b,2001 -- Move Up
             3 c,2002

            Sau Move Up
            2 a
            1 b
            3 c

            OrderBy tu dong chinh lai stt
            1 b,2001
            2 a
            3 c
            */
            return await _context.TodoListItems.OrderByDescending(s => s.Index)
                             .ToListAsync();
        }

        public async Task<TodoListItem> GetByIdAsync(int id)
        {
            return await _context.TodoListItems.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<TodoListItem> GetLastEntityAsync()
        {
            //get list item
            var items = await _context.TodoListItems.ToListAsync();
            //get last item
            var lastItem = items.LastOrDefault();
            return lastItem;
        }



        public void Update(TodoListItem entity)
        {
            _context.Update(entity);
        }
    }
}
