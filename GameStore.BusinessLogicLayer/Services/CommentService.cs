using AutoMapper;
using GameStore.BusinessLogicLayer.Abstract;
using GameStore.BusinessLogicLayer.DTO;
using GameStore.Domain.Abstract;
using GameStore.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace GameStore.BusinessLogicLayer.Services
{
    public class CommentService : ICommentService
    {
        private readonly IUnitOfWork database;

        public CommentService(IUnitOfWork database)
        {
            this.database = database;
        }

        public void AddComment(CommentDTO commentDto)
        {
            var game = database.Games.GetItem(commentDto.GameId);
            if(game != null)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<CommentDTO, Comment>();
                }).CreateMapper();
                var comment = config.Map<CommentDTO, Comment>(commentDto);
                comment.Game = game;
                database.Comments.Add(comment);
                database.Commit();
            }
        }

        public IEnumerable<CommentDTO> GetCommentsByGameKey(string key)
        {
            var commentList = database.Comments.GetList()
                .Where(c => c.Game.Key == key).ToList();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<IEnumerable<Comment>, List<CommentDTO>>();
            }).CreateMapper();
            var comments = config.Map<IEnumerable<Comment>, List<CommentDTO>>(commentList);
            return comments;
        }
    }
}