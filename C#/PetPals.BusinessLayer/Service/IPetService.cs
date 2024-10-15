using PetPals.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.BusinessLayer.Service
{
    public interface IPetService
    {
        void AddPet(Pet pet);
        List<Pet> GetAllPets();
        void RemovePet(int petId);
        
    }
}
