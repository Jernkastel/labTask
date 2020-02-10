using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APR400_lab1_max_jern
{
    class Employee
    {
        public string firstName;
        public string lastName;
        public string specialization;
        public int payrollNr;
        public double baseSalary;
        //virtual get that gets overridden by the other classes
        public virtual double GetMentorBonus()
        {
            return 0;
        }
        //Sums up base salary and the mentor/java ´bonus
        public double GetTotalSalary()
        {

            return baseSalary + GetMentorBonus() + GetJavaBonus();
        }
        //Employee constructor
        public Employee(string firstName, string lastName, string specialization, int payrollNr, double baseSalary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.specialization = specialization;
            this.payrollNr = payrollNr;
            this.baseSalary = baseSalary;
        }
        //10% bonus salary on Java specialization
        public double GetJavaBonus()
        {
            if (specialization == "Java")
            {
                return baseSalary * 0.1;
            }
            return 0;
        }
        //ToString method that prints the information
        public override string ToString()
        {
            return "Name: " + firstName + " " + lastName + "," + " Specialization: " + specialization + "," + " PayrollNr: " + payrollNr + "," + " Salary: " + GetTotalSalary() + CheckRole();
        }
        public string EmployeeInfo()
        {
            return "Name: " + firstName + " " + lastName + "," + " Specialization: " + specialization + "," + " PayrollNr: " + payrollNr + "," + " Salary: " + GetTotalSalary() + CheckRole();
        }
        //Fetches programing language
        public string GetSpecialization()
        {
            return specialization;
        }
        //virtual method that checks if employee has mentor or mentee. Gets overridden by other classes
        public virtual string CheckRole()
        {
            return "";
        }
        //Checks payrollNr
        public override bool Equals(object obj)
        {
            if (obj is Employee && ((Employee)obj).payrollNr == payrollNr)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
