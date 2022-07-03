using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    internal class Students : ProfileInterface
    {
        public List<Student> students;

        public Students()
        {
            this.students = new List<Student>();
        }

        public Students(List<Student> stds)
        {
            this.students = stds;
        }

        public void add()
        {
            Console.Clear();
            Student std = new Student();

            Console.WriteLine("Student ID:");
            bool rs = false;
            string id = null;
            do
            {
                id = Console.ReadLine();
                if (this.get(id) != null)
                {
                    Console.WriteLine("Student ID " + id + " is already existed." +
                        " Please try again or press \"C\" key to cancel.");
                }
                else
                {
                    if (id != null && !id.Equals("") 
                        && !id.Equals("C") && !id.Equals("c"))
                    {
                        rs = std.setId(id);
                        if (rs == false) 
                            Console.WriteLine("Incorrect ID. Please try again or press \"C\" key to cancel.");
                    }
                }
            } while (id != null && !id.Equals("") 
            && !id.Equals("C") && !id.Equals("c") 
            && rs == false);

            if (id != null && !id.Equals("") 
                && (id.Equals("C") || id.Equals("c")))
            {
                Console.WriteLine("Adding new process has been cancelled.");
                return;
            }

            Console.WriteLine("Student Name:");
            std.setName(Console.ReadLine());

            Console.WriteLine("Date of Birth:");
            rs = false;
            string dob = null;
            do
            {
                dob = Console.ReadLine();
                if (dob != null && !dob.Equals("") 
                    && !dob.Equals("C") && !dob.Equals("c"))
                {
                    rs = std.setDoB(dob);
                    if (rs == false)
                        Console.WriteLine("Incorrect Date of Birth. Please try again or press \"C\" key to cancel.");
                }
            } while (dob != null && !dob.Equals("") 
            && !dob.Equals("C") && !dob.Equals("c") 
            && rs == false);

            if (dob != null && !dob.Equals("") 
                && (dob.Equals("C") || dob.Equals("c")))
            {
                Console.WriteLine("Adding new process has been cancelled.");
                return;
            }

            Console.WriteLine("Email:");
            rs = false;
            string email = null;
            do
            {
                email = Console.ReadLine();
                if (email != null && !email.Equals("") 
                    && !email.Equals("C") && !email.Equals("c"))
                {
                    rs = std.setEmail(email);
                    if (rs == false)
                        Console.WriteLine("Incorrect Email. Please try again.");
                }  
            } while (email != null && !email.Equals("") 
            && !email.Equals("C") && !email.Equals("c") 
            && rs == false);

            if (email != null && !email.Equals("") 
                && (email.Equals("C") || email.Equals("c")))
            {
                Console.WriteLine("Adding new process has been cancelled.");
                return;
            }

            Console.WriteLine("Address:");
            std.setAddress(Console.ReadLine());

            Console.WriteLine("Batch/Class:");
            std.setBatch(Console.ReadLine());

            this.students.Add(std);
            Console.WriteLine("Student " + id + " has been added successfully.");
            this.display(this.get(id), null);
        }

        public Profile get(string id)
        {
            if (id == null || id.Equals("") || id.Equals(" ") 
                || this.students == null || this.students.Count <= 0) 
                return null;

            foreach (Student std in this.students)
            {
                if (std != null && std.getId() != null && std.getId().Equals(id))
                {
                    return std;
                }
            }

            return null;
        }

        public void update()
        {
            Console.Clear();

            Console.WriteLine("Student ID need to be updated:");
            Student std = null;
            string id = null;
            do {
                id = Console.ReadLine();

                if (id != null && !id.Equals("") 
                    && !id.Equals("C") && !id.Equals("c"))
                {
                    std = (Student)this.get(id);
                    if (std == null || std.getId() == null || std.getId().Equals(""))
                        Console.WriteLine("Student ID " + id + " does not exist." +
                            " Please try again or press \"C\" key to cancel.");
                }
            } while (id != null && !id.Equals("") 
            && !id.Equals("C") && !id.Equals("c") 
            && std == null);

            if (id != null && !id.Equals("") 
                && (id.Equals("C") || id.Equals("c")))
            {
                Console.WriteLine("Updating process has been cancelled.");
                return;
            }

            Console.WriteLine("Current Student Name: " + std.getName());
            Console.WriteLine("Please input a new one or press \"Enter\" to skeep this step.");
            string name = Console.ReadLine();
            if (name != null && !name.Equals("") 
                && !name.Equals("K") && !name.Equals("k")) 
                std.setName(name);

            Console.WriteLine("Current Date of Birth: " + std.getDoB());
            Console.WriteLine("Please input a new one or press \"Enter\" to skeep this step.");
            bool rs = false;
            string dob = null;
            do
            {
                dob = Console.ReadLine();
                if (dob != null && !dob.Equals("") 
                    && !dob.Equals("C") && !dob.Equals("c"))
                {
                    rs = std.setDoB(dob);
                    if (rs == false)
                        Console.WriteLine("Incorrect Date of Birth." +
                            " Please try again or press \"Enter\" to skeep this step or press \"C\" key to cancel.");
                }
            } while (dob != null && !dob.Equals("") 
            && !dob.Equals("C") && !dob.Equals("c")
            && rs == false);

            if (dob != null && !dob.Equals("") 
                && (dob.Equals("C") || dob.Equals("c")))
            {
                Console.WriteLine("Updating process has been canceled.");
                return;
            }

            Console.WriteLine("Current Email: " + std.getEmail());
            Console.WriteLine("Please input a new one or press \"Enter\" to skeep this step.");
            rs = false;
            string email = null;
            do
            {
                email = Console.ReadLine();
                if (email != null && !email.Equals("") 
                    && !email.Equals("C") && !email.Equals("c"))
                {
                    rs = std.setEmail(email);
                    if (rs == false)
                        Console.WriteLine("Incorrect Email." +
                            " Please try again or press \"Enter\" to skeep this step or press \"C\" key to cancel.");
                }
                
            } while (email != null && !email.Equals("") 
            && !email.Equals("C") && !email.Equals("c") 
            && rs == false);

            if (email != null && !email.Equals("") 
               && (email.Equals("C") || email.Equals("c")))
            {
                Console.WriteLine("Updating process has been canceled.");
                return;
            }

            Console.WriteLine("Current Address: " + std.getAddress());
            Console.WriteLine("Please input a new one or press \"Enter\" to skeep this step.");
            string address = Console.ReadLine();
            if (address != null && !address.Equals(""))
                std.setAddress(address);

            Console.WriteLine("Current Batch/Class: " + std.getBatch());
            Console.WriteLine("Please input a new one or press \"Enter\" to skeep this step.");
            string batch = Console.ReadLine();
            if (batch != null && !batch.Equals(""))
                std.setBatch(batch);

            Console.WriteLine("Student " + id + " has been updated successfully.");
            this.display(this.get(id), null);
        }

        public void delete()
        {
            Console.Clear();
            Console.WriteLine("Student ID need to be deleted:");
            Student std = null;
            string id = null;
            do
            {
                id = Console.ReadLine();

                if (id != null && !id.Equals("")
                    && !id.Equals("C") && !id.Equals("c"))
                {
                    std = (Student)this.get(id);
                    if (std == null || std.getId() == null || std.getId().Equals(""))
                        Console.WriteLine("Student ID " + id + " does not exist." +
                            " Please try again or press \"C\" key to cancel.");
                }      
            } while (id != null && !id.Equals("") 
            && !id.Equals("C") && !id.Equals("c") 
            && std == null);

            if (id != null && !id.Equals("")
                && (id.Equals("C") || id.Equals("c")))
            {
                Console.WriteLine("Deleting process has been canceled.");
                return;
            }

            this.students.Remove(std);
            Console.WriteLine("Student " + id + " has been deleted successfully.");
            this.display(null, this.getMultiple(null));
        }

        public Profile[] getMultiple(string name)
        {
            if (this.students == null) this.students = new List<Student>();
            if (name == null || name.Equals("all") || name.Equals("All") || name.Equals("ALL"))
            {
                return this.students.ToArray();
            }
            else
            {
                List<Student> stds = new List<Student>();

                foreach (Student std in this.students)
                {
                    if (std != null && std.getName().Contains(name))
                    {
                        stds.Add(std);
                    }
                }

                return stds.ToArray();
            }
        }

        public void display(Profile profile, Profile[] profiles)
        {
            Console.Clear();
            Console.WriteLine("| Student ID | Student Name | Date of Birth | Email | Address | Batch/Class |");
            if (profile == null && (profiles == null || profiles.Length <= 0)) Console.WriteLine("No data found.");
            else if (profile != null)
            {
                Student st = (Student) profile;
                Console.WriteLine("| " + st.getId() + " | "
                        + st.getName() + " | "
                        + st.getDoB() + " | "
                        + st.getEmail() + " | "
                        + st.getAddress() + " | "
                        + st.getBatch() + " |");
            }
            else if (profiles != null && profiles.Length > 0)
            {
                foreach (Student_Management_System.Student st in profiles)
                {
                    Console.WriteLine("| " + st.getId() + " | "
                        + st.getName() + " | "
                        + st.getDoB() + " | "
                        + st.getEmail() + " | "
                        + st.getAddress() + " | "
                        + st.getBatch() + " |");
                }
            }
        }
    }
}
