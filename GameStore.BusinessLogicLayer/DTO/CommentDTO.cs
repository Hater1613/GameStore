﻿using System.Collections.Generic;

namespace GameStore.BusinessLogicLayer.DTO
{
    public class CommentDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Body { get; set; }

        public int GameId { get; set; }

        public int? ParentCommentId { get; set; }

        public CommentDTO ParentComment { get; set; }
    }
}