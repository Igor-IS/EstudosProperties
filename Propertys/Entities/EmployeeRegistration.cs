using Propertys.Enum;
using System;

namespace Propertys.Entities
{
    class EmployeeRegistration
    {
        private string _name;
        private string _documentNumber;
        private int _age;
        public string BirthDate { get; private set; }
        public char Gender { get; private set; }
        public JobSector EmployeePosition = new JobSector();

        public string Name 
        { 
            get { return _name; }
            set
            {
                if (value != null && value.Length > 2)
                {
                    _name = value;
                }
            }
        }

        public string DocumentNumber
        {
            get
            {
                return _documentNumber;
            }
            set
            {
                if (value != null && value.Length == 11)
                {
                    _documentNumber = value;
                }
            }
        }

        public EmployeeRegistration(string name, string doc, string birthDate, char gender, JobSector sector)
        {
            _name = name;
            _documentNumber = doc;
            BirthDate = birthDate;
            Gender = gender;
            EmployeePosition = sector;
            SetAge(birthDate);
        }

        private void SetAge(string date)
        {
            DateTime birthDate = Convert.ToDateTime(date);
            _age = DateTime.Today.Year - birthDate.Year;
        }

        public override string ToString()
        {
            return "Employee Data\n"
                + "Name: " + _name + "\nBith date: " + BirthDate
                + ", Document number: " + _documentNumber
                + ", Age: " + _age + " , Gender: " + Gender + "\n"
                + "Employee position: " + EmployeePosition;
        }

    }
}
