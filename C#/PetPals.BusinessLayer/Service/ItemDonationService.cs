using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using global::PetPals.Entity;
using PetPals.BusinessLayer.Repository;

namespace PetPals.BusinessLayer.Service
{

    namespace PetPals.BusinessLayer.Services
    {
        public class ItemDonationService : IItemDonationService
        {
            private readonly IItemDonationRepository _itemDonationRepository;

            public ItemDonationService(IItemDonationRepository itemDonationRepository)
            {
                _itemDonationRepository = itemDonationRepository;
            }

           
            public void RecordItemDonation(ItemDonation itemDonation)
            {
                try
                {
                    _itemDonationRepository.AddItemDonation(itemDonation);
                    Console.WriteLine("Item donation recorded successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while recording the item donation: {ex.Message}");
                    // Handle or log the exception as needed
                }
            }
        }
    }

}
