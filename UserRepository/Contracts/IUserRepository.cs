using DataContracts;
using System.Collections.Generic;

namespace Repository.Contracts
{
    /// <summary>
    /// User Repository contract.
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Gets the list of available users.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="User"/>.</returns>
        IEnumerable<User> GetUsers();
    }
}
