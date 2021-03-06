﻿using PersonalBox.Domain.Entities;
using PersonalBox.Infra.Mapping;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PersonalBox.Infra.Context
{
    public class PersonalBoxContext : DbContext
    {
        public DbSet<Usuario> Users { get; set; }
        public PersonalBoxContext():base("PersonBoxDB")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Retirando a opção do Entity FrameWork inserir nome em plural nas tabelas de banco de dados
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            // Não deleta em cascata de um para muitos
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            // Não deleta em cascata de muitos para muitos
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(x => x.Name == x.ReflectedType.Name + "Id")
                .Configure(x => x.IsKey());

            modelBuilder.Properties<string>()
                .Configure(x => x.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(x => x.HasMaxLength(100));

            modelBuilder.Configurations.Add(new UsuarioConfiguration());
            modelBuilder.Configurations.Add(new TransacaoFincanceiraConfiguration());
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
