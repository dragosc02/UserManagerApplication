using DataContracts;
using Repository.Contracts;
using System;
using System.Collections.Generic;

namespace Repository
{
    /// <summary>
    /// Implements <see cref="IUserRepository"/> contract.
    /// </summary>
    public class UserRepository : IUserRepository
    {
        /// <summary>
        /// Gets the list of available users.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="User"/>.</returns>
        public IEnumerable<User> GetUsers()
        {
            var users = GetMockedUsers();

            return users;
        }

        private IEnumerable<User> GetMockedUsers()
        {
            return new List<User>()
            {
                new User
                {
                    Id = 1,
                    Age = 15,
                    BirthDay = new DateTime(2003,12,25),
                    Education = Studies.Basic,
                    FirstName = "Smith",
                    SecondName = "Adam",
                    Nationality = "US"
                },
                new User
                {
                    Id = 2,
                    Age = 18,
                    BirthDay = new DateTime(2000,2,15),
                    Education = Studies.HighSchool,
                    FirstName = "Platini",
                    SecondName = "Michel",
                    Nationality = "FR"
                },
                new User
                {
                    Id = 3,
                    Age = 20,
                    BirthDay = new DateTime(1998,7,14),
                    Education = Studies.Student,
                    FirstName = "Popescu",
                    SecondName = "Ion",
                    Nationality = "RO"
                },
                new User
                {
                    Id = 4,
                    Age = 44,
                    BirthDay = new DateTime(1974,5,10),
                    Education = Studies.UniversityDegree,
                    FirstName = "Vasilescu",
                    SecondName = "Victor",
                    Nationality = "RO"
                },
                new User
                {
                    Id = 5,
                    Age = 33,
                    BirthDay = new DateTime(1985,6,1),
                    Education = Studies.UniversityDegree,
                    FirstName = "Stan",
                    SecondName = "Andrei",
                    Nationality = "RO"
                },
                new User
                {
                    Id = 6,
                    Age = 33,
                    BirthDay = new DateTime(1985,6,5),
                    Education = Studies.PhdDegree,
                    FirstName = "Werner",
                    SecondName = "Angela",
                    Nationality = "DE"
                },
                new User
                {
                    Id = 7,
                    Age = 73,
                    BirthDay = new DateTime(1945,6,5),
                    Education = Studies.MasterDegree,
                    FirstName = "Wagner",
                    SecondName = "Maria",
                    Nationality = "DE"
                },
                new User
                {
                    Id = 8,
                    Age = 83,
                    BirthDay = new DateTime(1935,10,31),
                    Education = Studies.Basic,
                    FirstName = "Ionescu",
                    SecondName = "Oana",
                    Nationality = "RO"
                },
                new User
                {
                    Id = 9,
                    Age = 13,
                    BirthDay = new DateTime(2005,8,31),
                    Education = Studies.Basic,
                    FirstName = "Oprea",
                    SecondName = "Malina",
                    Nationality = "RO"
                },
                new User
                {
                    Id = 10,
                    Age = 23,
                    BirthDay = new DateTime(2005,8,31),
                    Education = Studies.Student,
                    FirstName = "Manea",
                    SecondName = "Victor",
                    Nationality = "RO"
                }
            };
        }
    }
}
