using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ20
{
    public class Phone
    {
        public string Name { get; set; }           
        public string Manufacturer { get; set; }   
        public double Price { get; set; }          
        public DateTime ReleaseDate { get; set; }  

        
        public Phone(string n, string m, double p, DateTime r)
        {
            Name = n;
            Manufacturer = m;
            Price = p;
            ReleaseDate = r;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Manyfacturer: {Manufacturer}, " +
                   $"Price: {Price} UAH, Release Date: {ReleaseDate:dd.MM.yyyy}";
        }
    }

}
