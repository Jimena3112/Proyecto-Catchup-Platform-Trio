using Proyecto_Catchup_Platform.Books.Domain.Model.Aggregates;
using Proyecto_Catchup_Platform.Books.Domain.Model.Queries;
using Proyecto_Catchup_Platform.Books.Domain.Services;

namespace Proyecto_Catchup_Platform.Books.Application.Internal
{
    public class FavoriteSourceQueryService : IFavoriteSourceQueryService
    {
        public Task<FavoriteSource?> Handle(GetFavoriteSourceByIdQuery query)
        {
            throw new NotImplementedException();
        }

        public Task<FavoriteSource?> Handle(GetFavoriteSourceByBooksApiKeyAndSourceIdQuery query)
        {
            throw new NotImplementedException();
        }

        private List<FavoriteSource> _favoriteSources = new();

        public Task<FavoriteSource?> Handle(GetFavoriteSourceByIdQuery query)
        {
            var source = _favoriteSources.FirstOrDefault(fs => fs.id == query.id);
            return Task.FromResult(source);
        }

        public Task<FavoriteSource?> Handle(GetFavoriteSourceByBooksApiKeyAndSourceIdQuery query)
        {
            var source = _favoriteSources.FirstOrDefault(fs => fs.BooksApiKey == query.BooksApiKey && fs.SourceId == query.SourceId);
            return Task.FromResult(source);
        }

        public Task<FavoriteSource> AddSource(FavoriteSource favoriteSource)
        {
            _favoriteSources.Add(favoriteSource);
            return Task.FromResult(favoriteSource);
        }

        public Task<bool> DeleteSource(int id)
        {
            var existingSource = _favoriteSources.FirstOrDefault(fs => fs.id == id);
            if (existingSource == null)
            {
                return Task.FromResult(false);
            }

            _favoriteSources.Remove(existingSource);
            return Task.FromResult(true);
        }

        public Task<List<FavoriteSource>> GetAllSources()
        {
            return Task.FromResult(_favoriteSources);
        }

        public Task<FavoriteSource?> GetById(int id)
        {
            var source = _favoriteSources.FirstOrDefault(fs => fs.id == id);
            return Task.FromResult<FavoriteSource?>(source);
        }
    }
}
