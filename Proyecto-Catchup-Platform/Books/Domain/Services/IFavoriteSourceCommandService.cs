using Proyecto_Catchup_Platform.Books.Domain.Model.Aggregates;

namespace Proyecto_Catchup_Platform.Books.Domain.Services
{
    public interface IFavoriteSourceCommandService
    {
        Task<FavoriteSource> Add(FavoriteSource favoriteSource);
        Task<FavoriteSource?> Update(FavoriteSource favoriteSource);
        Task<bool> Delete(int id);
    }
}
