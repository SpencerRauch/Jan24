#pragma  warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace PetParty.Models;

public class Pet
{
    // public string? Name { get;set; } // we can make the string nullable if we wish the name to be optional
    // [DataType(DataType.Date)]
    [Required]
    [NoZNames]
    [MinLength(2)]
    public string Name { get;set; }

    [Display(Name = "Type of Pet:")]
    [Required]
    // [Options]
    [ProvidedOptions("Bear","Deer","Bobcat")]
    public string Species { get;set; }

    [Required(ErrorMessage ="Plz give age")]
    [Range(1, int.MaxValue)]
    public int? Age { get;set; } 
    
    public bool IsCute { get;set; }

}

public class NoZNamesAttribute : ValidationAttribute
{    
    // Call upon the protected IsValid method
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)    
    {   
        // We are expecting the value coming in to be a string
        // so we need to do a bit of type casting to our object
        // Strings work similarly to arrays under the hood 
        // so we can grab the first letter using its index   
        // If we discover that the first letter of our string is z...  
        if (value == null || ((string)value).ToLower()[0] == 'z')
        {        
            // we return an error message in ValidationResult we want to render    
            return new ValidationResult("No names that start with Z allowed!");   
        } else {   
            // Otherwise, we were successful and can report our success  
            return ValidationResult.Success;  
        }  
    }
}

public class OptionsAttribute : ValidationAttribute
{    

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)    
    {   
        string[] ValidOptions = ["Dog","Fish","Cat"]; // this should probably be populated from the db
        if (value == null || !ValidOptions.Contains((string)value))
        {        
            return new ValidationResult("please choose a valid option for pet type");   
        } else {   

            return ValidationResult.Success;  
        }  
    }
}

public class ProvidedOptionsAttribute : ValidationAttribute
{   
    public string[]? Options { get;set; }

    public ProvidedOptionsAttribute(params string[] options)
    {
        Options = options;
    }

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)    
    {   
        if (value == null || !Options.Contains((string)value))
        {        
            return new ValidationResult("please choose a valid option for pet type");   
        } else {   

            return ValidationResult.Success;  
        }  
    }
}