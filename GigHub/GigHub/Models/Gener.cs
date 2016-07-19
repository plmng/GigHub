namespace GigHub.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Gener
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}