using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.API.Models
{
    public abstract class BaseDto
    {
        [Required]
        public int Id { get; set; }
    }
}
