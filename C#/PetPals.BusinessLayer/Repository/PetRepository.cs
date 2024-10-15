using PetPals.BusinessLayer.DBUtil;
using PetPals.BusinessLayer.Repository;
using PetPals.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PetPals.BusinessLayer.Exceptions;
public class PetRepository : IPetRepository
{
    private readonly DbUtil _dbUtil;

    public PetRepository()
    {
        _dbUtil = new DbUtil();
    }

    // Method to add a pet
    public void AddPet(Pet pet)
    {
        // Check for valid pet age
        if (pet.Age <= 0)
        {
            throw new InvalidPetAgeException("Pet age must be a positive integer.");
        }

        string query = "INSERT INTO Pets (Name, Age, DogBreed, CatColor) VALUES (@Name, @Age, @DogBreed, @CatColor)";

        SqlParameter[] parameters = new SqlParameter[]
        {
            new SqlParameter("@Name", pet.Name),
            new SqlParameter("@Age", pet.Age),
            new SqlParameter("@DogBreed", pet is Dog dog ? (object)dog.DogBreed : DBNull.Value),
            new SqlParameter("@CatColor", pet is Cat cat ? (object)cat.CatColor : DBNull.Value)
        };

        _dbUtil.ExecuteNonQuery(query, parameters);
    }

    // Method to get all pets
    public List<Pet> GetAllPets()
    {
        List<Pet> pets = new List<Pet>();
        string query = "SELECT Name, Age, DogBreed, CatColor FROM Pets";

        DataTable dataTable = _dbUtil.ExecuteQuery(query);

        foreach (DataRow row in dataTable.Rows)
        {
            Pet pet;
            try
            {
                if (row["DogBreed"] != DBNull.Value)
                {
                    pet = new Dog
                    {
                        Name = row["Name"].ToString(),
                        Age = Convert.ToInt32(row["Age"]),
                        DogBreed = row["DogBreed"].ToString()
                    };
                }
                else if (row["CatColor"] != DBNull.Value)
                {
                    pet = new Cat
                    {
                        Name = row["Name"].ToString(),
                        Age = Convert.ToInt32(row["Age"]),
                        CatColor = row["CatColor"].ToString()
                    };
                }
                else
                {
                    continue; // Skip this row if no valid pet type is found
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Error accessing pet properties: {ex.Message}");
                continue; // Skip this row if any property is null
            }

            pets.Add(pet);
        }

        return pets;
    }

    // Method to remove a pet by ID
    public void RemovePet(int petId)
    {
        string query = "DELETE FROM Pets WHERE PetId = @PetId";
        SqlParameter[] parameters = new SqlParameter[]
        {
            new SqlParameter("@PetId", petId)
        };

        _dbUtil.ExecuteNonQuery(query, parameters);
    }

   
    
}