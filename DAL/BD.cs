using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class BD:DbContext
    {
        public BD()
        {
        }
        public BD(DbContextOptions<BD> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer("Server=THINKPAD\\SQL2022;Database=PostMain;Trusted_Connection=true;trustservercertificate=true"));
        }
        public DbSet<EL.Usuarios> Usuarios { get; set; }
        public DbSet<EL.Parametros> Parametros { get; set; }
    }
}
