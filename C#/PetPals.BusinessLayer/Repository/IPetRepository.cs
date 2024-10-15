using PetPals.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.BusinessLayer.Repository
{
    public interface IPetRepository
    {
        void AddPet(Pet pet);
        void RemovePet(int petId);
        List<Pet> GetAllPets();
    }

}
