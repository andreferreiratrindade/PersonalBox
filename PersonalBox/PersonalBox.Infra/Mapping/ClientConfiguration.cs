using PersonalBox.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBox.Infra.Mapping
{
  public  class ClientConfiguration : EntityTypeConfiguration<Client>
    {
        public ClientConfiguration()
        {
            HasKey(x => x.ClientId);

            Property(x => x.Name)
                .IsRequired();
                
        }
    }
}
