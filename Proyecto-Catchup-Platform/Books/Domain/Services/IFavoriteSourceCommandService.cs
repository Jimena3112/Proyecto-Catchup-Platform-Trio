using Proyecto_Catchup_Platform.Books.Domain.Model.Aggregates;

namespace Proyecto_Catchup_Platform.Books.Domain.Services
{
    public interface IFavoriteSourceCommandService
    {
        Task<FavoriteSource> AddSource(FavoriteSource favoriteSource);
        Task<FavoriteSource?> UpdateSource(FavoriteSource favoriteSource);
        Task<bool> DeleteSource(int id);
    }
}
