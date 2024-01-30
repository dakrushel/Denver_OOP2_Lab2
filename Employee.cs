using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Krushel_Lab2
{
    public class Employee
    {
        //Variables
        private string iD;
        private string name;
        private string address;
        private string phone;
        private long sIN;
        private string dOB;
        private string dep;

        public string ID //{ get; set; }
        {
            get { return iD; }
            set { iD = value; }
        }
        public string Name //{ get; set; }
        {
            get { return name; }
            set { name = value; }
        }
        public string Address //{ get; set; }
        {
            get { return address; }
            set { address = value; }
        }
        public string Phone //{ get; set; }
        {
            get { return phone; }
            set { phone = value; }
        }
        public long SIN  //{ get; set; }
        {
            get { return sIN; }
            set { sIN = value; }
        }
        public string DOB //{ get; set; }
        {
            get { return dOB; }
            set { dOB = value; }
        }
        public string Dep //{ get; set; }
        {
            get { return dep; }
            set { dep = value; }
        }

        //Default ctor
        public Employee()
        {
            //Console.WriteLine("Default constructor in 'Employee' called.");
        }
        //Other ctor
        public Employee(string aID, string aName, string aAddress, string aPhone, long aSIN, string aDOB, string aDep)
        {
            iD = aID;
            name = aName;
            address = aAddress;
            phone = aPhone;
            sIN = aSIN;
            dOB = aDOB;
            dep = aDep;
        }

        //Methods
        public virtual double getPay() { return 0; }
        public override string ToString()
        {
            return $"ID number: {iD}\nName: {name}\nAddress: {address}\nPhone number: {phone}\nSIN: {sIN}\nDat of Birth: {dOB}\nDepartment: {dep}";
        }
    }


}
