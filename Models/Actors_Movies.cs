namespace eMediaStore.Models
{
    public class Actors_Movies
    {
        public int MovieId { get; set; }
        public int ActorId { get; set; }
        public Movie Movie { get; set; }
        public Actor Actor { get; set; }

    }
}
