using PetPals.BusinessLayer.Repository;
using PetPals.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.BusinessLayer.Service
{
    public class AdoptionEventService : IAdoptionEventService
    {
        private readonly IAdoptionEventRepository _adoptionEventRepository;

        public AdoptionEventService(IAdoptionEventRepository adoptionEventRepository)
        {
            _adoptionEventRepository = adoptionEventRepository;
        }

        // Method to host an adoption event
        public void HostEvent()
        {
            try
            {
                _adoptionEventRepository.HostEvent(); // Calls the repository to host the event
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while hosting the event: {ex.Message}");
                // Log exception or handle accordingly
            }
        }

        //// Method to register a participant for the event
        //public void RegisterParticipant(IAdoptable participant)
        //{
        //    try
        //    {
        //        _adoptionEventRepository.RegisterParticipant(participant); // Calls the repository to register a participant
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"An error occurred while registering the participant: {ex.Message}");
        //        // Log exception or handle accordingly
        //    }
        //}
    }
}

