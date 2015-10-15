using System;
using PersonalBox.Domain.Entities;
using PersonalBox.Domain.Interfaces.Clients;
using PersonalBox.Domain.Utils;
using PersonalBox.Domain.Interfaces.Repositories;

namespace PersonalBox.Domain.Clients.Clients
{
    public class UserClient : IUserClient
    {
        private readonly IUserRepository _userRepository;

        public UserClient(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public ReturnOperation AdicionaUsuario(User user)
        {
            var returnOperation = new ReturnOperation();
            _userRepository.Add(user);

            return returnOperation;
        }
    }
}
