namespace MovieManagement.Models
{
    public class MovieRepository
    {
        static List<Movie> movies = new List<Movie>()
        {
            new Movie(){MovieId=1, Title="Bahubali", Actor="Prabas", language="Telugu", Director="Rajamouli"},
            new Movie(){MovieId=2, Title="Eega", Actor="Nani", language="Telugu", Director="Rajamouli"},
            new Movie(){MovieId=3, Title="Devara", Actor="Ntr", language="Telugu", Director="Shiva"},
            new Movie(){MovieId=4, Title="Pushpa", Actor="Allu Arjun", language="Telugu", Director="Sukumar"}
        };
        public List<Movie> GetAllMovies()
        {
            return movies;
        }
        public Movie GetMovie(string Title)
        {
            return movies.Single(x => x.Title == Title);
        }
        public void Add(Movie movie)
        {
            movies.Add(movie);
        }
    }
}
