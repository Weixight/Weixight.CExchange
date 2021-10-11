using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Weixight.CExchange.AgricGator.Models
{
    public class Cartegory
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Category Name")]

        public string Name { get; set; }
        [Display(Name = "Description")]

        public string Dsc { get; set; }
        [Display(Name = "Meta Date")]

        public string MetaData { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
