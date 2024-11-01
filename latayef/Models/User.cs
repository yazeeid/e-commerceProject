﻿namespace latayef.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }

        // Relationships
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
        public virtual Cart Cart { get; set; }
        public virtual ICollection<ProductReview> ProductReviews { get; set; } = new List<ProductReview>();
        public virtual ICollection<Testimonial> Testimonials { get; set; } = new List<Testimonial>();
    }

}
