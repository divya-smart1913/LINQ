using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }
    class Program
    {
        public static List<Employee> empList = new List<Employee>
{

 new Employee() {EmployeeID = 1001,FirstName = "Malcolm",LastName = "Daruwalla",Title = "Manager",DOB = DateTime.Parse("02/01/1984"),DOJ = DateTime.Parse("09/08/2011"),City = "Mumbai"},
new Employee() {EmployeeID = 1002,FirstName = "Asdin",LastName = "Dhalla",Title = "AsstManager",DOB = DateTime.Parse("20/08/1984"),DOJ = DateTime.Parse("7/7/2012"),City = "Mumbai"},
new Employee() {EmployeeID = 1003,FirstName = "Madhavi",LastName = "Oza",Title = "Consultant",DOB = DateTime.Parse("14/11/1987"),DOJ = DateTime.Parse("12/4/2015"),City = "Pune"},
new Employee() {EmployeeID = 1004,FirstName = "Saba",LastName = "Shaikh",Title = "SE",DOB = DateTime.Parse("6/3/1990"),DOJ = DateTime.Parse("2/2/2016"),City = "Pune"},
new Employee() {EmployeeID = 1005,FirstName = "Nazia",LastName = "Shaikh",Title = "SE",DOB = DateTime.Parse("3/8/1991"),DOJ = DateTime.Parse("2/2/2016"),City = "Mumbai"},
new Employee() {EmployeeID = 1006,FirstName = "Suresh",LastName = "Pathak",Title = "Consultant",DOB = DateTime.Parse("11/7/1989"),DOJ = DateTime.Parse("8/8/2014"),City = "Chennai"},
new Employee() {EmployeeID = 1007,FirstName = "Vijay",LastName = "Natrajan",Title = "Consultant",DOB = DateTime.Parse("12/2/1989"),DOJ = DateTime.Parse("6/1/2015"),City = "Mumbai"},
new Employee() {EmployeeID = 1008,FirstName = "Rahul",LastName = "Dubey",Title = "Associate",DOB = DateTime.Parse("11/11/1993"),DOJ = DateTime.Parse("11/6/2014"),City = "Chennai"},
new Employee() {EmployeeID = 1009,FirstName = "Amit",LastName = "Mistry",Title = "Associate",DOB = DateTime.Parse("8/12/1992"),DOJ = DateTime.Parse("12/3/2014"),City = "Chennai"},
new Employee() {EmployeeID = 1010,FirstName = "Sumit",LastName = "Shah",Title = "Manager",DOB = DateTime.Parse("4/12/1991"),DOJ = DateTime.Parse("1/2/2016"),City = "Pune"},

};
        
        //Method to Display All details of the EmployeeList
        public static void DisplayAll()
        {
            var displayallwmployees = (from Emp in empList select Emp);

            foreach (var e in displayallwmployees)
            {
                Console.WriteLine(e.EmployeeID + " " + e.FirstName + " " + e.LastName + " " + e.Title + " " + e.DOB + " " + e.DOJ + " "+ e.City);
            }
        }

        //Method to Display All details of the EmployeeList who are not from Mumbai
        public static void Notmumbai()
        {
            var NotMumbaiList = from e in empList where e.City!="Mumbai" select e;
            foreach(var e in NotMumbaiList)
            {
                Console.WriteLine(e.EmployeeID + " " + e.FirstName + " " + e.LastName + " " + e.Title + " " + e.DOB + " " + e.DOJ + " " + e.City);
            }
        }

        //Method to Display All details of the EmployeeList whose Title is AsstManager
        public static void TitleAsstManager()
        {
            var DisplayTitleAsstManagerList = from e in empList where e.Title == "AsstManager" select e;
            foreach (var e in DisplayTitleAsstManagerList)
            {
                Console.WriteLine(e.EmployeeID + " " + e.FirstName + " " + e.LastName + " " + e.Title + " " + e.DOB + " " + e.DOJ + " " + e.City);
            }
        }

        //Method to Display All details of the EmployeeList whose LastName Starts with s
        public static void LastNameStartswiths()
        {
            var LastNameStartswithsList = from e in empList where e.LastName.StartsWith("S")  select e;
            foreach (var e in LastNameStartswithsList)
            {
                Console.WriteLine(e.EmployeeID + " " + e.FirstName + " " + e.LastName + " " + e.Title + " " + e.DOB + " " + e.DOJ + " " + e.City);
            }
        }

        //Method to Display All details of the EmployeeList whose Doj is before 6/1/2015
        public static void EmployeeDojBeforeDate()
        {
            var EmployeeDojBeforeDateList = from e in empList where e.DOJ < DateTime.Parse("6/1/2015")  select e;
            foreach (var e in EmployeeDojBeforeDateList)
            {
                Console.WriteLine(e.EmployeeID + " " + e.FirstName + " " + e.LastName + " " + e.Title + " " + e.DOB + " " + e.DOJ + " " + e.City);
            }
        }
        //Method to Display All details of the EmployeeList whose DoB is after 6/1/1990
        public static void EmployeeDoBAfterDate()
        {
            var EmployeeDoBAfterList = from e in empList where e.DOB > DateTime.Parse("6/1/1990") select e;
            foreach (var e in EmployeeDoBAfterList)
            {
                Console.WriteLine(e.EmployeeID + " " + e.FirstName + " " + e.LastName + " " + e.Title + " " + e.DOB + " " + e.DOJ + " " + e.City);
            }
        }

        //Method to Display All details of the EmployeeList whose Title is Consultant and Associate
        public static void DesignationDetails()
        {
            var DesignationDetailsList = from e in empList where e.Title == "Consultant" || e.Title == "Associate" select e;
            foreach (var e in DesignationDetailsList)
            {
                Console.WriteLine(e.EmployeeID + " " + e.FirstName + " " + e.LastName + " " + e.Title + " " + e.DOB + " " + e.DOJ + " " + e.City);
            }
        }

        //Method to Display the Count of the EmployeeList 
        public static void EmployeeListCount()
        {
            var EmployeeListCount = from e in empList select e;
            Console.WriteLine("Total no of Employees in EmpList"+ EmployeeListCount.Count());
        }

        //Method to Display All details of the EmployeeList whose City is chennai
        public static void EmployeeCityChennai()
        {
            var EmployeeCityChennaiList = from e in empList where e.City == "Chennai" select e;
            foreach (var e in EmployeeCityChennaiList)
            {
                Console.WriteLine(e.EmployeeID + " " + e.FirstName + " " + e.LastName + " " + e.Title + " " + e.DOB + " " + e.DOJ + " " + e.City);
            }
        }

        //Method to Display the Detail of the Having Highest EmployeeId
        public static void EmployeeHighestID()
        {
            var EmployeeHighestid = (from e in empList  select e.EmployeeID).Max();
            Console.WriteLine("Highest Employee ID in EmplList is : " + EmployeeHighestid);
        }

        //Method to Display the Count of the EmployeeList whose doj after 1/1/2015
        public static void EmployeeDojAfterYear()
        {
            var EmployeeDojAfterDateCount = from e in empList where e.DOJ > DateTime.Parse("1/1/2015") select e;
            Console.WriteLine("Total no of Employees Whose Doj after 1/1/2015 are : " + EmployeeDojAfterDateCount.Count());
        }

        //Method to Display the Count of the EmployeeList whose Title is not equal to Associate
        public static void EmployeeTitleNotAssociate()
        {
            var EmployeeTitleNotAssociateCount = from e in empList where e.Title!="Associate" select e;
            Console.WriteLine("Total no of Employees Whose Title is not Associate are : " + EmployeeTitleNotAssociateCount.Count());
        }

        //Method to Display the Count of the EmployeeList based on City
        public static void EmployeeDetailsBasesOnCity()
        {
            var EmployeeDetailsBasesOnCityCount = from e in empList group e by e.City into e1 select e1;
            Console.WriteLine("Total no of Employee Details based on City is : " + EmployeeDetailsBasesOnCityCount.Count());
        }

        //Method to Display the Count of the EmployeeList based on City and Title
        public static void EmployeeDetailsBasesOnCityandTitle()
        {
            var EmployeeDetailsBasesOnCityandTitleCount = from e in empList group e by new { e.City , e.Title } into e1 select e1;
            Console.WriteLine("Total no of Employee Details based on City and Title is : " + EmployeeDetailsBasesOnCityandTitleCount.Count());
        }
        //Method to Display the Youngest Employee in EmpList
        public static void EmployeeWhoisYoungest()
        {
            var EmployeeWhoisYoungestCount = (from e in empList  select e.DOB).Max();
            Console.WriteLine(" Employee Who is Youngest is : " + EmployeeWhoisYoungestCount);
        }

        static void Main(string[] args)
        {

            // DisplayAll();
            // Notmumbai();
            //TitleAsstManager();
            // LastNameStartswiths();
            //EmployeeDojBeforeDate();
            //EmployeeDoBAfterDate();
            //DesignationDetails();
            //DesignationDetails();
            //EmployeeListCount();
            //EmployeeCityChennai();
            //EmployeeHighestID();
            // EmployeeDojAfterYear();
            //EmployeeTitleNotAssociate();
            // EmployeeDetailsBasesOnCity();
            //EmployeeDetailsBasesOnCityandTitle();
            //EmployeeWhoisYoungest();
            Console.ReadKey();

        }
    }

}


