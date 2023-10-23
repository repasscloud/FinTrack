using System.ComponentModel.DataAnnotations;

namespace FinTrack.Models.Clients
{
	public class BasicClient
	{
		[Key]
		public int Id { get; set; }

		[MaxLength(128)]
		public string EntityName { get; set; } = null!;

        [RegularExpression(@"^$|^\d{11}$", ErrorMessage = "ABN must be empty or 11 digits.")]
        public string? ABN { get; set; }

        [RegularExpression(@"^$|^\d{9}$", ErrorMessage = "ACN must be empty or 9 digits.")]
        public string? ACN { get; set; }

        [Required]
        [StringLength(128)]
        [MinLength(2, ErrorMessage = "Director's Name must be at least 2 characters.")]
        public string DirectorsName { get; set; } = null!;

    }
}

