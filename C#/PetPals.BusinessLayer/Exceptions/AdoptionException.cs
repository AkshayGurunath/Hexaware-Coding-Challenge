using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.BusinessLayer.Exceptions
{
    public class AdoptionException : Exception
    {
        public AdoptionException(string message) : base(message)
        {
        }
    }
}
