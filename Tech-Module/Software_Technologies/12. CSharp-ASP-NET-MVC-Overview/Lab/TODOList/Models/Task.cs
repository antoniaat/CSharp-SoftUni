﻿using System.ComponentModel.DataAnnotations;
using System.Dynamic;

namespace TODOList.Models
{
    public class Task
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

    }
}