using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using global::PetPals.Entity;
using PetPals.BusinessLayer.DBUtil;


namespace PetPals.BusinessLayer.Repository
{
    
    

    namespace PetPals.BusinessLayer.Repository
    {
        public class AdoptionEventRepository : IAdoptionEventRepository
        {
            private readonly DbUtil _dbUtil;
            private readonly List<IAdoptable> _participants; // Stores participants for the event

            public AdoptionEventRepository()
            {
                _dbUtil = new DbUtil();
                _participants = new List<IAdoptable>();
            }

            // Method to host the adoption event
            public void HostEvent()
            {
                try
                {
                    if (_participants.Count == 0)
                    {
                        Console.WriteLine("No participants registered for the event.");
                        return;
                    }

                    Console.WriteLine("Hosting the Adoption Event with the following participants:");
                    foreach (var participant in _participants)
                    {
                        Console.WriteLine($"- {participant.GetDetails()}");
                    }

                    // Additional logic for hosting the event (e.g., scheduling, location) can be added here.
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
            //        if (participant == null)
            //        {
            //            Console.WriteLine("Invalid participant.");
            //            return;
            //        }

            //        _participants.Add(participant);
            //        Console.WriteLine($"{participant.GetDetails()} has been registered for the event.");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"An error occurred while registering the participant: {ex.Message}");
            //        // Log exception or handle accordingly
            //    }
            //}
        }
    }

}
