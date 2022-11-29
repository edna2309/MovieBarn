using AutoMapper;
using MovieBarn.Common.Models;
using MovieBarn.Data;

namespace StudentManagementSystem.Data.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Film, FilmVM>().ReverseMap();
        }
    }
}
