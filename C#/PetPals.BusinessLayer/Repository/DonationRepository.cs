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
    

    public class DonationRepository : IDonationRepository
    {
        private readonly DbUtil _dbUtil;

        public DonationRepository()
        {
            _dbUtil = new DbUtil();
        }

        // Method to add a donation
        public void AddDonation(Donation donation)
        {
            string query = "INSERT INTO Donations (DonorName, Amount) VALUES (@DonorName, @Amount)";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@DonorName", donation.DonorName),
            new SqlParameter("@Amount", donation.Amount)
            };

            try
            {
                _dbUtil.ExecuteNonQuery(query, parameters);
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Database error while adding donation: {ex.Message}");
                // Log exception or handle accordingly
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while adding donation: {ex.Message}");
                // Log exception or handle accordingly
            }
        }
    }

}
