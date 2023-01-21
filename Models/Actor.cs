using System.ComponentModel.DataAnnotations;

namespace eMediaStore.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }

        [Display(Name ="Profile Picture URL")]
        [Required (ErrorMessage ="Profile Picture is required")]
        public string ProfilePicUrl { get; set; }

        [Required(ErrorMessage = "Full Name is required")]
        [Display(Name = "Full Name")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Full name must be between 3 and 50 chars")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Biography is required")]
        [Display(Name = "Biography")]
        public string Biography { get; set; }

        public List<Actors_Movies> Actors_Movies { get; set; }
    }
}
