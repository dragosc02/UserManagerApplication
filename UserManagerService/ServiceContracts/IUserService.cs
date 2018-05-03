using DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ServiceContracts
{
    /// <summary>
    /// User Service Contracts.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Gets the list of available users.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="User"/>.</returns>
        IEnumerable<User> GetUsers();

        /// <summary>
        /// Gets the total number of users.
        /// </summary>
        /// <returns>The total number of users.</returns>
        int GetUserCount();
    }
}
