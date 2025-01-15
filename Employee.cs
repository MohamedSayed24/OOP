using OOPC_.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPC_
{
    public class Employee
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public SecurityLevel SecurityLevel { get; set; }

        public decimal Salary { get; set; }

        public DateTime HireDate { get; set; }

        public Gender Gender { get; set; }


        public override string ToString()
        {
            return $"Id: {Id}\n Name: {Name}\n SecurityLevel: {SecurityLevel}\n Salary: {String.Format("{0:C}", Salary)}\n HireDate: {HireDate}\n Gender: {Gender}";
        }
    }

    public class EmployeeHireDateComparer : IComparer<Employee>
    {

        public int Compare(Employee? x, Employee? y )
        {
            if (x == null || y == null )
            {
                throw new ArgumentNullException("Employee cannot be null");
            }

            return x.HireDate.CompareTo(y.HireDate )  ;
        }

        

    }

}
