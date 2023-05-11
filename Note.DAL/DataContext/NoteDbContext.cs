using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Note.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note.DAL.DataContext
{
    public class NoteDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public NoteDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Notice> Notices { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Memo> Memos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
