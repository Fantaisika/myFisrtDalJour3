using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace myFirstDAL.Models
{
    public class BddContext : DbContext

    {
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Sejour> Sejours { get; set; }
        public DbSet<Sondage> Sondages { get; set; }
        public DbSet<Vote> Votes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //methode OnConfiguring pour la connexion a la bdd (1)
        {


            optionsBuilder.UseMySql("server=localhost;user id=root;password=rrrrr;database=RevisionChoixSejourBDD");



        }
        public void InitializeDb()
        {
            this.Database.EnsureDeleted();//on s'assure que la base est bien supprimé (2)
            this.Database.EnsureCreated();// on s'assure que la base est bien crée (3)
            // creation de notre jeu d'essai
            Utilisateurs.AddRange(new List<Utilisateur>()
                {
                new Utilisateur { Prenom ="Vincent"},
                new Utilisateur { Prenom = "Alix" },
                new Utilisateur { Prenom = "Renaud" },
                new Utilisateur { Prenom = "Fanta" },
                new Utilisateur { Prenom = "Marie" },
                new Utilisateur { Prenom = "Raounak" },
            });

            Sejours.Add(new Sejour() { Lieu = "Toulouse", Telephone = "0102456789" });

            this.SaveChanges();

        }
    }
}