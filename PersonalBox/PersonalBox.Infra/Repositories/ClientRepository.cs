using PersonalBox.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalBox.Domain.Entities;

namespace PersonalBox.Infra.Repositories
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
       
    }
}
