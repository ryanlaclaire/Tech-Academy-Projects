using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExercise2
{
    public class InvalidAge : Exception
    {
        public InvalidAge()
            : base()
        {

        }
        public InvalidAge(String message)
            : base(message)
        {

        }

    }
}
