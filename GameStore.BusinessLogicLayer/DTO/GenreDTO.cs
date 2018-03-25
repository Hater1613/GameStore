using System.Collections.Generic;

namespace GameStore.BusinessLogicLayer.DTO
{
    public class GenreDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? ParentGenreId { get; set; }

        public GenreDTO ParentGenre { get; set; }
    }
}