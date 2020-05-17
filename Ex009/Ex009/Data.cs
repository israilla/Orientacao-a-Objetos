using System;
using System.Globalization;

namespace Ex009
{
    class Data
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public int Id { get; set; }

        public Data(string name, double salary, int id)
        {
            Name = name;
            Salary = salary;
            Id = id;
        }
        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * percentage / 100.0;
        }
        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
