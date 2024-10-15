using PetPals.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.BusinessLayer.Repository
{
    public interface IAdoptionEventRepository
    {
        void HostEvent(); // Method to host the adoption event
        //void RegisterParticipant(IAdoptable participant); // Method to register a participant
        
    }
}
