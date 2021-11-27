using System;
using Api.Data.Mapping;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserEntity>(new UserMap().Configure);
            modelBuilder.Entity<AuthorEntity>(new AuthorMap().Configure);
            modelBuilder.Entity<BookEntity>(new BookMap().Configure);

            modelBuilder.Entity<UserEntity>().HasData(
                new UserEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Administrator",
                    Email = "rafael.berto@gx2.com.br",
                    Password = BCrypt.Net.BCrypt.HashPassword("abc123"),
                    CreateAt = DateTime.Now,
                    UpdateAt = DateTime.Now
                }
            );
        }

    }
}