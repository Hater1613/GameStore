using System.Collections.Generic;

namespace GameStore.Domain.Entities
{
    public class Genre
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? ParentGenreId { get; set; }

        public virtual Genre ParentGenre { get; set; }

        public virtual ICollection<Game> Games { get; set; }

        public Genre()
        {
            Games = new List<Game>();
        }
    }
}
