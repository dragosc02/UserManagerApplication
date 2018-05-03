using Repository;
using Repository.Contracts;
using Services;
using Services.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagerApplication
{
    /// <summary>
    /// Static class used to provide instances of different instances.
    /// </summary>
    public static class InstanceProvider
    {
        /// <summary>
        /// Provides a User Service instance
        /// </summary>
        /// <returns>An instance of <see cref="IUserService"/>.</returns>
        public static IUserService GetUserService()
        {
            var userRepository = GetUserRepository();
            var userService = new UserService(userRepository);

            return userService;
        }

        /// <summary>
        /// Provides a User Repository instance
        /// </summary>
        /// <returns>An instance of <see cref="IUserRepository"/>.</returns>
        public static IUserRepository GetUserRepository()
        {
            IUserRepository userRepository = new UserRepository();

            return userRepository;
        }
    }
}
