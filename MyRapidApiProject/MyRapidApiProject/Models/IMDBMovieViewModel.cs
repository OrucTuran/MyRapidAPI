namespace MyRapidApiProject.Models
{
    public class IMDBMovieViewModel
    {
        public string title { get; set; }
        public List<string> genre { get; set; }
        public string GenreDisplay => string.Join(", ", genre);
        public string rating { get; set; }
        public string big_image { get; set; }
        public string imdb_link { get; set; }
    }
}
