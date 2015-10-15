using PersonalBox.Domain.Entities;
using PersonalBox.Domain.Utils;

namespace PersonalBox.Application.Appications.Abstracts
{
    public interface IUserApp
    {

        ReturnOperation AdicionaUsuario(User user);

    }
}
