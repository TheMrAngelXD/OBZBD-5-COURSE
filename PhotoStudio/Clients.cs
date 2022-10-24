using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoStudio
{
    public class Clients
    {
        public Clients(string numClient, string fullName, string address, string email) 
        {
            if (string.IsNullOrEmpty(numClient)) 
            {
                throw new ArgumentNullException(numClient);
            }
            if (string.IsNullOrEmpty(fullName))
            {
                throw new ArgumentNullException(fullName);
            }
            if (string.IsNullOrEmpty(address))
            {
                throw new ArgumentNullException(address);
            }
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentNullException(email);
            }
            this.NumClient = numClient;
            this.Fullname = fullName;
            this.Address = address;
            this.Email = email;

        }
        public string NumClient { get;}
        public string Fullname { get;}
        public string Address { get;}
        public string Email { get;}
        public ISet<Order> Orders { get;} = new HashSet<Order>();
        public override string ToString()
        {
            return $"{NumClient} {Fullname} {Address} {Email}";
        }

    }
}
