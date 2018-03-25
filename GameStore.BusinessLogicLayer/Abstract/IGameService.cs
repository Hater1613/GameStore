using GameStore.BusinessLogicLayer.DTO;
using GameStore.BusinessLogicLayer.Infrastructure;
using System.Collections.Generic;

namespace GameStore.BusinessLogicLayer.Abstract
{
    public interface IGameService
    {
        IEnumerable<GameDTO> GetGamesList();
        IEnumerable<GameDTO> GetGamesByGenre(int genreId);
        IEnumerable<GameDTO> GetGamesByPlatformType(int platformTypeId);
        GameDTO GetGameByKey(string key);
        OperationDetails AddGame(GameDTO gameDto);
        OperationDetails UpdateGame(GameDTO gameDto);
        OperationDetails DeleteGame(GameDTO gameDto);
    }
}
