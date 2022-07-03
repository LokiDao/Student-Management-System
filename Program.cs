// See https://aka.ms/new-console-template for more information
String opt = null;
Student_Management_System.Students students = new Student_Management_System.Students();
Student_Management_System.Lecturers lecturers = new Student_Management_System.Lecturers();

do
{
    Console.Clear();
    Console.WriteLine("=======================");
    Console.WriteLine(" ");
    Console.WriteLine("1.   Manage Students");
    Console.WriteLine("2.   Manage Lecturers");
    Console.WriteLine("3.   Exit");
    Console.WriteLine(" ");
    Console.WriteLine("=======================");
    Console.WriteLine(" ");
    Console.WriteLine("Please choose:");

    opt = Console.ReadLine();

    switch (opt)
    {
        case "1":
            String main1 = null;
            do
            {
                Console.Clear();
                Console.WriteLine("=======================");
                Console.WriteLine(" ");
                Console.WriteLine("1.	Add new student");
                Console.WriteLine("2.	View all students");
                Console.WriteLine("3.	Search students");
                Console.WriteLine("4.	Delete students");
                Console.WriteLine("5.	Update student");
                Console.WriteLine("6.	Back to main menu");
                Console.WriteLine(" ");
                Console.WriteLine("=======================");
                Console.WriteLine(" ");
                Console.WriteLine("Please choose:");
                main1 = Console.ReadLine();

                switch (main1)
                {
                    case "1":
                        students.add();
                        Console.WriteLine("Press any key to back to Student Management menu.");
                        Console.ReadLine();
                        break;
                    case "2":
                        students.display(null, students.getMultiple(null));
                        Console.WriteLine("Press any key to back to Student Management menu.");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Input Student's name for searching:");
                        string name = Console.ReadLine();

                        students.display(null, students.getMultiple(name));
                        Console.WriteLine("Press any key to back to Student Management menu.");
                        Console.ReadLine();
                        break;
                    case "4":
                        students.delete();
                        Console.WriteLine("Press any key to back to Student Management menu.");
                        Console.ReadLine();
                        break;
                    case "5":
                        students.update();
                        Console.WriteLine("Press any key to back to Student Management menu.");
                        Console.ReadLine();
                        break;
                    case "6":
                        break;
                    default:
                        Console.WriteLine("Incorrect option. Press any key to try again.");
                        Console.ReadLine();
                        break;
                }
            } while (main1 != null && !main1.Equals("6"));
            break;
        case "2":
            String main2 = null;
            do
            {
                Console.Clear();
                Console.WriteLine("=======================");
                Console.WriteLine(" ");
                Console.WriteLine("1.	Add new lecturer");
                Console.WriteLine("2.	View all lecturers");
                Console.WriteLine("3.	Search lecturers");
                Console.WriteLine("4.	Delete lecturers");
                Console.WriteLine("5.	Update lecturer");
                Console.WriteLine("6.	Back to main menu");
                Console.WriteLine(" ");
                Console.WriteLine("=======================");
                Console.WriteLine(" ");
                Console.WriteLine("Please choose:");
                main2 = Console.ReadLine();

                switch (main2)
                {
                    case "1":
                        lecturers.add();
                        Console.WriteLine("Press any key to back to Lecturer Management menu.");
                        Console.ReadLine();
                        break;
                    case "2":
                        lecturers.display(null, lecturers.getMultiple(null));
                        Console.WriteLine("Press any key to back to Lecturer Management menu.");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Input Student's name for searching:");
                        string name = Console.ReadLine();

                        lecturers.display(null, lecturers.getMultiple(name));
                        Console.WriteLine("Press any key to back to Lecturer Management menu.");
                        Console.ReadLine();
                        break;
                    case "4":
                        lecturers.delete();
                        Console.WriteLine("Press any key to back to Lecturer Management menu.");
                        Console.ReadLine();
                        break;
                    case "5":
                        lecturers.update();
                        Console.WriteLine("Press any key to back to Lecturer Management menu.");
                        Console.ReadLine();
                        break;
                    case "6":
                        break;
                    default:
                        Console.WriteLine("Incorrect option. Press any key to try again.");
                        Console.ReadLine();
                        break;
                }
            } while (main2 != null && !main2.Equals("6"));
            break;
        case "3":
            Console.WriteLine("Program has been stopped.");
            break;
        default:
            Console.WriteLine("Incorrect option. Press any key to try again.");
            Console.ReadLine();
            break;
    }
} while (opt != null && !opt.Equals("3"));