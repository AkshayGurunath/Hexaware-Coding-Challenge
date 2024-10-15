using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.BusinessLayer.Exceptions
{
    public class NullReferenceException : System.Exception
    {
        public override string Message
        {
            get
            {
                return "You refered to an empty data object!";
            }
        }
        public NullReferenceException() : base()
        {

        }
        public NullReferenceException(string message) : base(message)
        {

        }

        public NullReferenceException(string message, System.Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
