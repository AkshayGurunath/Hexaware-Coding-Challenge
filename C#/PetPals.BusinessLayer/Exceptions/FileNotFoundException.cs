using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.BusinessLayer.Exceptions
{
    public class FileNotFoundException : System.Exception
    {
        public override string Message
        {
            get
            {
                return "File not found!";
            }
        }
        public FileNotFoundException() : base()
        {

        }
        public FileNotFoundException(string message) : base(message)
        {

        }

        public FileNotFoundException(string message, System.Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
