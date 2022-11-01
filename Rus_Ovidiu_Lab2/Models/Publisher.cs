﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Rus_Ovidiu_Lab2.Models
{
    public class Publisher
    {
        public int ID { get; set; }

        [Display(Name = "Publisher Name")]
        public string PublisherName { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
