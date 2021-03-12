﻿ using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EcoSystemAPI.core.Dtos.Teams
{
    public class TeamsUpdateDto
    {

        public string TeamsImage { get; set; }
        [Required]
        public string TeamsName { get; set; }
        [Required]
        public string TeamsRole { get; set; }
        [Required]
        public string TeamsDetails { get; set; }
        public string TeamsFacebook { get; set; }
        public string TeamsInstagram { get; set; }
        public string TeamsTwitter { get; set; }
    }
}
