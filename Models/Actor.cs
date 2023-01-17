using System.ComponentModel.DataAnnotations;

namespace eMediaStore.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }

        [Display(Name ="Profile Picture URL")]
        public string ProfilePicUrl { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Biography { get; set; }

        public List<Actors_Movies> Actors_Movies { get; set; }



    }
}
