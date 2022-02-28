using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GlobalATM.Models
{
    public class LogUser
    {
    [NotMapped]

    [Required]
    [RegularExpression(@"^[\w!#$%&'+-/=?^_`{|}~]+(.[\w!#$%&'+-/=?^_`{|}~]+)*" + "@" + @"((([-\w]+.)+[a-zA-Z]{2,4})|(([0-9]{1,3}.){3}[0-9]{1,3}))\z")]
    [EmailAddress]
    public string LoginEmail {get; set;}

    [DataType(DataType.Password)]
    [Required]
    [MinLength(4, ErrorMessage="Must be 4 characters or longer!")]
    public string LoginPin {get; set;}
    }
}