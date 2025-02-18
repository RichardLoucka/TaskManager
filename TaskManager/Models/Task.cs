namespace TaskManager.Models;

namespace TaskManager.Models
{
    public class Task
    {
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; }
        
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        
    }
}