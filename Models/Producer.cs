using System.ComponentModel.DataAnnotations;

namespace eMediaStore.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }
        public string ProfilePicUrl { get; set; }
        public string FullName { get; set; }
        public string Biography { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
