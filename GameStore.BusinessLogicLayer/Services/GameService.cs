using AutoMapper;
using GameStore.BusinessLogicLayer.Abstract;
using GameStore.BusinessLogicLayer.DTO;
using GameStore.BusinessLogicLayer.Infrastructure;
using GameStore.Domain.Abstract;
using GameStore.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace GameStore.BusinessLogicLayer.Services
{
    public class GameService : IGameService
    {
        private readonly IUnitOfWork database;

        public GameService(IUnitOfWork database)
        {
            this.database = database;
        }

        public OperationDetails AddGame(GameDTO gameDto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<GameDTO, Game>();
            }).CreateMapper();
            var newGame = config.Map<GameDTO, Game>(gameDto);
            database.Games.Add(newGame);
            database.Commit();
            return new OperationDetails(true);
        }

        public OperationDetails DeleteGame(GameDTO gameDto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<GameDTO, Game>();
            }).CreateMapper();
            var game = config.Map<GameDTO, Game>(gameDto);
            database.Games.Delete(game);
            database.Commit();
            return new OperationDetails(true);
        }

        public IEnumerable<GameDTO> GetGamesList()
        {
            var games = database.Games.GetList().ToList();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Game, GameDTO>();
            }).CreateMapper();
            var result = config.Map<IEnumerable<Game>, List<GameDTO>>(games);
            return result;
        }

        public GameDTO GetGameByKey(string key)
        {
            var game = database.Games.GetList()
                .Where(g => g.Key == key).FirstOrDefault();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Game, GameDTO>();
            }).CreateMapper();
            return config.Map<Game, GameDTO>(game);
        }

        public OperationDetails UpdateGame(GameDTO gameDto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<GameDTO, Game>();
            }).CreateMapper();
            var game = config.Map<GameDTO, Game>(gameDto);
            database.Games.Update(game);
            database.Commit();
            return new OperationDetails(true);
        }

        public IEnumerable<GameDTO> GetGamesByGenre(int genreId)
        {
            var genre = database.Genres.GetItem(genreId);
            if (genre == null)
                throw new ServiceException("Genre not found", null);
            var games = genre.Games.ToList();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<IEnumerable<Game>, List<GameDTO>>();
            }).CreateMapper();
            return config.Map<IEnumerable<Game>, List<GameDTO>>(games);
        }

        public IEnumerable<GameDTO> GetGamesByPlatformType(int platformTypeId)
        {
            var platformType = database.PlatformTypes.GetItem(platformTypeId);
            if (platformType == null)
                throw new ServiceException("PlatformType not found", null);
            var games = platformType.Games.ToList();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<IEnumerable<Game>, List<GameDTO>>();
            }).CreateMapper();
            return config.Map<IEnumerable<Game>, List<GameDTO>>(games);
        }
    }
}