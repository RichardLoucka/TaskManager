using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{
    public class user
    {
        public int id { get; set; }
        
        [Required]
        public string name { get; set; }
    }
}