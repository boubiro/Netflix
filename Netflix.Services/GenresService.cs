﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Netflix.Domain.Models.MovieContext;
using Netflix.Repositories;
using Netflix.Repositories.AzureEntities;

namespace Netflix.Services
{
    public interface IGenresService
    {
        Task<List<Genre>> GetAllGenres();
        Task<Genre> GetGenreByName(string name);
    }

    public class GenresService: AbstractService, IGenresService
    {
        private readonly IGenresRepository _genresRepository;
        private readonly IMapper _mapper;

        public GenresService(IGenresRepository genresRepository, IMapper mapper)
        {
            _genresRepository = genresRepository;
            _mapper = mapper;
        }

        public async Task<List<Genre>> GetAllGenres()
        {
            var genres = await _genresRepository.GetAllGenres();
            return genres.Select(_mapper.Map<GenreEntity, Genre>).ToList();
        }

        public async Task<Genre> GetGenreByName(string name)
        {
            var genre = await _genresRepository.GetGenreByName(name);
            return _mapper.Map<GenreEntity, Genre>(genre);
        }

    }
}
