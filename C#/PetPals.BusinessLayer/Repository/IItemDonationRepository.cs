using PetPals.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.BusinessLayer.Repository
{
    public interface IItemDonationRepository
    {
        void AddItemDonation(ItemDonation itemDonation);
    }
}
