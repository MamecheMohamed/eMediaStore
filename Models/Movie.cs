using eMediaStore.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eMediaStore.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display (Name="Image")]
        public string ImageUrl { get; set; }
        public string Price { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
        public List<Actors_Movies> Actors_Movies { get; set; }

        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}
