using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krushel_Lab2
{
    public class Wages : Employee
    {
        private double rate;
        private double hours;

        public double WRate
        {
            get { return rate; }
            set { rate = value; }
        }
        public double WHours
        {
            get { return hours; }
            set { hours = value; }
        }
        public Wages()
        {
            //Console.WriteLine("Default constructor in 'Wages' called");
        }
        //ctor
        public Wages(string id, string name, string address, string phone, long sin, string dob, string dep, double rate, double hours) : base(id, name, address, phone, sin, dob, dep)
        {
            //Console.WriteLine("ctor in 'Wages' called");
            this.rate = rate;
            this.hours = hours;
        }

        public override double getPay()
        {
            if (hours > 40)
            {
                double ovr = hours - 40;
                return (40 * rate) + (ovr * (rate * 1.5));
            }
            else
            {
                return rate * hours;
            }
        }
        public override string ToString()
        {
            return $"ID number: {ID}\nName: {Name}\nAddress: {Address}\nPhone number: {Phone}\nSIN: {SIN}\nDat of Birth: {DOB}\nDepartment: {Dep}\nRate: {rate}\nHours: {hours}";

        }
    }
}
