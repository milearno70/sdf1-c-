
using System.Collections.Generic;


namespace sdf1_c_
{
    public class Employee
    {
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Payment> Payments { get; set; }

        public Employee()
        {
            Payments = new List<Payment>();   
        }

        public override string ToString()
        {
            return Code + " - " + FirstName + " " + LastName;
        }
    }

}
