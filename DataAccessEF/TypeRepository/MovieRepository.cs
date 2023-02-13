using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEF.TypeRepository
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieContext context) : base(context)
        {
        }

        public IEnumerable<Movie> GetBestMovies()
        {
            return context.Movie.Where(x => x.IdCategory == 1).ToList();
        }
    }
}
