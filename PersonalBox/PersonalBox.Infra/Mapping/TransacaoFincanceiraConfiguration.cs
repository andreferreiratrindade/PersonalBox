using PersonalBox.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PersonalBox.Infra.Mapping
{
    public   class TransacaoFincanceiraConfiguration : EntityTypeConfiguration<TransacaoFinanceira>
    {
        public TransacaoFincanceiraConfiguration()
        {
            HasKey(x => x.TransacaoFincanceiraId);
            Property(x => x.Valor)
                .IsRequired();

            Property(x => x.Descricao)
                .IsRequired();

            Property(x => x.DataReferencia)
                .IsRequired();

            Property(x => x.UsuarioId)
                .HasMaxLength(128);

            HasRequired(x => x.Usuario)
                .WithMany()
                .HasForeignKey(x=>x.UsuarioId);
        }
    }
}
