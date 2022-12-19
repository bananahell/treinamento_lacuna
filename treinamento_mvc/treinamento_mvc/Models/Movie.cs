﻿namespace treinamento_mvc.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public int Rank { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Storyline { get; set; }

        #region RETRIEVE

        public static List<Movie> SelectAll()
        {
            var movies = new List<Movie>()
            {
                new Movie()
                {
                    Id = 1, Rank = 9, Title  = "The Shawshank Redemption", Year = 1994, Storyline = "Two imprisoned med bond over a number of years..."
                },
                new Movie()
                {
                    Id = 2, Rank = 9, Title  = "The Godfather", Year = 1972, Storyline = "The aging patriarch of an organizes crime dynasty..."
                },
                new Movie()
                {
                    Id = 3, Rank = 9, Title  = "The Godfather - Part II", Year = 1974, Storyline = "The early life and career of Vito Corleone in 1920s..."
                },
                new Movie()
                {
                    Id = 4, Rank = 9, Title  = "The Dark Knight", Year = 2008, Storyline = "When the menace known as the Joker wreaks havoc..."
                }

            };
            return movies;
        }
        #endregion
    }
}
