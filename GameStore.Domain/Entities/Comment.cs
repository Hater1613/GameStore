using System.Collections.Generic;

namespace GameStore.Domain.Entities
{
    public class Comment
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Body { get; set; }

        public virtual Game Game { get; set; }

        public int? ParentCommentId { get; set; }

        public virtual Comment ParentComment { get; set; }
    }
}