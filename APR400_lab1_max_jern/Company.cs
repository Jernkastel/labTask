using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APR400_lab1_max_jern
{
    class Company
    {
        //List of all employees
        List<Employee> employeeList = new List<Employee>();
        //A WriteLine delegate
        Action delegateTest = delegate { Console.WriteLine('\n' + "SomeMadeUpCompany - TM - 2019"); };
        //Variable for total salary
        double totalSalary;
        //List of company employees
        public Company()
        {
            //Company employees
            employeeList.Add(new Employee("Mangnus", "Hansson", "C++", 5, 30000)); //0
            employeeList.Add(new Employee("Marc", "Molander", "C#", 6, 30000)); //1
            //mentors
            employeeList.Add(new Mentee("Emil", "Snäll", "PHP", 3, 30000/*,(employeeList[6].firstName) + mentorList[6].lastName*/)); //2
            employeeList.Add(new Mentee("Max", "Hermingjern", "Java", 4, 30000/*,(employeeList[5].firstName) + mentorList[5].lastName*/)); //3
            employeeList.Add(new Mentee("Marx", "Jernander", "Java", 7, 30000/*,(employeeList[5].firstName) + mentorList[5].lastName*/)); //4
            //trainees
            employeeList.Add(new Mentor("Gramse", "Gummisork", "Java", 1, 30000)); //5
            employeeList.Add(new Mentor("Marc", "Molander", "PHP", 2, 30000)); //6
            //pairing mentors and employees
            //this would be better to do with a method like "GetEmployee"
            ((Mentor)employeeList[5]).AddMentee(((Mentee)employeeList[3]));
            ((Mentor)employeeList[5]).AddMentee(((Mentee)employeeList[4]));
            ((Mentor)employeeList[6]).AddMentee(((Mentee)employeeList[2]));
            //Writes out every employee and their info and sums up the total salaries
            foreach (var item in employeeList)
            {
                totalSalary += item.GetTotalSalary();
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Total salary paid: " + totalSalary);
            delegateTest();
        }
    }
}
