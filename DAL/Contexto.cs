using CrearOtroRegistro.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace CrearOtroRegistro.DAL
{
    public class Contexto : DbContext 
    {
        internal object RollId;

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Roll> Rolls { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = GestionDeUsuarios.Db");
        }
    }
}
