using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Krushel_Lab2
{
    public class Salaried : Employee
    {
        //Variable
        private double salary;
        
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        //Default ctor
        public Salaried()
        {
            //Console.WriteLine("Default constructor in 'Salaried' called");
        }
        //ctor
        public Salaried(string id, string name, string address, string phone, long sin, string dob, string dep, double salary) : base(id, name, address, phone, sin, dob, dep)
        {
            //Console.WriteLine("ctor in 'Salaried' called");
            this.salary = salary;
        }

        public override double getPay()
        {
            //Retrieve salary from object and return weekly salary
            return salary;
        }
        public override string ToString()
        {
            return $"ID number: {ID}\nName: {Name}\nAddress: {Address}\nPhone number: {Phone}\nSIN: {SIN}\nDat of Birth: {DOB}\nDepartment: {Dep}\nSalary: {salary}";

        }
    }
}
