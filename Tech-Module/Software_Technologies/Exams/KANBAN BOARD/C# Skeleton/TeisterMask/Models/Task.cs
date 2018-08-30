using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace TeisterMask.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [AllowHtml]
        public string Title { get; set; }
        [Required]
        [AllowHtml]
        public string Status { get; set; }
    }
}