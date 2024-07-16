/*1.create an interface called GovtRules which defines prototype for methods like
1.public double EmployeePF(double basicSalary);
2.public string LeaVeDetails();
3.public double gratuityAmount(float serviceCompleted,double basicSalary);
Implement the interface in classes like TCS,Accenture
All classes should have datamembers like empid,name,dept,desg and basic salary
All values should be assigned through parameterized constructor
and data should be displayed using properties.
If class is TCS , 12% of basic salary of employee should go for PF and 8.33% of basic
salary should go for PF as employer contribution and 3.67% of Basic Amount should
go for Pension Fund from employer contribution.
Leave Details for TCS is
1 day of Casual Leave per month
12 days of Sick Leave per year
10 days of Previlage Leave per year
Gratuity amount : if the no of service year completed in the same company is > 5 ,
1month basic salary will be deposited in gratuity amount
if >10 years service , 2*basic salary=gratuity amount
if >20 years service , 3* basic salary=gratuity amount
if < 5 no gratuity.
If class is Accenture ,
12% of basic salary of employee should go for PF and 12% of employer contribution
should go to PFfrom employer contribution.
Leave Details for Accenture is
2 day of Casual Leave per month
5 days of Sick Leave per year
5 days of Previlage Leave per year
Gratuity amount : Not applicable
implement the methods accordingly and display the detailed output.*/

namespace Assignment6
{
    interface IGovtRules
    {
        double EmployeePF(double basicSalary);
        string LeaveDetails();
        double GratuityAmount(float serviceCompleted, double basicSalary);
    }

    // Define the TCS class implementing the IGovtRules interface
    class TCS : IGovtRules
    {
        public int EmpId { get; private set; }
        public string Name { get; private set; }
        public string Dept { get; private set; }
        public string Desg { get; private set; }
        public double BasicSalary { get; private set; }

        public TCS(int empId, string name, string dept, string desg, double basicSalary)
        {
            EmpId = empId;
            Name = name;
            Dept = dept;
            Desg = desg;
            BasicSalary = basicSalary;
        }

        public double EmployeePF(double basicSalary)
        {
            return basicSalary * 0.12;
        }

        public string LeaveDetails()
        {
            return "1 day of Casual Leave per month\n12 days of Sick Leave per year\n10 days of Privilege Leave per year";
        }

        public double GratuityAmount(float serviceCompleted, double basicSalary)
        {
            if (serviceCompleted > 20)
            {
                return 3 * basicSalary;
            }
            else if (serviceCompleted > 10)
            {
                return 2 * basicSalary;
            }
            else if (serviceCompleted > 5)
            {
                return basicSalary;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"EmpId: {EmpId}, Name: {Name}, Dept: {Dept}, Desg: {Desg}, Basic Salary: {BasicSalary}";
        }
    }

    // Define the Accenture class implementing the IGovtRules interface
    class Accenture : IGovtRules
    {
        public int EmpId { get; private set; }
        public string Name { get; private set; }
        public string Dept { get; private set; }
        public string Desg { get; private set; }
        public double BasicSalary { get; private set; }

        public Accenture(int empId, string name, string dept, string desg, double basicSalary)
        {
            EmpId = empId;
            Name = name;
            Dept = dept;
            Desg = desg;
            BasicSalary = basicSalary;
        }

        public double EmployeePF(double basicSalary)
        {
            return basicSalary * 0.12;
        }

        public string LeaveDetails()
        {
            return "2 days of Casual Leave per month\n5 days of Sick Leave per year\n5 days of Privilege Leave per year";
        }

        public double GratuityAmount(float serviceCompleted, double basicSalary)
        {
            return 0; // Gratuity amount not applicable for Accenture
        }

        public override string ToString()
        {
            return $"EmpId: {EmpId}, Name: {Name}, Dept: {Dept}, Desg: {Desg}, Basic Salary: {BasicSalary}";
        }
    }

    // Main Program
    class Program
    {
        static void Main()
        {
            TCS tcsEmployee = new TCS(101, "John Doe", "IT", "Software Engineer", 50000);
            Accenture accentureEmployee = new Accenture(201, "Jane Smith", "HR", "HR Manager", 60000);

            Console.WriteLine("TCS Employee Details:");
            Console.WriteLine(tcsEmployee.ToString());
            Console.WriteLine("PF Contribution: " + tcsEmployee.EmployeePF(tcsEmployee.BasicSalary));
            Console.WriteLine("Leave Details: " + tcsEmployee.LeaveDetails());
            Console.WriteLine("Gratuity Amount (7 years): " + tcsEmployee.GratuityAmount(7, tcsEmployee.BasicSalary));
            Console.WriteLine();

            Console.WriteLine("Accenture Employee Details:");
            Console.WriteLine(accentureEmployee.ToString());
            Console.WriteLine("PF Contribution: " + accentureEmployee.EmployeePF(accentureEmployee.BasicSalary));
            Console.WriteLine("Leave Details: " + accentureEmployee.LeaveDetails());
            Console.WriteLine("Gratuity Amount (7 years): " + accentureEmployee.GratuityAmount(7, accentureEmployee.BasicSalary));
        }
    }
}
