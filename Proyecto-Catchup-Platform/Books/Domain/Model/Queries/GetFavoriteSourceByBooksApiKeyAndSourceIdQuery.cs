namespace Proyecto_Catchup_Platform.Books.Domain.Model.Queries
{
    public record GetFavoriteSourceByBooksApiKeyAndSourceIdQuery(string BooksApiKey, string SourceId)
    {
    }
}
