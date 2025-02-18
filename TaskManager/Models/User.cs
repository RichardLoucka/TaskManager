using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{
    public class User
    {
        public int id { get; set; }
        
        [Required]
        public string name { get; set; }
    }
}