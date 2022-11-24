using System.ComponentModel.DataAnnotations;

namespace DB_ASP.NET.Models
{
    public class Movie
    {
        public int Id {get; set;}
        public string Title {get; set;}
        [DataType(DataType.DateTime)] public DateTime ReleaseDate {get; set;}
        public string Genre {get; set;}
        public decimal Price {get; set;}
    }
}