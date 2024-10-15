using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetPals.BusinessLayer.Exceptions;
using PetPals.BusinessLayer.Repository;
using PetPals.Entity;


namespace PetPals.BusinessLayer.Service
{
    

    public class DonationService : IDonationService
    {
        private readonly IDonationRepository _donationRepository;

        public DonationService(IDonationRepository donationRepository)
        {
            _donationRepository = donationRepository;
        }

        /// <summary>
        /// Records a donation after validating it.
        /// </summary>
        /// <param name="donation">The donation to be recorded.</param>
        public void RecordDonation(Donation donation)
        {
            if (donation == null)
            {
                throw new ArgumentNullException(nameof(donation), "Donation cannot be null.");
            }

            if (donation.Amount < 10) // Assuming the minimum donation amount is $10
            {
                throw new ArgumentException("Donation amount must be at least $10.");
            }

            _donationRepository.AddDonation(donation);
        }
    }

}
