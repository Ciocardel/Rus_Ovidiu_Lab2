﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Rus_Ovidiu_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Display(Name = "Book title")]
        public string Title { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get; set;  }
        public Publisher? Publisher { get; set;  }

        public int? AuthorID { get; set; }
        public Author? Author { get; set; }

    }
}
