using PetPals.BusinessLayer.Repository;
using PetPals.BusinessLayer.Repository.PetPals.BusinessLayer.Repository;
using PetPals.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Display Pet Listings");
            Console.WriteLine("2. Record Donation");
            Console.WriteLine("3. View Upcoming Events");
            Console.WriteLine("4. Register");

            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayPetListings();
                    break;
                case "2":
                    RecordDonation();
                    break;
                case "3":
                    ViewUpcomingEvents();
                    break;

                case "4":
                    RegisterForEvent();
                    break;
                case "5":
                    Console.WriteLine("Exiting the program.");
                    return; // Exit the program
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private static void DisplayPetListings()
    {
        // Retrieve the connection string from App.config
        string connectionString = ConfigurationManager.ConnectionStrings["PetPalDB"].ConnectionString;

        PetRepository petRepository = new PetRepository();

        try
        {
            List<Pet> pets = petRepository.GetAllPets();
            Console.WriteLine("Available Pets:");

            if (pets.Count == 0)
            {
                Console.WriteLine("No pets available.");
                return;
            }

            foreach (Pet pet in pets)
            {
                Console.WriteLine($" Name: {pet.Name}, Age: {pet.Age}, Breed: {pet.Breed}");
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine($"Database error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
    // Method to record a donation
    private static void RecordDonation()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["PetPalDB"].ConnectionString;

        Console.Write("Enter donor's name: ");
        string donorName = Console.ReadLine();

        Console.Write("Enter donation amount: ");
        decimal donationAmount;

        // Validate donation amount input
        while (!decimal.TryParse(Console.ReadLine(), out donationAmount) || donationAmount <= 0)
        {
            Console.Write("Please enter a valid donation amount: ");
        }

        // Initialize the DonationRepository
        DonationRepository donationRepository = new DonationRepository();

        try
        {
            // Create a Donation object to pass to the repository
            Donation donation = new Donation
            {
                DonorName = donorName,
                Amount = donationAmount
            };

            // Add donation to the database
            donationRepository.AddDonation(donation); // Pass the Donation object
            Console.WriteLine("Donation recorded successfully!");
        }

        catch (SqlException ex)
        {
            Console.WriteLine($"Database error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
    private static void ViewUpcomingEvents()
    {
        AdoptionEventRepository eventRepository = new AdoptionEventRepository();
        List<AdoptionEvent> events = eventRepository.GetUpcomingEvents();

        Console.WriteLine("Upcoming Adoption Events:");
        if (events.Count == 0)
        {
            Console.WriteLine("No upcoming events found.");
            return;
        }

        foreach (var adoptionEvent in events)
        {
            Console.WriteLine($"Event ID: {adoptionEvent.}, Name: {adoptionEvent.EventName}, Date: {adoptionEvent.EventDate}, Location: {adoptionEvent.Location}");
        }
    }

    private static void RegisterForEvent()
    {
        Console.Write("Enter Event ID to register: ");
        int eventId = int.Parse(Console.ReadLine());

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your email: ");
        string email = Console.ReadLine();

        Participant participant = new Participant
        {
            EventId = eventId,
            Name = name,
            Email = email
        };

        ParticipantRepository participantRepository = new ParticipantRepository();
        participantRepository.AddParticipant(participant);

        Console.WriteLine("You have registered successfully for the event!");
    }
}

