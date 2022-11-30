using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MovieBarn.BusinessLogic.Contracts;
using MovieBarn.Common.Models;
using MovieBarn.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBarn.BusinessLogic.Repositories
{
    public class FilmRepository : IFilmRepository
    {
        private readonly ApplicationDbContext applicationDbContext;
        private readonly IMapper mapper;

        public FilmRepository(ApplicationDbContext applicationDbContext, IMapper mapper) 
        {
            this.applicationDbContext = applicationDbContext;
            this.mapper = mapper;
        }

        public async Task<List<FilmVM>> GetFilms()
        {
            var films = applicationDbContext.Films.ToListAsync();
            if(films == null)
            {
                return new List<FilmVM>();
            }
            return mapper.Map<List<FilmVM>>(films);

        }
    }
}
