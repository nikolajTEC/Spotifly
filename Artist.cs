using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifly
{
    public class Artist : Base
    {
        private string _name;
        private string _country;
        private DateTime _birthday;
        public string Name 
        { 
         get => _name; 
         set => _name = value; 
        }
        public string Country 
        {
            get => _country; 
            set => _country = value; 
        }
        public DateTime Birthday 
        {
            get => _birthday;
            set => _birthday = value;
        }

        public int GetAge(DateTime birthday)
        {
            TimeSpan difference = DateTime.Today.Subtract(birthday);
            DateTime ageDateTime = DateTime.MinValue + difference;
            int ageInYears = ageDateTime.Year - 1;
            //var age = new Age(birthday, DateTime.Today);
            //int age = DateTime.Today.Year - birthday.Year;
            return ageInYears;
        }
        public override string ToString()
        {
            return $"Name: {Name}\nCountry: {Country}\nDoB: {Birthday.ToString("yyyy-MM-dd")}\n";
        }
    }
}
