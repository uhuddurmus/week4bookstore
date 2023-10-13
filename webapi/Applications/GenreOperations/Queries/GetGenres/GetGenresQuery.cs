using AutoMapper;
using webapi.DBOperations;

namespace webapi.Applications.GenreOperations.Queries.GetGenres
{
    public class GetGenresQuery
    {
        private readonly IBookStoreDbContext _dbContext;

        private readonly IMapper _mapper;

        public GetGenresQuery(IBookStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public List<GenresViewModel> Handle()
        {
            var genres = _dbContext.Genres.Where(genre => genre.isActive).ToList();
            List<GenresViewModel> vm = _mapper.Map<List<GenresViewModel>>(genres);
            return vm;
        }
    }

    public class GenresViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
