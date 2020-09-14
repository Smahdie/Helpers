using CsvHelper.Configuration.Attributes;

namespace Test.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Name("Book Title")]        
        public string Title { get; set; }

        [Name("Writer Name")]
        public string Writer { get; set; }

        [Name("Publication Year")]
        public int? PublicationYear { get; set; }
    }
}
