using System;

namespace VehicleCategoriesWithEnums
{
    enum Category
    {
        Fighter,
        Car,
        PublicTransport,
        Sports,
        Exit
    }

    enum FighterSubCategory
    {
        Tank,
        IFV,
        APC
    }

    enum CarSubCategory
    {
        Sedan,
        SUV,
        Bike,
        Motorcycle
    }

    enum PublicTransportSubCategory
    {
        Bus,
        Tramway
    }

    enum SportsSubCategory
    {
        F1,
        Rally,
        Offroad
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose a category to create a vehicle:");
                Console.WriteLine("0. Fighter (Tank, IFV, APC");
                Console.WriteLine("1. Car (Sedan, SUV, Bike, Motorcycle)");
                Console.WriteLine("2. Public Transport (Bus, Tramway)");
                Console.WriteLine("3. Sports (F1, Rally, Offroad)");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                Category selectedCategory = (Category)choice;

                switch (selectedCategory)
                {
                    case Category.Fighter:
                        CreateFighter();
                        break;
                    case Category.Car:
                        CreateCar();
                        break;
                    case Category.PublicTransport:
                        CreatePublicTransport();
                        break;
                    case Category.Sports:
                        CreateSports();
                        break;
                    case Category.Exit:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }

        static void CreateFighter()
        {
            Console.WriteLine("Choose a fighter sub-category:");
            Console.WriteLine("0. Tank");
            Console.WriteLine("1. IFV (Infantry Fighting Vehicle)");
            Console.WriteLine("2. APC (Armored Personnel Carrier)");
            Console.Write("Enter your choice: ");

            int subChoice = int.Parse(Console.ReadLine());

            FighterSubCategory selectedSubCategory = (FighterSubCategory)subChoice;

            Console.WriteLine($"Created a Fighter vehicle: {selectedSubCategory}");
        }

        static void CreateCar()
        {
            Console.WriteLine("Choose a car sub-category:");
            Console.WriteLine("0. Sedan");
            Console.WriteLine("1. SUV");
            Console.WriteLine("2. Bike");
            Console.WriteLine("3. Motorcycle");
            Console.Write("Enter your choice: ");

            int subChoice = int.Parse(Console.ReadLine());

            CarSubCategory selectedSubCategory = (CarSubCategory)subChoice;

            Console.WriteLine($"Created a Car vehicle: {selectedSubCategory}");
        }

        static void CreatePublicTransport()
        {
            Console.WriteLine("Choose a public transport sub-category:");
            Console.WriteLine("0. Bus");
            Console.WriteLine("1. Tramway");
            Console.Write("Enter your choice: ");

            int subChoice = int.Parse(Console.ReadLine());

            PublicTransportSubCategory selectedSubCategory = (PublicTransportSubCategory)subChoice;

            Console.WriteLine($"Created a Public Transport vehicle: {selectedSubCategory}");
        }

        static void CreateSports()
        {
            Console.WriteLine("Choose a sports sub-category:");
            Console.WriteLine("0. F1");
            Console.WriteLine("1. Rally");
            Console.WriteLine("2. Offroad");
            Console.Write("Enter your choice: ");

            int subChoice = int.Parse(Console.ReadLine());

            SportsSubCategory selectedSubCategory = (SportsSubCategory)subChoice;

            Console.WriteLine($"Created a Sports vehicle: {selectedSubCategory}");
        }
    }
}
