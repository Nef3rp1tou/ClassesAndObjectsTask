using System;

namespace ClassesAndObjectsTask
{
    public class Employee
    {
        private string surname;
        private int age;

        public Employee()
        {
            this.surname = string.Empty;
            this.age = 0;
        }

        public Employee(string surname, int age)
        {
            this.surname = surname ?? throw new ArgumentNullException(nameof(surname), $"{nameof(surname)} can not be null");
            this.age = age >= 0 ? age : throw new ArgumentOutOfRangeException(nameof(age), $"{nameof(age)} must be a non-negative value");
        }

        private string GetAge()
        {
            return this.age.ToString();
        }

        public void ChangeSurname(string newSurname)
        {
            if (string.IsNullOrEmpty(newSurname))
            {
                throw new ArgumentException("Surname cannot be empty", nameof(newSurname));
            }
            this.surname = newSurname;
        }

        public string GetEmployeeInfo()
        {
            return $"Surname: {this.surname}, Age: {this.age}";
        }
    }
}
