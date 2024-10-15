using PetPals.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.BusinessLayer.Repository
{
    public interface IPetShelterRepository
    {
        void AddShelter(PetShelter petShelter);
        void RemoveShelter(int petId);
       
    }

}
