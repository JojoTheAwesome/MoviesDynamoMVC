﻿using MovieRank.Libs.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieRank.Libs.Repositories {
    public interface IMovieRankRepository {
        Task<IEnumerable<MovieDb>> GetAllItems();
        Task<MovieDb> GetMovie(int userId, string movieName);
        Task<IEnumerable<MovieDb>> GetUsersRankedMoviesByMovieTitle(int userId, string movieName);
        Task AddMovie(MovieDb movieDb);
        Task UpdateMovie(MovieDb request);
        Task<IEnumerable<MovieDb>> GetMovieRank(string movieName);
        Task<IEnumerable<MovieDb>> GetAllItemsForUser(int userId);
        Task DeleteMovie(MovieDb request);
    }
}
