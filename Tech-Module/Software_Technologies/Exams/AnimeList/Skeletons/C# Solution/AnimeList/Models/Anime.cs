﻿using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace AnimeList.Models
{
    public class Anime
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [AllowHtml]
        public int Rating { get; set; }
        [Required]
        [AllowHtml]
        public string Name { get; set; }
        [Required]
        [AllowHtml]
        public string Description { get; set; }
        [Required]
        [AllowHtml]
        public string Watched { get; set; }
    }
}