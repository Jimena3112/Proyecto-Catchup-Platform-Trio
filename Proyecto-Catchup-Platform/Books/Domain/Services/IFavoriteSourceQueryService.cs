using Proyecto_Catchup_Platform.Books.Domain.Model.Aggregates;
using Proyecto_Catchup_Platform.Books.Domain.Model.Queries;

namespace Proyecto_Catchup_Platform.Books.Domain.Services
{
    public interface IFavoriteSourceQueryService
    {
        Task<FavoriteSource?> Handle(GetFavoriteSourceByIdQuery query);
        Task<FavoriteSource?> Handle(GetFavoriteSourceByBooksApiKeyAndSourceIdQuery query);
    }
}
