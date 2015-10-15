using PersonalBox.MVC.Services.Abstracts;
using PersonalBox.Domain.Utils;
using PersonalBox.MVC.Models;
using AutoMapper;
using PersonalBox.Domain.Entities;
using PersonalBox.Application.Appications.Abstracts;

namespace PersonalBox.MVC.Services.Clients
{
    public class UserService : IUserService
    {
        private IUserApp _userApp;

        public UserService(IUserApp userApp)
        {
            _userApp = userApp;
        }

        public ReturnOperation SetCreate(RegisterViewModel model)
        {
            var returnOperation = new ReturnOperation();

            var client = Mapper.Map<User>(model);

            returnOperation = _userApp.AdicionaUsuario(client);

            return returnOperation;
        }
    }
}
