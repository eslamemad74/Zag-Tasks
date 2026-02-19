using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ3
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public List<string> Skills { get; set; }

        public override string ToString()
        {
            return $"{Id,-5} {FirstName,-10} {LastName,-10} [{Department,-12}] Skills: {string.Join(", ", Skills)}";
        }
    }
}