using Microsoft.AspNetCore.Identity;
using Display = System.ComponentModel.DataAnnotations.DisplayAttribute;

namespace AppForSEII.API.Models;

// Add profile data for application users by adding properties to the ApplicationUser class

    //Title is unique for each instance of Movie
    [Index(nameof(Name), IsUnique = true)]
    public class Genre
    {
        /*public Genre()
        {
        }

        public Genre(string name)
        {
            Name = name;
        } */

        public int Id { get; set; }

        [StringLength(20, ErrorMessage ="Name of Genre can be neither longer than 20 characters nor shorter than 1", MinimumLength =1)]
        //public string Name { get; set; }
        	//alternative implementation for Name
	private string name;
	public string Name
	{
		get {return name;}
		//name Will be always uppercase
		set {name= value.ToUpper();}
	}


        //it assigns a value by default
        ///public IList<Movie> Movies { get; set; } = new List<Movie>();

    }

