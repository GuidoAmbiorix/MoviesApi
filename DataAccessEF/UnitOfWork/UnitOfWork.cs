using DataAccessEF.TypeRepository;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEF.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private MovieContext context;

        public UnitOfWork(MovieContext context)
        {
            this.context = context;
            MovieRepository = new MovieRepository(this.context);
            CategoryRepository = new CategoryRepository(this.context);
        }




        public IMovieRepository MovieRepository
        {
            get;
            private set;
        }

        public ICategoryRepository CategoryRepository
        {
            get;
            private set;
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public int Save()
        {
            return context.SaveChanges();
        }
    }
}
