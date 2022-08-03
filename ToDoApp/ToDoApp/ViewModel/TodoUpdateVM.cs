using System.ComponentModel.DataAnnotations;

namespace TodoApp.ViewModel
{
    public class TodoUpdateVM
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150, ErrorMessage = "Title must contain a maximum of 150 characters!")]
        public string Title { get; set; }
        //public bool IsCompleted { get; set; } = false;
    }
}
