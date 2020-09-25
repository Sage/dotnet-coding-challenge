using System;
using System.Collections.Generic;

namespace sage.challenge.data
{
    public class Account
    {
        /// <summary>
        /// ID of the Account.
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
        /// <summary>
        /// Name of the company.
        /// </summary>
        public string CompanyName { get; set; }
        public string Website { get; set; } 
        /// <summary>
        /// List of Account Users.
        /// </summary>
        public List<User> Users { get; set; } = new List<User>();
    }
}