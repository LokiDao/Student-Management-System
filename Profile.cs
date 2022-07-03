using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    internal abstract class Profile
    {
        protected string? id;
        protected string? name;
        protected string? doB;
        protected string? email;
        protected string? address;

        public string? GetId()
        {
            return id;
        }

        public string getId() => this.id;

        public abstract bool setId(string id);

        public string getName() => this.name;
        
        public void setName(string name)
        {
            this.name = name;
        }

        public string getDoB() => this.doB;
        
        public bool setDoB(string dob)
        {
            bool rs = false;
            string regex = @"(^[0-9]{1,2})/([0-9]{1,2})/([0-9]{2,4}$)";
            
            if (Util.Match(dob, regex))
            {
                this.doB = dob;
                rs = true;
            }
            return rs;
        }

        public string getEmail() => this.email;
        
        public bool setEmail(string email)
        {
            bool rs = false;
            string regex = @"\A(?:[A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?\.)+[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?)\Z";

            if (Util.Match(email, regex))
            {
                this.email = email;
                rs = true;
            }
            return rs;
        }

        public string getAddress() => this.address;
        
        public void setAddress(string address)
        {
            this.address = address;
        }
    }
}
