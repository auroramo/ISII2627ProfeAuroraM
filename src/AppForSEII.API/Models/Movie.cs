using Microsoft.AspNetCore.Identity;
using Display = System.ComponentModel.DataAnnotations.DisplayAttribute;

namespace AppForSEII.API.Models;

// Add profile data for application users by adding properties to the ApplicationUser class
public class Movie
{
    public int Id { get; set; }


        [StringLength(50, ErrorMessage = "Title name cannot be longer than 50 characters.")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")] //Expresión regular: Comienza con letras mayúsculas y puede contener espacios y guiones.
        public string Title { get; set; }  //Title no es nulo

        [StringLength(100, ErrorMessage = "Description cannot be longer than 100 characters.")] 
        public string? Description {get;set;}


        [DataType(System.ComponentModel.DataAnnotations.DataType.Currency)]
        [Range(0.5, float.MaxValue, ErrorMessage = "Minimum price is 0.5 ")]
        [Display(Name = "Price For Purchase")]
        [Precision(10, 2)]
        public decimal PriceForPurchase { get; set; }


        [Display(Name = "Quantity For Purchase")]
        [Range(0, int.MaxValue, ErrorMessage = "Minimum quantity for Purchase is 1")]
        public int QuantityForPurchase { get; set; }

        //public Genre Genre { get; set; }

        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }


        [DataType(System.ComponentModel.DataAnnotations.DataType.Currency)]
        [Range(0.5, 100, ErrorMessage = "Minimum is 0.5 and maximum 100")]
        [Display(Name = "Price For Renting")]
        public double PriceForRenting { get; set; }



        [Display(Name = "Quantity For Renting")]
        [Range(1, int.MaxValue, ErrorMessage = "Minimum quantity for renting is 1")]
        public int QuantityForRenting { get; set; }

        ////public IList<RentalItem> RentalItems { get; set; }
}