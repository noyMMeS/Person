using System;

namespace Table
{
    public class Program
    {
        static Employe cslprofile = new Employe();
        static void Main()
        {
            Console.WriteLine($"Id:{cslprofile.Job_title}\n" +
                              $"Name:{cslprofile.name} {cslprofile.lastname}\n" +
                              $"BirthDate: {cslprofile.birthDate}\n" +
                              $"Age:{DateTime.Now.Year - cslprofile.birthDate.Year}\n" +
                              $"Weight:{cslprofile.weight}\n" +
                              $"Height:{cslprofile.height}\n" +
                              $"Gender:{(cslprofile.Gender == true ? "Man" : "Girl")}" 



                );


        }
    }
}
