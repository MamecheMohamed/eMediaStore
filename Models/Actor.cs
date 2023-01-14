using System.ComponentModel.DataAnnotations;

namespace eMediaStore.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        public string ProfilePicUrl { get; set; }
        public string FullName { get; set; }
        public string Biography { get; set; }
        public List<Actors_Movies> Actors_Movies { get; set; }



    }
}
