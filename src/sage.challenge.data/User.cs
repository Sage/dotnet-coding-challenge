using System;

namespace sage.challenge.data
{
    public class User
    {
        /// <summary>
        /// ID of the User.
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
        /// <summary>
        /// First name of the User.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Last name of the User.
        /// </summary>
        public string LastName { get; set; }
        public string Email { get; set; }
        /// <summary>
        /// Id of the account.
        /// </summary>
        public Guid AccountId { get; set; }
    }
}