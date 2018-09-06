namespace E_Commerce.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Required(ErrorMessage = "The field {0} is required.")]
        [MaxLength(50, ErrorMessage = "The {0} must be maximun {1} character length")]
        [Display(Name = "City")]
        public String Name { get; set; }

        [Required(ErrorMessage = "The field {0} is required.")]
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
    }
}