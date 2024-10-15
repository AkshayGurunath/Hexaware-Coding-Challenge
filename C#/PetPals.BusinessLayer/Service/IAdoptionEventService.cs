using PetPals.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.BusinessLayer.Service
{
    public interface IAdoptionEventService
    {
        void HostEvent(); // Method to host an adoption event
        // RegisterParticipant(IAdoptable participant); // Method to register a participant
    }
}
