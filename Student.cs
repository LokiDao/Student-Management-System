using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    internal class Student : Profile
    {
        protected string? batch;
        
        public override bool setId(string id)
        {
            bool rs = false;
            string regex = @"([GL][GC]?){1}([0-9]{1,}$)";

            if (Util.Match(id, regex))
            {
                this.id = id;
                rs = true;
            }
            return rs;
        }

        public string getBatch() => this.batch;

        public void setBatch(string batch)
        {
            this.batch = batch;
        }
    }
}
