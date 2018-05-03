using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContracts
{
    public class User
    {
        /// <summary>
        /// Gets or sets the id of the user.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the first name of the user.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the second name of the user.
        /// </summary>
        public string SecondName { get; set; }

        /// <summary>
        /// Gets or sets the age of the user.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Gets or sets the birth day of the user.
        /// </summary>
        public DateTime BirthDay { get; set; }

        /// <summary>
        /// Gets or sets the nationality of the user.
        /// </summary>
        public string Nationality { get; set; }

        /// <summary>
        /// Gets or sets the Education degree.
        /// </summary>
        public Studies Education { get; set; }
    }
}
