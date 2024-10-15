using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.BusinessLayer.Exceptions
{
   

    public class InvalidPetAgeException : Exception
    {
        public InvalidPetAgeException(string message)
            : base($"Invalid Pet Age Exception: {message}")
        {
        }
    }

}
