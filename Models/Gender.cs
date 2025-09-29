using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public enum Gender
    {
        [Display(Name = "Nam")]
        Male,
        [Display(Name = "Nữ")]
        Female
    }
}
