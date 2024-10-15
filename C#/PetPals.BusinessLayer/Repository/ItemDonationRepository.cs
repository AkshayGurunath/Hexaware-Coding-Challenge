using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetPals.BusinessLayer.DBUtil;
using PetPals.Entity;

using System.Data.SqlClient;

namespace PetPals.BusinessLayer.Repository
{
   

    namespace PetPals.BusinessLayer.Repository
    {
        public class ItemDonationRepository : IItemDonationRepository
        {
            private readonly DbUtil _dbUtil;

            public ItemDonationRepository()
            {
                _dbUtil = new DbUtil();
            }

            // Method to add an item donation
            public void AddItemDonation(ItemDonation itemDonation)
            {
                string query = "INSERT INTO ItemDonations (DonorName, Amount, ItemType) VALUES (@DonorName, @Amount, @ItemType)";
                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@DonorName", itemDonation.DonorName),
                new SqlParameter("@Amount", itemDonation.Amount),
                new SqlParameter("@ItemType", itemDonation.ItemType)
                };

                try
                {
                    _dbUtil.ExecuteNonQuery(query, parameters);
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"Database error while adding item donation: {ex.Message}");
                    // Log exception or handle accordingly
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while adding item donation: {ex.Message}");
                    // Log exception or handle accordingly
                }
            }
        }
    }

}
