using System.Transactions;
using SchoolSystem;

internal class Program
{
    private static void Main(string[] args)
    {
        string underline = "=====================================================";
        Console.WriteLine(underline);
        Console.WriteLine(underline);
        Console.WriteLine("\n Welcome to My School Management App \n");
        Console.WriteLine(underline);
        Console.WriteLine(underline);

        while (true) 
        {

            Console.WriteLine("\n Enter 1 to Perform Actions For Parent  \n Enter 2 to Perform Actions For Student \n ");

            int PorS = Verification.GetProperIntFromUser();

            if (PorS == 1)
            {
                
                while (true)
                { 

                    Console.WriteLine(underline);
                    Console.WriteLine("Enter 1 To Show all rec");
                    Console.WriteLine("Enter 2 To Add parent");
                    Console.WriteLine("Enter 3 To edit rec");
                    Console.WriteLine("Enter 4 To delete rec");
                    Console.WriteLine("Enter 5 To exit");
                    Console.WriteLine(underline);
                    int a = Verification.GetProperIntFromUser();
                    if (a == 5)
                    {
                        Console.WriteLine(underline);
                        break;
                    }
                    else
                    {
                        switch (a)
                        {
                            case 1:
                                Database.ShowAllParents();
                                break;
                            case 2:
                                Database.AddParent();
                                break;
                            case 3:
                                Console.Write("Enter Parent Id: ");
                                int stdId = Verification.GetProperIntFromUser();
                                Database.EditParent(stdId);
                                break;
                            case 4:
                                Console.Write("Enter Parent Id : ");
                                int stdIdForDelete = Verification.GetProperIntFromUser();
                                Database.DeleteParent(stdIdForDelete);
                                break;
                       

                            default:
                                Console.WriteLine("no Actoin Set For" + a);
                                break;
                        }
                    }

                }

            }
            else if (PorS == 2)
            {
                while (true)
                {
                    Console.WriteLine(underline);
                    Console.WriteLine("Enter 1 To Show all rec");
                    Console.WriteLine("Enter 2 To Add Student");
                    Console.WriteLine("Enter 3 To edit rec");
                    Console.WriteLine("Enter 4 To delete rec");
                    Console.WriteLine("Enter 5 To exit");
                    int a = Verification.GetProperIntFromUser();
                    if (a == 5)
                    {
                        Console.WriteLine(underline);
                        break;
                    }
                    else
                    {
                        switch (a)
                        {
                            case 1:
                                Database.ShowAllStudents();
                                break;
                            case 2:
                                Database.AddStudent();
                                break;
                            case 3:
                                Console.Write("Enter Student Id : ");
                                int stdId = Verification.GetProperIntFromUser();
                                Database.EditStudent(stdId);
                                break;
                            case 4:
                                Console.Write("Enter Student Id : ");
                                int stdIdForDelete = Verification.GetProperIntFromUser();
                                Database.DeleteStudennt(stdIdForDelete);
                                break;
                       

                            default:
                                Console.WriteLine("no Actoin Set For" + a);
                                break;
                        }
                    }
                    

                }

            }
             
            else
            {
                Console.WriteLine("Please Select From Given Options");
            }






        }













    }
}