using Ingenio.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenio.Data
{
    public class IngenioConext : DbContext
    {
        public IngenioConext() : base("name=IngenioContext")
        {
        }

        public virtual DbSet<Clima> Clima { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clima>()
                .Property(e => e.Ciudad)
                .IsUnicode(false);

            modelBuilder.Entity<Clima>()
                .Property(e => e.Temperatura)
                .IsUnicode(false);

            modelBuilder.Entity<Clima>()
                .Property(e => e.Viento)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Usuariox)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Contraseña)
                .IsUnicode(false);
        }
    }
}
