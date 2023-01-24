using eMediaStore.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eMediaStore.Models
{
    public class Producer : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePicUrl { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Biography { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
