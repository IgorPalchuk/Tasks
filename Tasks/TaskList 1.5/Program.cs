using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TaskList_1._5
{
    internal class Program
    {
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            

            while (true)
            { 
            Console.WriteLine("Choose option :\n" 
                + "1.Add student\n"
                + "2.Delete student\n"
                + "3.Delete all students\n"
                + "4.Find a student by something\n");
            string choose = Console.ReadLine();

                switch (choose)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        DeleteStudent();
                        break;
                    case "3":
                        DeleteAllStudents();
                        break;
                    case "4":
                        FindAStudentBy();
                        break;
                    default:
                        Console.WriteLine("Wrong option");
                        break;
                }
                
                
            }
            
        }
        static void AddStudent()
        {
            Console.WriteLine("Enter name of student: ");
            string name  = Console.ReadLine();

            Console.WriteLine("Enter surname of student: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Enter age of student: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter specialty of student: ");
            string specialty = Console.ReadLine();

            students.Add(new Student { Name = name, Surname = surname, Age = age, Specialty = specialty });
        }

        static void DeleteStudent()
        {
            Console.WriteLine("Write a surname of student: ");
            string surname = Console.ReadLine();
           
            Student studentToDelete = students.Where(student => student.Name == surname).FirstOrDefault();
            students.Remove(studentToDelete);
        }
        static void DeleteAllStudents()
        {
            students.Clear();
        }
        static void FindAStudentBy()
        {
            Console.WriteLine("Select option:\n" 
                + "1.Find a student by age\n" 
                + "2.Find a student by name");

            int choose = int.Parse(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    FindAStudentByAge();
                    break;
                case 2:
                    FindAStudentByName();
                    break;
                default:
                    Console.WriteLine("Wrong option");
                    break;
            }       
        }
        static void FindAStudentByAge()
        {
            List<Student> age = new List<Student>();
            Console.WriteLine("Write age to find:");
            int ageToFind = int.Parse(Console.ReadLine());
            age  = students.Where(student => student.Age == ageToFind).ToList();
            foreach (Student student in age)
            {
                Console.WriteLine(student);
            }
            

        }
        static void FindAStudentByName()
        {
            List<Student> name = new List<Student>();
            Console.WriteLine("Write name to find:");
            string nameToFind = Console.ReadLine();
                   
            foreach (var student in students)
            {
                if (student.Name == nameToFind)
                {
                    name.Add(student);
                }
            }
            foreach (var student in name)
            {
                Console.WriteLine(student);
            }
        }
    }
}
