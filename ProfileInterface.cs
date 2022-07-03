using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    internal interface ProfileInterface
    {
        public void add();
        public Profile get(string id);
        public void update();
        public void delete();
        public Profile[] getMultiple(string name);
        public void display(Profile profile, Profile[] profiles);
    }
}
