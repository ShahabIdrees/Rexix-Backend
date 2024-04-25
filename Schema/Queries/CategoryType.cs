using System;

namespace RexixBackend.Schema.Queries
{

    public enum Category
    {
        // Product Categories (same as before)
        BooksMoviesTv,
        Electronics,
        ClothingShoesJewelry,
        HomeKitchen,
        BeautyPersonalCare,
        SportsOutdoorsFitness,
        ToysGames,
        Baby,
        GroceryGourmetFood,
        PetSupplies,
        ToolsHardware,
        IndustrialScientific,
        DigitalProducts,

        // Local Business Categories
        RestaurantsFood,  // Merged LocalBusiness_RestaurantsFood subcategories
        RetailStores,    // Merged LocalBusiness_RetailStores subcategories
        ProfessionalServices,  // Merged LocalBusiness_ProfessionalServices subcategories
        HomeServices,    // Merged LocalBusiness_HomeServices subcategories
        HealthWellness,  // Merged LocalBusiness_HealthWellness subcategories
        Entertainment,    // Merged LocalBusiness_Entertainment subcategories
        Automotive,      // Merged LocalBusiness_Automotive subcategories
        Education,       // Merged LocalBusiness_Education subcategories
        Accommodation,   // Merged LocalBusiness_Accommodation subcategories

        // Service Categories
        Financial,        // Merged Service_Financial subcategories
        TravelTransportation, // Merged Service_TravelTransportation subcategories
        Streaming,         // Merged Service_Streaming subcategories
        Subscription,      // Merged Service_Subscription subcategories
        Delivery,         // Merged Service_Delivery subcategories
        Professional,     // Kept separate from LocalBusiness
        Pet,               // Merged Service_Pet subcategories
        EventPlanning,    // Merged Service_EventPlanning subcategories
        Personal         // Merged Service_Personal subcategories
    }
    public class CategoryType
    {
        public Guid Id { get; } = Guid.NewGuid();

    }
}