using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLabb4CollectionGenerics
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }
        public Employee(int _id, string _name, string _gender, double _salary)
        {
            this.ID = _id;
            this.Name = _name;
            this.Gender = _gender;
            this.Salary = _salary;
        }
    }
}
