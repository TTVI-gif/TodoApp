using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Entities;
using TodoApp.Service;
using TodoApp.ViewModel;

namespace TodoApp.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoService _todoService;

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        public async Task<IActionResult> SeedItems()
        {
            var listTodo = _todoService.SeedItems();
            foreach (var item in listTodo)
            {
                await _todoService.CreateAsync(item);
            }
            var list_item = _todoService.GetAllAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Index(string keywork)
        {
            var todos = await _todoService.GetAllAsync();
            if (!string.IsNullOrEmpty(keywork))
            {
                ViewBag.keyWork = keywork;
                keywork = keywork.ToLower();
                todos = todos.Where(x => x.Title.ToLower().Contains(keywork));
            }
            var list1_completed = new List<TodoListItem>();
            var list2_incomplete = new List<TodoListItem>();

            foreach (var item in todos)
            {
                if (item.IsCompleted)
                {
                    list1_completed.Add(item);
                }
                else
                {
                    list2_incomplete.Add(item);
                }
            }
            ViewBag.list1_completed = list1_completed;
            ViewBag.list2_incomplete = list2_incomplete;



            return View(todos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(TodoCreateVM todoCreateVM)
        {
            await _todoService.CreateAsync(todoCreateVM);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var todo = await _todoService.GetById(id);
            var editVm = new TodoUpdateVM()
            {
                Id = todo.Id,
                Title = todo.Title
            };
            return View(editVm);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(TodoListItem todo)
        {
            await _todoService.UpdateAsync(todo);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var todoDl = new TodoDeleteVM()
            {
                Id = id
            };
            return View(todoDl);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(TodoDeleteVM todo)
        {
            await _todoService.DeleteAsync(todo.Id);
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Completed(int id)
        {
            var todoCompleted = await _todoService.CompletedToDoItemAsync(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> MoveUp(int id)
        {
            var todoMoveUp = await _todoService.MoveUp(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> MoveDown(int id)
        {
            var todoMoveDown = await _todoService.MoveDown(id);
            return RedirectToAction("Index");
        }
    }
}
