using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session_1
{
    internal struct Employee
    {
        private int id;
        private string name;
        private double salary;

        //getter and setter method
        //public void SetId(int _id)
        //{
        //    id = _id;
        //}
        //public int GetId()
        //{
        //    return id;
        //}
        //public void SetName(string name)
        //{
        //    this.name = name;
        //}
        //public string GetName() 
        //{
        //    return name;
        //}
        //public void SetSalary(double salary)
        //{
        //    if (salary > 0)
        //    {
        //        this.salary = salary;
        //    }
        //    else
        //    {
        //        this.salary = default;
        //    }
        //}
        //public double GetSalary() { return salary; }

        //Properties

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public Employee()
        {

        }
        public Employee(int id,string name, double salary)
        {
            this.id = id;
            this.salary = salary;
            this.name = name;
        }
        public override string ToString()
        {
            return $"{name} {id} {salary}";
        }
    }
}
