using System.ComponentModel.DataAnnotations;

namespace WorkWebAPI.Models
{
    public class Work
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string WorkName { get; set; }
        
    }
}
