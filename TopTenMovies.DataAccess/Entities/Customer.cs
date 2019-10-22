using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TopTenMovies.DataAccess.Entities
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Orders>();
        }

        public int CustomerId { get; set; }

        [Required(ErrorMessage = "First Name is Required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        public string LastName { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
