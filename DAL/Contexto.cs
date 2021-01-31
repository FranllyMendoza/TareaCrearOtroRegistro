using CrearOtroRegistro.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace CrearOtroRegistro.DAL
{
    public class Contexto : DbContext 
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = GestionDeUsuarios.Db");
        }
    }
}
