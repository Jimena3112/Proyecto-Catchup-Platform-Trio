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
    }
}
