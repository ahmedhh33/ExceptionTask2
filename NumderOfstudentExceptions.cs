using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTask2
{
    internal class NumderOfstudentExceptions: ApplicationException
    {
        public NumderOfstudentExceptions() { 
        }

        public override string ToString()
        {
            return $"Number of student more than 40";
        }
    }
}
