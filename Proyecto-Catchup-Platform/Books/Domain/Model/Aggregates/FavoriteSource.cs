namespace Proyecto_Catchup_Platform.Books.Domain.Model.Aggregates
{
    public class FavoriteSource
    {
        public int id { get; private set; }
        public string BooksApiKey { get; private set; }
        public string SourceId { get; private set; }
        public string bookName { get; private set; }
        public string bookAuthor { get; private set; }
        public string bookGenre { get; private set; }
        public string publicationDate { get; private set; }
        public string editorial {  get; private set; }

        public FavoriteSource()
        {
            this.BooksApiKey = string.Empty;
            this.SourceId = string.Empty;
            this.bookName = string.Empty;
            this.bookAuthor = string.Empty;
            this.bookGenre = string.Empty;
            this.publicationDate = string.Empty;
            this.editorial = string.Empty;
        }
    }
}
