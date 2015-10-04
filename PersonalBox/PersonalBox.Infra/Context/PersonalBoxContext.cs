using PersonalBox.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBox.Infra.Context
{
   public class PersonalBoxContext : DbContext
    {
        public DbSet<Client> Clientes { get; set; }
        public PersonalBoxContext():base("PersonBoxDB")
        {
        }


    }
}
