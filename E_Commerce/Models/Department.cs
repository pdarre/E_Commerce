namespace E_Commerce.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage ="The field {0} is required.")]
        [MaxLength(50,ErrorMessage = "The {0} must be maximun {1} character length")]
        [Display(Name="Department")]
        public String Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}