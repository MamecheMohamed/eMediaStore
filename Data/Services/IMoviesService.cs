using eMediaStore.Data.Base;
using eMediaStore.Data.ViewModels;
using eMediaStore.Models;

namespace eMediaStore.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
       
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);

    }
}
