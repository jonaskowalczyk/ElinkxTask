using System.ComponentModel.DataAnnotations;

namespace CustomersApi.Objects
{
    public class CustomerObject
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string Surname { get; set; }

        public int Age { get; set; }

        [MaxLength(200)]
        public string Gender { get; set; }

        [Required]
        [MaxLength(200)]
        public string Street { get; set; }

        [Required]
        [MaxLength(200)]
        public string City { get; set; }

        [Required]
        [MaxLength(200)]
        public string PostCode { get; set; }

        [Required]
        [MaxLength(200)]
        public string Email { get; set; }

        [Required]
        [MaxLength(200)]
        public string PhoneNumber { get; set; }

    }
}
