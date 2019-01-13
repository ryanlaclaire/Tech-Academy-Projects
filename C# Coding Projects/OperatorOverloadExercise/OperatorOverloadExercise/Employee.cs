using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadExercise
{
    public class Employee
    {

        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public static bool operator== (Employee emp1, Employee emp2)
        {
            return emp1.ID == emp2.ID;
        }
  
        public static bool operator!= (Employee emp1, Employee emp2)
        {
            
            return emp1.ID != emp2.ID;
        }
        public override bool Equals(object obj)
        {
            Employee other = (Employee)obj;
            return other.ID == this.ID;
        }
       
    }
}
