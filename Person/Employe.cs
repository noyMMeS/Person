using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Table
{
    public class Employe:Person
    {
        public string Job_title = "Программист";
        public string Salary = "100000$";
        public string workemail = "25300282@inueco.com";

        public DateTime birthDate = DateTime.Parse("2000, 1, 7");
        public string lastname = "Vokram";
        public string name = "Emsen";
    }
}
