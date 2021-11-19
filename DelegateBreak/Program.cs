using System;
using System.Collections.Generic;

namespace DelegateBreak
{
    public delegate void FullNameDelegate(string name, string surname);

    public delegate bool PromotionDelegate(Employee employee);
    
    
    static class Program
    {
        private static void Main()
        {
            //DelegateUsageExample();

            RealTimeDelegateExample();
            
            
        }

        private static void RealTimeDelegateExample()
        {
            List<Employee> employees = new List<Employee>();

            Employee employee1 = new Employee { Name = "Fatih", Surname = "Çakıroğlu", Salary = 1000, Skill = 1 };
            Employee employee2 = new Employee { Name = "Mehmet", Surname = "Çakıroğlu", Salary = 2000, Skill = 2 };
            Employee employee3 = new Employee { Name = "Hasan", Surname = "Çakıroğlu", Salary = 3000, Skill = 3 };
            Employee employee4 = new Employee { Name = "Ali", Surname = "Çakıroğlu", Salary = 4000, Skill = 4 };
            Employee employee5 = new Employee { Name = "Ömer", Surname = "Çakıroğlu", Salary = 5000, Skill = 5 };

            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);

            //Delegate Lambda Expression
            Employee.Promotion(employees, employee => employee.Salary >= 3);

            //Without Delegate

            /*
             Employee.PromotionBySalary(employees,2000);
            Console.WriteLine("-------------------");
            Employee.PromotionBySkill(employees,4);
            */
        }


        /*
         
         public static bool PromotionSalary_3000(Employee employee)
        {
            return employee.Salary >= 3000;
        }

        public static bool PromotionSkill_3(Employee employee)
        {
            return employee.Skill >= 3;
        }
        
        */


        private static void DelegateUsageExample()
        {
            FullNameDelegate fullNameDelegate = GetNameSurname;

            FullNameDelegate fullNameDelegate2 = GetNameSurnameUpperCase;

            FullNameDelegate chainDelegate = fullNameDelegate;
            chainDelegate += fullNameDelegate2;
            chainDelegate("Şahin", "MARAL");
        }

        static void GetNameSurname(string name,string surname)
        {
            Console.WriteLine("GetNameSurname");
            Console.WriteLine($"Name : {name} , Surname : {surname}");
            Console.WriteLine("---------");
        }

        static void GetNameSurnameUpperCase(string name, string surname)
        {
            Console.WriteLine("GetNameSurnameUpperCase");
            Console.WriteLine($"Name : {name.ToUpper()} , Surname : {surname.ToUpper()}");
            Console.WriteLine("---------");
        }
        
    }

    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Salary { get; set; }
        public int Skill { get; set; }

        //Without Delegate
        
        /*
         public static void PromotionBySalary(List<Employee> employees,int salary)
        {
            foreach (Employee employee in employees)
            {
                if (employee.Salary >= salary)
                {
                    Console.WriteLine(employee.Name + " " + employee.Surname);
                }
            }
        }
        
        public static void PromotionBySkill(List<Employee> employees,int skill)
        {
            foreach (Employee employee in employees)
            {
                if (employee.Skill >= skill)
                {
                    Console.WriteLine(employee.Name + " " + employee.Surname);
                }
            }
        }*/
        
        /*public static void Promotion(List<Employee> employees,PromotionDelegate promotionDelegate){
            foreach (Employee employee in employees)
            {
                if (promotionDelegate(employee))
                {
                    Console.WriteLine(employee.Name + " " + employee.Surname);
                }
            }
        }*/
        
        public static void Promotion(List<Employee> employees, Func<Employee, bool> promotionDelegate)
        {
            foreach (Employee employee in employees)
            {
                if (promotionDelegate(employee))
                {
                    Console.WriteLine(employee.Name + " " + employee.Surname);
                }
            }
        }
    }
}