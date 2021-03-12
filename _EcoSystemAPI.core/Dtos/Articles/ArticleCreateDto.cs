using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcoSystemAPI.Dtos
{
    public class ArticleCreateDto
    {
        [Required]
        public string AuthorName { get; set; }
        [Required]
        public string AuthorImg { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string DateofPublish { get; set; }
        [Column(TypeName = "varchar(MAX)")]
        [Required]
        public string Image { get; set; }
        [Required]
        public string Content { get; set; }
    }
}
