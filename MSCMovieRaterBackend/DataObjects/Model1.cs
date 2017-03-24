namespace MSCMovieRaterBackend.DataObjects
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Movie> Movie { get; set; }
        public virtual DbSet<Rate> Rate { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>()
                .Property(e => e.createdAt)
                .HasPrecision(3);

            modelBuilder.Entity<Movie>()
                .Property(e => e.createdAt)
                .HasPrecision(3);

            modelBuilder.Entity<Movie>()
                .Property(e => e.updatedAt)
                .HasPrecision(3);

            modelBuilder.Entity<Movie>()
                .Property(e => e.version)
                .IsFixedLength();
        }
    }
}
