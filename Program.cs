using System;
using System.Collections.Generic;
namespace OOPLabb4CollectionGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee E1 = new Employee(1001,"Patrik","Male",0);
            Employee E2 = new Employee(1002, "Tim", "Male", 8000);
            Employee E3 = new Employee(1003, "Sara", "Female", 16000);
            Employee E4 = new Employee(1004, "Malva", "Female", 32000);
            Employee E5 = new Employee(1005, "John", "Male", 64000);


            Stack<Employee> Empstack = new Stack<Employee>();
            Empstack.Push(E1);
            Empstack.Push(E2);
            Empstack.Push(E3);
            Empstack.Push(E4);
            Empstack.Push(E5);

            Console.WriteLine("~~~~All items in stack~~~~");

            foreach (var item in Empstack)
            {
                Console.WriteLine("ID = {0}\nName = {1}\nGender = {2}\nSalary = {3}", item.ID, item.Name, item.Gender, item.Salary);
                Console.WriteLine("Items left in stack = {0} ", Empstack.Count);
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~");
            }

            Console.WriteLine("~~~~~~~~~~~~POP~~~~~~~~~~~~");


            for (int i = Empstack.Count; i > 0 ; i--)
            {
                Employee e = Empstack.Pop();
                Console.WriteLine("ID = {0}\nName = {1}\nGender = {2}\nSalary = {3}", e.ID, e.Name, e.Gender, e.Salary);
                Console.WriteLine("Items left in stack = {0} ", Empstack.Count);
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~");
            }
            Empstack.Push(E1);
            Empstack.Push(E2);
            Empstack.Push(E3);
            Empstack.Push(E4);
            Empstack.Push(E5);
            Console.WriteLine("~~~~~~~~~PEEK~~~~~~~~~~~");
            for (int i = 0; i < 2; i++)
            {
                Employee e = Empstack.Peek();
                Console.WriteLine("ID = {0}\nName = {1}\nGender = {2}\nSalary = {3}", e.ID, e.Name, e.Gender, e.Salary);
                Console.WriteLine("Items left in stack = {0} ", Empstack.Count);
            }
            Console.WriteLine("~~~~~~~Contains Employee~~~~~~~~");
            if (Empstack.Contains(E3))
            {
                Console.WriteLine("This Employee is in the stack");
            }
            else
            {
                Console.WriteLine("This Employee is not in the stack");
            }
            Console.WriteLine("~~~~~~~~~~~~~~LIST~~~~~~~~~~~~~~~~");

            List<Employee> EmpList = new List<Employee>();
            EmpList.Add(E1);
            EmpList.Add(E2);
            EmpList.Add(E3);
            EmpList.Add(E4);
            EmpList.Add(E5);

            Console.WriteLine("Does Employee E3 exist in the list?");

            if (EmpList.Contains(E3))
            {
                Console.WriteLine("Employee exists in the list ");
            }
            else
            {
                Console.WriteLine("Employee does not exist in the list ");
            }

            Console.WriteLine("~~~~~~~~FIND~~~~~~~~~~");

            Employee a = EmpList.Find(x => x.Gender.Contains("Male"));
            Console.WriteLine("First male in list:\nID: {0}\nName : {1}\nGender: {2}\nSalary: {3}",a.ID,a.Name,a.Gender,a.Salary);

            Console.WriteLine("~~~~~~~~FIND ALL~~~~~~~~");

            List<Employee> Males = EmpList.FindAll(x => x.Gender.Contains("Male"));

            foreach (var item in Males)
            {
                Console.WriteLine("Males in the list:\nID: {0}\nName: {1}\nGender: {2}\nSalary: {3}",item.ID,item.Name,item.Gender,item.Salary);
            }

            Console.ReadKey();
        }
    }
}
