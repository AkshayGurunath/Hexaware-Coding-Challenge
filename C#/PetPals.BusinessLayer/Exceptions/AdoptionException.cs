using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.BusinessLayer.Exceptions
{
    public class AdoptionException : System.Exception
    {
        public override string Message
        {
            get
            {
                return "Some error occured while adopting!";
            }
        }
        public AdoptionException() : base()
        {

        }
        public AdoptionException(string message) : base(message)
        {

        }

        public AdoptionException(string message, System.Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
