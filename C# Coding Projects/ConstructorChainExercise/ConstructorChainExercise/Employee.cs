using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChainExercise
{
    public class Employee
    {
        public Employee(int EmpId): this("", EmpId)
        {

        }

        public Employee(string name, int EmpId)
        {
            Record = new List<Employee>();
            ID = EmpId;
            Name = name;
        }

        private List<Employee> _record = new List<Employee>();
        public List<Employee> Record { get { return _record; } set { _record = value; } }        // we would also modify to List<T> so we could change the data type of the list
        public int ID { get; set; }
        public string Name { get; set; }
        public Guid newId { get; set; }
    }
}
