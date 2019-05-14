using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCheckin
{
    class Visitor
    {
        string eventid;
        string firstname, lastname, email, password, checkedin, valid;
        double balance;

        public Visitor(string eventid, string firstname, string lastname, string email, string password, string checkedin, string valid, double balance)
        {
            this.eventid = eventid;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.password = password;
            this.checkedin = checkedin;
            this.valid = valid;
            this.balance = balance;
        }

    }
}
