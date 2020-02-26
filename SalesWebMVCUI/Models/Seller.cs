using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVCUI.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal BaseSalary { get; set; }
        public DateTime BirthDate { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, decimal baseSalary,  Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord salesRecord)
        {
            Sales.Add(salesRecord);
        }

        public void RemoveSales(SalesRecord salesRecord)
        {
            Sales.Add(salesRecord);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(salesRecord => salesRecord.Date >= initial && salesRecord.Date <= final).Sum(SalesRecord => SalesRecord.Amount);
        }
    }
}
