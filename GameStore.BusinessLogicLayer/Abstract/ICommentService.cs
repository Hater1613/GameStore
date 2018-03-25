using GameStore.BusinessLogicLayer.DTO;
using GameStore.Domain.Entities;
using System.Collections.Generic;

namespace GameStore.BusinessLogicLayer.Abstract
{
    public interface ICommentService
    {
        IEnumerable<CommentDTO> GetCommentsByGameKey(string key);
        void AddComment(CommentDTO commentDto);
    }
}