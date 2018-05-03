using DataContracts;
using Repository.Contracts;
using Services.ServiceContracts;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary>
        /// Gets the list of available users.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="User"/>.</returns>
        public IEnumerable<User> GetUsers()
        {
            var users = _userRepository.GetUsers();

            return users;
        }

        /// <summary>
        /// Gets the total number of users.
        /// </summary>
        /// <returns>The total number of users.</returns>
        public int GetUserCount()
        {
            var userList = GetUserList();

            return userList.Count;            
        }

        private List<User> GetUserList()
        {
            var userList = GetUsers();

            return userList.ToList();
        }
    }
}
