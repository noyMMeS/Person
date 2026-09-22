using System;

namespace Table
{
    public class Program
    {
        static Employe cslprofile = new Employe();
        static void Main()
        {
            Student clsstudent = new Student();
            Console.WriteLine("---EMPLOY---");
            Console.WriteLine($"Title:{cslprofile.Job_title}\n" +
                              $"Name:{cslprofile.name} {cslprofile.lastname}\n" +
                              $"BirthDate: {cslprofile.birthDate}\n" +
                              $"Age:{DateTime.Now.Year - cslprofile.birthDate.Year}\n" +
                              $"Salary:{cslprofile.Salary}\n" +
                              $"WorkEmail:{cslprofile.workemail}\n" +
                              $"Gender:{(cslprofile.Gender == true ? "Man" : "Girl")}\n" +
                              $"PhoneNumber:{cslprofile.phone_numb}");

            Console.WriteLine("---STUDENT---");
            Console.WriteLine($"ID:{clsstudent.id}\n" +
                              $"Name:{clsstudent.name} {clsstudent.lastname}\n" +
                              $"BirthDate: {clsstudent.birthDate}\n" +
                              $"Age:{DateTime.Now.Year - clsstudent.birthDate.Year}\n" +
                              $"Email:{clsstudent.Email}\n" +
                              $"Group:{clsstudent.group}\n" +
                              $"Gender:{(clsstudent.Gender == true ? "Man" : "Girl")}\n" +
                              $"PhoneNumber:{clsstudent.phone_numb}");






        }

        
        
    }
}
