using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace laba7.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string City { get; set; }

        public User (int Id, string Name, int Age, DateTime Birthday, string Phone, string Email, string City)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
            this.Birthday = Birthday;
            this.Phone = Phone;
            this.Email = Email;
            this.City = City;
        }
    }
}
