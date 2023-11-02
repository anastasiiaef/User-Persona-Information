using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web2Blank.Models
{
    public class User
    {
        public string FirstName = string.Empty;
        public string LastName = string.Empty;
        public string UserID = string.Empty;
        public string Password = string.Empty;

        public Address HomeAddress = null;
        public Address Home2Address = null;
        public Address WorkAddress = null;

        public PhoneNumber CellPhone = null;
        public PhoneNumber HomePhone = null;
        public PhoneNumber WorkPhone = null;
        public PhoneNumber EmergencyPhone = null;

    }
}