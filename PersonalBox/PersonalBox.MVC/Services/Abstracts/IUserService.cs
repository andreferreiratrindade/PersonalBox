
using PersonalBox.MVC.Models;
using PersonalBox.Domain.Utils;

namespace PersonalBox.MVC.Services.Abstracts
{
    public interface IUserService
    {
        ReturnOperation SetCreate(RegisterViewModel model);
    }
}
