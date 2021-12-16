using System;
using System.Collections.Generic;

namespace SimpleECommerce4CII
{
    class Seller
    {
        public string Name { get; set; }
        public string IBAN { get; set; }
        public List<User> Admins { get; }
        public Seller(string name, string iBAN, List<User> admins)
        {
            Name = name;
            IBAN = iBAN;
            if (admins.Count > 5)
            {
                throw new ArgumentException("List must be less than 5");
            }
            this.Admins = admins;
        }
        public Seller(string name, string iBAN, User admin)
        {
            Name = name;
            IBAN = iBAN;

            Admins = new List<User>(5);

            Admins.Add(admin);
        }
        public bool AddAdmin(User user)
        {
            if (Admins.Count == 5)
            {
                return false;
            }

            Admins.Add(user);

            return true;
        }
    }
}
