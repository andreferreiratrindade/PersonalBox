using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalBox.Domain.Entities;
using PersonalBox.Domain.Utils;

namespace PersonalBox.Domain.Interfaces.Clients
{
    public interface IUserClient
    {
        ReturnOperation AdicionaUsuario(User user);
    }
}
