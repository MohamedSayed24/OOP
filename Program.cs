using OOPC_.Enums;

namespace OOPC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Design and implement a Class for the employees in a company:
            //Employee employee = new Employee();
            //employee.Id = 1;
            //employee.Name = "Mohamed";
            //employee.SecurityLevel = SecurityLevel.DBA;
            //employee.Salary = 18750.890m;
            //employee.HireDate = new DateTime(2018, 8, 24);
            //employee.Gender = Gender.Male;
            //Console.WriteLine(employee);
            #endregion


            #region Develop a Class to represent the Hiring Date Data:

            //HiringDateData hiringDateData = new HiringDateData(3, 20, 2020);

            //Console.WriteLine(hiringDateData);
            #endregion

            #region Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee[EmpArr;)

            Employee[] employees = new Employee[3];
            employees[0] = new Employee();
            employees[0].Id = 1;
            employees[0].Name = "Mohamed";
            employees[0].SecurityLevel = SecurityLevel.DBA;
            employees[0].Salary = 18750.890m;
            employees[0].HireDate = new DateTime(2018, 8, 24);
            employees[0].Gender = Gender.Male;

            employees[1] = new Employee();
            employees[1].Id = 2;
            employees[1].Name = "Ahmed";
            employees[1].SecurityLevel = SecurityLevel.guest;
            employees[1].Salary = 15000.89m;
            employees[1].HireDate = new DateTime(2019, 9, 24);
            employees[1].Gender = Gender.Male;

            employees[2] = new Employee();
            employees[2].Id = 3;
            employees[2].Name = "AYA";
            employees[2].SecurityLevel = (SecurityLevel)15;
            employees[2].Salary = 40000.500m;
            employees[2].HireDate = new DateTime(2014, 3, 16);
            employees[2].Gender = Gender.Female;

            for (int i = 0; i <employees.Length; i++)
            {
             Console.WriteLine(employees[i]);
            }
            #endregion

            #region Sort the employees based on their hire date then Print the sorted array.

            IComparer<Employee> employeeHireDateComparer = new EmployeeHireDateComparer();

            Array.Sort(employees,employeeHireDateComparer);

            Console.WriteLine("====================After Sorting==================\n");
            for (int i = 0; i < employees.Length; i++)
            {
                
                Console.WriteLine(employees[i]);
            }

            #endregion
        }
    }
}
