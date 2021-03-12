
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcoSystemAPI.Dtos
{
    public class ArticleUpdateDto
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
    }
}
