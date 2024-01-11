#pragma  warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace PetParty.Models;

public class Pet
{
    // public string? Name { get;set; } // we can make the string nullable if we wish the name to be optional
    // [DataType(DataType.Date)]
    [Required]
    [MinLength(2)]
    public string Name { get;set; }

    [Display(Name = "Type of Pet:")]
    [Required]
    public string Species { get;set; }

    [Required(ErrorMessage ="Plz give age")]
    public int? Age { get;set; } 
    
    public bool IsCute { get;set; }

}