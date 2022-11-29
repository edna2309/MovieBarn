using MovieBarn.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBarn.BusinessLogic.Contracts
{
    public interface IFilmRepository 
    {
        Task<List<FilmVM>> GetFilms();
    }
}
