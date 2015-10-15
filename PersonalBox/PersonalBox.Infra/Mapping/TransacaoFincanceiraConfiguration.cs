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

            HasRequired(x => x.User)
                .WithMany()
                .HasForeignKey(x=>x.UserId);
        }
    }
}
