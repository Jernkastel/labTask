using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APR400_lab1_max_jern
{
    class Mentor : Employee
    {
        double mentorBonus;
        private List<Mentee> menteeList = new List<Mentee>();
        //Mentor constructor
        public Mentor(string firstName, string lastName, string specialization, int payrollNr, double baseSalary/*, List<Mentee> mentee*/)
            : base(firstName, lastName, specialization, payrollNr, baseSalary)
        {
            /*
            if (menteeList.Count == 0)
            {
                double mentorBonus = MentorBonus();
                this.baseSalary = this.baseSalary + mentorBonus;
            }
            */
        }
        //5% bonus on salary based on number of mentees
        public override double GetMentorBonus()
        {
            if (menteeList.Count != 0)
            {
                return baseSalary * 0.05 * menteeList.Count;
            }
            return 0;
        }
        //Adds a mentee to a mentor
        public void AddMentee(Mentee mentee)
        {
            if (mentee.GetSpecialization() == GetSpecialization())
            {
                menteeList.Add(mentee);
                mentee.AddMentor(this);
            }
            else
            {
                throw new ArgumentException("Specialization mismatch", "Both Mentee and Mentor must specialize in the same coding language");
            }
        }
        //Checks for mentee and returs string with first name
        public override string CheckRole()
        {
            if (menteeList != null)
            {
                string result = ", Mentee: ";
                foreach (Mentee mentee in menteeList)
                {
                    result += mentee.firstName + " ";
                }
                return result;
            }
            return "";
        }
    }
}

