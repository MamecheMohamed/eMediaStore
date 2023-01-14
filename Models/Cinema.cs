using System.ComponentModel.DataAnnotations;

namespace eMediaStore.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaId { get; set; }
        public string logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Movie> Movies { get; set; }

    }
}
