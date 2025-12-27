using System;
using System.Linq;

namespace CompanyLINQ
{
    public class Company
    {
        public string Name { get; set; }              
        public DateTime FoundedDate { get; set; }     
        public string BusinessProfile { get; set; }  
        public string DirectorNSP { get; set; }  
        public int EmployeesCount { get; set; }      
        public string Address { get; set; }           

        public Company(string n, DateTime f, string b,string d, int e, string a)
        {
            Name = n;
            FoundedDate = f;
            BusinessProfile = b;
            DirectorNSP = d;
            EmployeesCount = e;
            Address = a;
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"   Date releaze: {FoundedDate:dd.MM.yyyy}\n" +
                   $"   Profile: {BusinessProfile}\n" +
                   $"   Director: {DirectorNSP}\n" +
                   $"   Employees: {EmployeesCount}\n" +
                   $"   Addres: {Address}";
        }
    }
}
