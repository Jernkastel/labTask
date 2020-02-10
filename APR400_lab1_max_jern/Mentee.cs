using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APR400_lab1_max_jern
{
    class Mentee : Employee
    {
        private Mentor mentor;
        private List<Mentor> mentorList = new List<Mentor>();
        //Mentee constructor
        public Mentee(string firstName, string lastName, string specialization, int payrollNr, double baseSalary)
            : base(firstName, lastName, specialization, payrollNr, baseSalary)
        {
            //this.mentor = mentor;
        }
        //Adds mentor to mentee
        public void AddMentor(Mentor mentor)
        {
            mentorList.Add(mentor);
            this.mentor = mentor;
        }
        //Checks for mentor and returns string with first name
        public override string CheckRole()
        {
            if (mentor != null)
            {
                return " Mentor: " + mentor.firstName;
            }
            return "";
        }
    }
}
