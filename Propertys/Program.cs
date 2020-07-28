using Propertys.Entities;
using Propertys.Enum;
using System;

namespace Propertys
{
    class Program
    {
        static void Main(string[] args)
        {

            EmployeeRegistration newEmployee = new EmployeeRegistration("Igor Henrique", "44224632845", "22/04/1993", 'M', JobSector.Maintenance);
            newEmployee.Name = "IG";
            newEmployee.DocumentNumber = "452200";
            Console.WriteLine(newEmployee);
        }
    }
}
