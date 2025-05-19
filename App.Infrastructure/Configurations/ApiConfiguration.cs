using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using App.ApplicationCore.Domain;

namespace App.Infrastructure.Configurations
{
    internal class ApiConfiguration : IEntityTypeConfiguration<Visionnage>
    {
        public void Configure(EntityTypeBuilder<Visionnage> builder)
        {
            // builder.HasMany(e => e.Flights).WithOne(e => e.Plane).OnDelete(DeleteBehavior.ClientSetNull);
            builder.HasOne(c => c.Programme)
                  .WithMany(v => v.Visionnages)
                  .HasForeignKey(c => c.ProgrammeKey);

            builder.HasOne(c => c.Utilisateur)
                   .WithMany(cl => cl.Visionnages)
                   .HasForeignKey(c => c.UtilisateurKey);

            builder.HasKey(c => new { c.ProgrammeKey, c.UtilisateurKey, c.DateVisionnage });


            //config la colonne qui represente le Discriminator de la hierarchie héritage par defaut entre Utilisateur,Premium,Standard afin qu elle soit nommé TypeUrilisateur et qu elle soit de type int en definissant une valeur pour chaque type

        }
    }
}
