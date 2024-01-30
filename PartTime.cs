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
    internal class PartTime : Employee
    {
        private double rate;
        private double hours;

        public double PRate
        {
            get { return rate; }
            set { rate = value; }
        }
        public double PHours
        {
            get { return hours; }
            set { hours = value; }
        }
        public PartTime()
        {
            //Console.WriteLine("Default constructor in 'PartTime' called");
        }
        //ctor
        public PartTime(string id, string name, string address, string phone, long sin, string dob, string dep, double rate, double hours) : base(id, name, address, phone, sin, dob, dep)
        {
            //Console.WriteLine("ctor in 'PartTime' called");
            this.rate = rate;
            this.hours = hours;
        }

        public override double getPay()
        {
            //Retrieve rate and hours from object and return weekly pay
            return rate * hours;
        }
        public override string ToString()
        {
            return $"ID number: {ID}\nName: {Name}\nAddress: {Address}\nPhone number: {Phone}\nSIN: {SIN}\nDat of Birth: {DOB}\nDepartment: {Dep}\nRate: {rate}\nHours: {hours}";

        }
    }
}
