using PersonalBox.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PersonalBox.Infra.Mapping
{
    public  class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(x => x.UserId);

            Property(x => x.Name)
                .IsRequired();

            Property(x => x.UserIdentityId)
                .IsRequired(); 

            
        }
    }
}
