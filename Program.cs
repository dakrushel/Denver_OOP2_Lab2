using System.Security.Cryptography.X509Certificates;

namespace Krushel_Lab2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Employee Bob = new Employee("1", "Bob", "123 Street", "555", 2, "1/1/1", "Dep");
            //Console.WriteLine(Bob.ToString());

            //Employee Bobby = new Salaried("5", "Bobby", "123 Street", "555", 2, "1/1/1", "Dep", 3);
            //Console.WriteLine(Bobby.ToString());

            //create employee list
            List<Employee> empList = new List<Employee>();
            string percentages = "";
            //declare a function that loops through the txt file
            void makeList (string filePath)
            {
                //skim the txt file one line at a time
                string line;
                double sI = 0;
                double wI = 0;
                double pI = 0;
                StreamReader stream = new StreamReader(filePath);
                line = stream.ReadLine();
                while (line != null)
                {
                    //take in each parameter separated by :
                    string[] parames = line.Split(":");
                    //if the the first character of ID is 0-4, pass parameters into Salaried, 5-7 Wages, 8-9 PartTime
                    if (parames[0].Substring(0, 1) == "0" || parames[0].Substring(0, 1) == "1" || parames[0].Substring(0, 1) == "2" || parames[0].Substring(0, 1) == "3" || parames[0].Substring(0, 1) == "4")
                    {
                        Employee emp = new Salaried(parames[0], parames[1], parames[2], parames[3], long.Parse(parames[4]), parames[5], parames[6], double.Parse(parames[7]));
                        empList.Add(emp);
                        sI++;
                        //Console.WriteLine($"Instance {sI} of Salaried created");
                    }
                    else if (parames[0].Substring(0, 1) == "5" || parames[0].Substring(0, 1) == "6" || parames[0].Substring(0, 1) == "7")
                    {
                        Employee emp = new Wages(parames[0], parames[1], parames[2], parames[3], long.Parse(parames[4]), parames[5], parames[6], double.Parse(parames[7]), double.Parse(parames[8]));
                        empList.Add(emp);
                        wI++;
                        //Console.WriteLine($"Instance {wI} of Wages created");
                    }
                    else if (parames[0].Substring(0, 1) == "8" || parames[0].Substring(0, 1) == "9")
                    {
                        Employee emp = new PartTime(parames[0], parames[1], parames[2], parames[3], long.Parse(parames[4]), parames[5], parames[6], double.Parse(parames[7]), double.Parse(parames[8]));
                        empList.Add(emp);
                        pI++;
                        //Console.WriteLine($"Instance {pI} of PartTime created");
                    }
                    //add Salaried, Wages, or PartTime to Employee list
                    line = stream.ReadLine();
                }
                percentages = $"Employee breakdown:\n{(sI / empList.Count * 100).ToString($"F{1}")}% in Salaried\n{(wI / empList.Count *  100).ToString($"F{1}")}% in Wages\n{(pI / empList.Count * 100).ToString($"F{1}")}% in PartTime";
            }

            makeList("employees.txt");
            string avgPay(List<Employee> inputList)
            {
                double payTotal = 0;
                //loop through employee list
                foreach (Employee emp in inputList)
                {
                    //call GetPay and add it to total
                    payTotal += emp.getPay();
                }
                //return total divided by length of employee list
                return $"The average weekly pay for all employees is ${Math.Round(payTotal / (inputList.Count), 2)}";
            }
            Console.WriteLine(avgPay(empList));

            string findMoneyBags(List<Employee> inputList)
            {
                double highPay = 0;
                string highName = "error";
                //loop through list
                foreach (Employee emp in inputList)        
                {
                    //separate wage employees check weekly pay for highest and record name of highest
                    if (emp is Wages && emp.getPay() > highPay)
                    {
                        highPay = emp.getPay();
                        highName = emp.Name;
                    }
                }
                //return highest with name
                return $"The highest paid employee in Wages is {highName} at ${highPay.ToString($"F{2}")} per week";
            }
            Console.WriteLine(findMoneyBags(empList));
            string findPoorPerson(List<Employee> inputList)
            {
                double lowPay = Math.Pow(10, 12);
                string lowName = "error";
                //loop through list
                foreach (Employee emp in inputList)
                {
                    //separate wage employees check salary for lowest and record pay and name
                    if (emp is Salaried && (emp.getPay()) < lowPay)
                    {
                        lowPay = emp.getPay();
                        lowName = emp.Name;
                        //Console.WriteLine("low loop ran");
                    }
                }
                //return lowest with name
                return $"The lowest paid employee in Salaried is {lowName} at ${lowPay.ToString($"F{2}")} per week";
            }
            Console.WriteLine(findPoorPerson(empList));
            string getPercentage()
            {
                return percentages;
            }
            Console.WriteLine(getPercentage());
        }
    }
}
