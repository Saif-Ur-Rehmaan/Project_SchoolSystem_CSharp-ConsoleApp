using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    internal class Database
    {
        public static List<Student> Students = new List<Student>();
        public static List<Parent> Parents = new List<Parent>();

        //adding dummy data
        static Database()
        {
            //dummydata
            Students.Add(new Student(100,"Saif", 17, "intermediate", "php", 3, 1));
            Students.Add(new Student(101,"hassan", 14, "eighth", "html", 0, 1));
            Students.Add(new Student(102, "subhan", 17, "one", "-", 0, 1));
            Parents.Add(new Parent(100, "A"));
            Parents.Add(new Parent(101, "B"));
            Parents.Add(new Parent(102, "C"));
            Parents.Add(new Parent(103, "D"));


        }

        /*---------------------------------Student-----------------------*/

        public static void AddStudent()
        {
            int   id=0,age=0, semester=0, parentid = 0;
            string name="", @class="", subject="";
            string[] CN = { "id","name", "age", "class", "subject", "semester", "Parentid" };

            foreach (var c in CN)
            {
                Console.Write($"Enter {c} : ");
                switch (c)
                {
                    case "id":
                        while (true)
                        {
                            try {
                                int inp = Verification.GetProperIntFromUser();
                                if (!Verification.IsExist_Student(inp))
                                {
                                   id = inp;
                                }
                                else
                                {
                                    throw new Exception("Id Already Exist");
                                }
                                break;                            
                            } catch (Exception e) { Console.WriteLine(e.Message); }

                        }
                        break;
                    case "name":
                        name = Verification.GetProperStringFromUser();
                        break;

                    case "age":
                        age = Verification.GetProperIntFromUser();
                        break;
                    case "class":
                        @class =Console.ReadLine();
                        break;
                    case "subject":
                        subject = Verification.GetProperStringFromUser();
                        break;
                    case "semester":
                        semester = Verification.GetProperIntFromUser();
                        break;
                    case "Parentid":
                        parentid = Verification.GetProperIntFromUser();
                        break;
                }


            }
            Database.Students.Add(new Student(id,name, age, @class, subject, semester, parentid));

            Console.WriteLine("=================================================");
            Console.WriteLine("Added Successfullly");
            Console.WriteLine("=================================================");


        }
        public static void ShowAllStudents()
        {
            Console.WriteLine("=========================================================================================");
            Console.WriteLine(" ID  ||  Name  ||  Age  ||  Class  ||  Subject  ||  Semester  ||  Parentid  \n" ); 
            foreach (Student s in Students)
            { 
                Console.WriteLine($"{s.id}  ||  {s.name}  ||  {s.age}  ||  {s.@class}  ||  {s.subject}  ||  {s.semester}  ||  {s.parentid}");
            }
            Console.WriteLine("=========================================================================================");
        }
        public static void EditStudent(int StudentId)
        {
                if (Verification.IsExist_Student(StudentId))
                {
                    while (true)
                    {
                    int id = 0, age = 0, semester = 0, parentid = 0;
                    string name = "", @class = "", subject = "";
                    //set variables
                    string[] CN = {  "name", "age", "class", "subject", "semester", "Parentid" };

                    foreach (var c in CN)
                    {
                        Console.Write($"Enter {c} : ");
                        switch (c)
                        {
                            case "name":
                                name = Verification.GetProperStringFromUser();
                                break;

                            case "age":
                                age = Verification.GetProperIntFromUser();
                                break;
                            case "class":
                                @class = Console.ReadLine();
                                break;
                            case "subject":
                                subject = Verification.GetProperStringFromUser();
                                break;
                            case "semester":
                                semester = Verification.GetProperIntFromUser();
                                break;
                            case "Parentid":
                                parentid = Verification.GetProperIntFromUser();
                                break;
                        }
                    }

                    //update rec
                    foreach (Student s in Students)
                    {
                        if (s.id==StudentId)
                        {
                            s.name = name;
                            s.subject = subject;
                            s.age = age;
                            s.@class = @class;
                            s.semester = semester;
                            s.parentid = parentid;
                        }
                    }
                    Console.WriteLine("Edit Successfully");
                    break;
                    }

                }
                else
                {
                    Console.WriteLine("\nREGISTER Yourself First\n");
                }
        }

        public static void DeleteStudennt(int StudentId)
        {
            if (Verification.IsExist_Student(StudentId))
            {
                foreach (Student student in Students)
                {
                    if (student.id==StudentId)
                    {
                        Students.Remove(student);
                        Console.WriteLine("Student Deleted!");
                    }

                }
            }

        }




        /*---------------------------------Parent-----------------------*/
        public static void AddParent()
        {
            string name = "";
            int id = 0;
            while (true)
            {
                try
                {
                    Console.Write("Enter Id : ");
                    int ina = Verification.GetProperIntFromUser();
                    if (!Verification.IsExist_Parent(ina))
                    {
                        id = ina;
                        break;
                    }
                    else
                    {
                        throw new Exception("Parent With Same Id Exists");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("enter Name : ");
            name = Verification.GetProperStringFromUser();
            Parents.Add(new Parent(id,name));
            Console.WriteLine("Added Successfully");

        }
        public static void ShowAllParents()
        {
                Console.WriteLine("ID  ||  Name  ||  NoOfAddmission");
            foreach (Parent s in Parents)
            {
                Console.WriteLine($"{s.Id}  || | {s.name}  || | {s.NoOfAddmission}");
                Console.WriteLine("================================================================");
            }
        }
        public static void EditParent(int ParentId)
        {
            if (Verification.IsExist_Parent(ParentId))
            {
                while (true)
                {
                    string name = "";
                    int id = 0;
                    //set variables 
                    Console.WriteLine("enter Name : ");
                    name = Verification.GetProperStringFromUser(); 
                    //update rec
                    foreach (Parent p in Parents)
                    {
                        if (p.Id == ParentId)
                        {
                            p.name = name; 
                        }
                    }
                    Console.WriteLine("Edit Successfully");
                    break;
                }

            }
            else
            {
                Console.WriteLine("\nREGISTER Yourself First\n");
            }
        }

        public static void DeleteParent(int ParentId)
        {
            if (Verification.IsExist_Parent(ParentId))
            {
                foreach (Parent p in Parents)
                {
                    if (p.Id == ParentId)
                    {
                        Parents.Remove(p);
                        Console.WriteLine("Parent Deleted!");
                    }

                }
            }

        }


    }
}
