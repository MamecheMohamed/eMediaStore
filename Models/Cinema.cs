using System.ComponentModel.DataAnnotations;

namespace eMediaStore.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaId { get; set; }

        [Display(Name="Logo")]
        public string logo { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
        public List<Movie> Movies { get; set; }

    }
}
