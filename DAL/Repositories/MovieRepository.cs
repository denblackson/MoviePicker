using DAL.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace DAL.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly AppDbContext _context;

        public MovieRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Movie>> GetMoviesAsync()
        {
            return await _context.Movies.ToListAsync();
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            return await _context.Movies.FindAsync(id);
        }

        public async Task AddMovieAsync(Movie movie)
        {
            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateMovieAsync(Movie movie)
        {
            _context.Movies.Update(movie);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMovieAsync(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Movie>> SearchMoviesByTitle(string title)
        {
            return await _context.Movies.Where(m => m.Title.Contains(title)).ToListAsync();
        }

        public async Task<IEnumerable<Movie>> SearchMoviesByDirector(string director)
        {
            return await _context.Movies.Where(m => m.Director.Contains(director)).ToListAsync();
        }

        public async Task<IEnumerable<Movie>> SearchMoviesByGenre(string genre)
        {
            return await _context.Movies.Where(m => m.Genre.Contains(genre)).ToListAsync();

        }

        public async Task<IEnumerable<Movie>> SearchMoviesByYear(int year)
        {
            return await _context.Movies.Where(m => m.Year == year).ToListAsync();
        }
    }
}
