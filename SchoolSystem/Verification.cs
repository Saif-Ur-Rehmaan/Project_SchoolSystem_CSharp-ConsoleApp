using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    internal class Verification
    {
        public static int GetProperIntFromUser()
        {
            int res;
            while (true)
            {
                try
                {
                    res = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("ONLY NUMBERS ARE ALLOWED!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("failed Due To" + e.Message);
                }

            }


            return res;
        }
        public static string GetProperStringFromUser()
        {
            string res;
            while (true)
            {
                try
                {
                    res = Console.ReadLine();

                    if (string.IsNullOrEmpty(res))
                    {
                        throw new Exception("Emptyness is not Allowed");
                    }
                    else if (!string.IsNullOrEmpty(res))
                    {
                        char[] SA = res.ToCharArray();
                        foreach (var item in SA)
                        {
                            if (char.IsDigit(item))
                            {
                                throw new Exception("Numbers Were Not Allowed");
                            }
                        }
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }
            return res;
        }



        public static bool IsExist_Student(int id)
        {
            foreach (Student s in Database.Students)
            {
                if (s.id.Equals(id))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsExist_Parent(int id)
        {
            foreach (Parent p in Database.Parents)
            {
                if (p.Id.Equals(id))
                {
                    return true;
                }
            }
            return false;
        }
    }





    
}
