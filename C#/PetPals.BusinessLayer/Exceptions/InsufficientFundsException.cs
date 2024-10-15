using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.BusinessLayer.Exceptions
{
    public class InsufficientFundsException : Exception
    {
        // Custom exception for insufficient funds
       
            public InsufficientFundsException() : base("The donation amount is insufficient. Minimum allowed is $10.") { }

            public InsufficientFundsException(string message) : base(message) { }

            public InsufficientFundsException(string message, Exception innerException) : base(message, innerException) { }
        }
    }

