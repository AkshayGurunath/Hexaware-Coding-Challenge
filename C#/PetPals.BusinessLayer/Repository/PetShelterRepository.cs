using PetPals.BusinessLayer.DBUtil;
using PetPals.BusinessLayer.Repository;
using PetPals.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;



public class PetShelterRepository : IPetShelterRepository
{
    private readonly DbUtil _dbUtil;

    public PetShelterRepository()
    {
        _dbUtil = new DbUtil();
    }

    // Method to add a new shelter
    public void AddShelter(PetShelter petShelter)
    {
        string query = "INSERT INTO Shelters (Name, Location) VALUES (@Name, @Location)";
        SqlParameter[] parameters = new SqlParameter[]
        {
            new SqlParameter("@Name", petShelter.Name),
            new SqlParameter("@Location", petShelter.Location)
        };

        try
        {
            _dbUtil.ExecuteNonQuery(query, parameters);
        }
        catch (SqlException ex)
        {
            Console.WriteLine($"Database error while adding shelter: {ex.Message}");
            // Log exception or handle accordingly
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while adding shelter: {ex.Message}");
            // Log exception or handle accordingly
        }
    }

    // Method to remove a shelter by ID
    public void RemoveShelter(int shelterId)
    {
        string query = "DELETE FROM Shelters WHERE ShelterID = @ShelterID";
        SqlParameter[] parameters = new SqlParameter[]
        {
            new SqlParameter("@ShelterID", shelterId)
        };

        try
        {
            _dbUtil.ExecuteNonQuery(query, parameters);
        }
        catch (SqlException ex)
        {
            Console.WriteLine($"Database error while removing shelter: {ex.Message}");
            // Log exception or handle accordingly
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while removing shelter: {ex.Message}");
            // Log exception or handle accordingly
        }
    }
}

    

   
       
   




