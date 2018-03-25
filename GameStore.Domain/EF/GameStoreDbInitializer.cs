using GameStore.Domain.Entities;
using System.Collections.Generic;
using System.Data.Entity;

namespace GameStore.Domain.EF
{
    public class GameStoreDbInitializer : DropCreateDatabaseIfModelChanges<GameStoreContext>
    {
        protected override void Seed(GameStoreContext context)
        {
            var strategy = new Genre { Id = 1, Name = "Strategy" };
            var rpg = new Genre { Id = 2, Name = "RPG" };
            var sports = new Genre { Id = 3, Name = "Sports" };
            var races = new Genre { Id = 4, Name = "Races" };
            var action = new Genre { Id = 5, Name = "Action" };
            var adventure = new Genre { Id = 6, Name = "Adventure" };
            var puzzle = new Genre { Id = 7, Name = "Puzzle&Skill" };
            var rts = new Genre
            {
                Name = "RTS",
                ParentGenreId = strategy.Id,
                ParentGenre = strategy
            };
            var tbs = new Genre
            {
                Name = "TBS",
                ParentGenreId = strategy.Id,
                ParentGenre = strategy
            };
            var rally = new Genre
            {
                Name = "Rally",
                ParentGenreId = races.Id,
                ParentGenre = races
            };
            var arcade = new Genre
            {
                Name = "Arcade",
                ParentGenreId = races.Id,
                ParentGenre = races
            };
            var formula = new Genre
            {
                Name = "Formula",
                ParentGenreId = races.Id,
                ParentGenre = races
            };
            var offRoad = new Genre
            {
                Name = "Off-Road",
                ParentGenreId = races.Id,
                ParentGenre = races
            };
            var fps = new Genre
            {
                Name = "FPS",
                ParentGenreId = action.Id,
                ParentGenre = action
            };
            var tps = new Genre
            {
                Name = "TPS",
                ParentGenreId = action.Id,
                ParentGenre = action
            };
            var misc = new Genre
            {
                Name = "Misc",
                ParentGenreId = action.Id,
                ParentGenre = action
            };
            context.Genres.AddRange(new List<Genre>()
            {
                strategy, rpg, sports, races, action, adventure, puzzle,
                rts, tbs, rally, arcade, formula, offRoad, fps, tps, misc
            });
            var mobile = new PlatformType { Type = "Mobile" };
            var browser = new PlatformType { Type = "Browser" };
            var desktop = new PlatformType { Type = "Desktop" };
            var console = new PlatformType { Type = "Console" };
            context.PlatformTypes.AddRange(new List<PlatformType> { mobile, browser, desktop, console });
            var halfLife = new Game
            {
                Key = "g1",
                Name = "Half-Life",
                Description = "1998 год. HALF-LIFE шокирует игровую индустрию сочетанием напряженного действия и непрерывного," +
               " затягивающего сюжета. Дебютная игра Valve завоевала свыше 50 наград «Игра года» на пути к получению титула" +
               " «Лучшая игра для РС всех времен» от PC Gamer; она раскрутила франшизу, которая продала свыше восьми миллионов" +
               " коробочных версий по всему миру.",
                Genres = new List<Genre>() { action, fps },
                PlatformTypes = new List<PlatformType>() { desktop }
            };
            context.Games.Add(halfLife);
            context.Comments.Add(new Comment
            {
                Name = "Отличная игра",
                Body = "Игра очень понравилась",
                Game = halfLife
            });
            context.Comments.Add(new Comment
            {
                Name = "Крутая игра",
                Body = "Полностью согласен",
                Game = halfLife,
                ParentCommentId = 1
            });
            base.Seed(context);
        }
    }
}