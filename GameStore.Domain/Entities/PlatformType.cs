using System.Collections.Generic;

namespace GameStore.Domain.Entities
{
    public class PlatformType
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public virtual ICollection<Game> Games { get; set; }

        public PlatformType()
        {
            Games = new List<Game>();
        }
    }
}