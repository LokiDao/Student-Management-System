using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    internal class Lecturer : Profile
    {
        protected string dept;

        public override bool setId(string id)
        {
            bool rs = false;
            string regex = @"(^[0-9]{8,8}$)";

            if (Util.Match(id, regex))
            {
                this.id = id;
                rs = true;
            }
            return rs;
        }

        public string getDept() => this.dept;

        public void setDept(string dept)
        {
            this.dept = dept;
        }
    }
}
