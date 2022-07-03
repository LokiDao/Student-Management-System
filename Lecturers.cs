using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    internal class Lecturers : ProfileInterface
    {
        public List<Lecturer> lecturers;

        public Lecturers()
        {
            this.lecturers = new List<Lecturer>();
        }

        public Lecturers(List<Lecturer> lcts)
        {
            this.lecturers = lcts;
        }

        public void add()
        {
            Console.Clear();
            Lecturer lct = new Lecturer();

            Console.WriteLine("Lecturer ID:");
            bool rs = false;
            string id = null;
            do
            {
                id = Console.ReadLine();
                if (this.get(id) != null)
                {
                    Console.WriteLine("Lecturer ID " + id + " is already existed." +
                        " Please try again or press \"C\" key to cancel.");
                }
                else
                {
                    if (id != null && !id.Equals("")
                        && !id.Equals("C") && !id.Equals("c"))
                    {
                        rs = lct.setId(id);
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

            Console.WriteLine("Lecturer Name:");
            lct.setName(Console.ReadLine());

            Console.WriteLine("Date of Birth:");
            rs = false;
            string dob = null;
            do
            {
                dob = Console.ReadLine();
                if (dob != null && !dob.Equals("")
                    && !dob.Equals("C") && !dob.Equals("c"))
                {
                    rs = lct.setDoB(dob);
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
                    rs = lct.setEmail(email);
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
            lct.setAddress(Console.ReadLine());

            Console.WriteLine("Department:");
            lct.setDept(Console.ReadLine());

            this.lecturers.Add(lct);
            Console.WriteLine("Lecturer " + id + " has been added successfully.");
            this.display(this.get(id), null);
        }

        public Profile get(string id)
        {
            if (id == null || id.Equals("") || id.Equals(" ")
                || this.lecturers == null || this.lecturers.Count <= 0)
                return null;

            foreach (Lecturer lct in this.lecturers)
            {
                if (lct != null && lct.getId() != null && lct.getId().Equals(id))
                {
                    return lct;
                }
            }

            return null;
        }

        public void update()
        {
            Console.Clear();

            Console.WriteLine("Lecturer ID need to be updated:");
            Lecturer lct = null;
            string id = null;
            do
            {
                id = Console.ReadLine();

                if (id != null && !id.Equals("")
                    && !id.Equals("C") && !id.Equals("c"))
                {
                    lct = (Lecturer) this.get(id);
                    if (lct == null || lct.getId() == null || lct.getId().Equals(""))
                        Console.WriteLine("Lecturer ID " + id + " does not exist." +
                            " Please try again or press \"C\" key to cancel.");
                }
            } while (id != null && !id.Equals("")
            && !id.Equals("C") && !id.Equals("c")
            && lct == null);

            if (id != null && !id.Equals("")
                && (id.Equals("C") || id.Equals("c")))
            {
                Console.WriteLine("Updating process has been cancelled.");
                return;
            }

            Console.WriteLine("Current Lecturer Name: " + lct.getName());
            Console.WriteLine("Please input a new one or press \"Enter\" to skeep this step.");
            string name = Console.ReadLine();
            if (name != null && !name.Equals(""))
                lct.setName(name);

            Console.WriteLine("Current Date of Birth: " + lct.getDoB());
            Console.WriteLine("Please input a new one or press \"Enter\" to skeep this step.");
            bool rs = false;
            string dob = null;
            do
            {
                dob = Console.ReadLine();
                if (dob != null && !dob.Equals("")
                    && !dob.Equals("C") && !dob.Equals("c"))
                {
                    rs = lct.setDoB(dob);
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

            Console.WriteLine("Current Email: " + lct.getEmail());
            Console.WriteLine("Please input a new one or press \"Enter\" to skeep this step.");
            rs = false;
            string email = null;
            do
            {
                email = Console.ReadLine();
                if (email != null && !email.Equals("")
                    && !email.Equals("C") && !email.Equals("c"))
                {
                    rs = lct.setEmail(email);
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

            Console.WriteLine("Current Address: " + lct.getAddress());
            Console.WriteLine("Please input a new one or press \"Enter\" to skeep this step.");
            string address = Console.ReadLine();
            if (address != null && !address.Equals(""))
                lct.setAddress(address);

            Console.WriteLine("Current Department: " + lct.getDept());
            Console.WriteLine("Please input a new one or press \"Enter\" to skeep this step.");
            string dept = Console.ReadLine();
            if (dept != null && !dept.Equals(""))
                lct.setDept(dept);

            Console.WriteLine("Lecturer " + id + " has been updated successfully.");
            this.display(this.get(id), null);
        }

        public void delete()
        {
            Console.Clear();
            Console.WriteLine("Lecturer ID need to be deleted:");
            Lecturer lct = null;
            string id = null;
            do
            {
                id = Console.ReadLine();

                if (id != null && !id.Equals("")
                    && !id.Equals("C") && !id.Equals("c"))
                {
                    lct = (Lecturer) this.get(id);
                    if (lct == null || lct.getId() == null || lct.getId().Equals(""))
                        Console.WriteLine("Lecturer ID " + id + " does not exist." +
                            " Please try again or press \"C\" key to cancel.");
                }
            } while (id != null && !id.Equals("")
            && !id.Equals("C") && !id.Equals("c")
            && lct == null);

            if (id != null && !id.Equals("")
                && (id.Equals("C") || id.Equals("c")))
            {
                Console.WriteLine("Deleting process has been canceled.");
                return;
            }

            this.lecturers.Remove(lct);
            Console.WriteLine("Lecturer " + id + " has been deleted successfully.");
            this.display(null, this.getMultiple(null));
        }

        public Profile[] getMultiple(string name)
        {
            if (this.lecturers == null) this.lecturers = new List<Lecturer>();
            if (name == null || name.Equals("all") || name.Equals("All") || name.Equals("ALL"))
            {
                return this.lecturers.ToArray();
            }
            else
            {
                List<Lecturer> lcts = new List<Lecturer>();

                foreach (Lecturer lct in this.lecturers)
                {
                    if (lct != null && lct.getName().Contains(name))
                    {
                        lcts.Add(lct);
                    }
                }

                return lcts.ToArray();
            }
        }

        public void display(Profile profile, Profile[] profiles)
        {
            Console.Clear();
            Console.WriteLine("| Lecturer ID | Lecturer Name | Date of Birth | Email | Address | Department |");
            if (profile == null && (profiles == null || profiles.Length <= 0)) Console.WriteLine("No data found.");
            else if (profile != null)
            {
                Lecturer lc = (Lecturer) profile;
                Console.WriteLine("| " + lc.getId() + " | "
                        + lc.getName() + " | "
                        + lc.getDoB() + " | "
                        + lc.getEmail() + " | "
                        + lc.getAddress() + " | "
                        + lc.getDept() + " |");
            }
            else if (profiles != null && profiles.Length > 0)
            {
                foreach (Student_Management_System.Lecturer lc in profiles)
                {
                    Console.WriteLine("| " + lc.getId() + " | "
                        + lc.getName() + " | "
                        + lc.getDoB() + " | "
                        + lc.getEmail() + " | "
                        + lc.getAddress() + " | "
                        + lc.getDept() + " |");
                }
            }
        }
    }
}
