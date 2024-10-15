using PetPals.BusinessLayer.Repository;
using PetPals.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.BusinessLayer.Service
{
    public class PetService : IPetService
    {
        private readonly IPetRepository _petRepository;

        public PetService(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        // Method to add a pet
        public void AddPet(Pet pet)
        {
            // Add any business logic or validation here if necessary
            _petRepository.AddPet(pet);
        }

        // Method to get all pets
        public List<Pet> GetAllPets()
        {
            return _petRepository.GetAllPets();
        }

        // Method to remove a pet
        public void RemovePet(int petId)
        {
            // Add any business logic or validation here if necessary
            _petRepository.RemovePet(petId);
        }

       
    }
}
