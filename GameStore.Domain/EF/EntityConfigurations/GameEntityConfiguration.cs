﻿using GameStore.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;

namespace GameStore.Domain.EF.EntityConfigurations
{
    public class GameEntityConfiguration : EntityTypeConfiguration<Game>
    {
        public GameEntityConfiguration()
        {
            Property(p => p.Key)
                .HasMaxLength(450)
                .HasColumnAnnotation("Index", new IndexAnnotation(new[] 
                {
                    new IndexAttribute("Index") { IsUnique = true }
                }));
            HasMany(g => g.Comments)
                .WithOptional(c => c.Game);
            HasMany(g => g.Genres)
                .WithMany(g => g.Games);
            HasMany(g => g.PlatformTypes)
                .WithMany(p => p.Games);
        }
    }
}