﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Redis.Model
{
    public class ArticleMatrix
    {
        public int Id { get; set; }
        public string AuthorId { get; set; }
        public string Author { get; set; }
        public string Link { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public string Views { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal ViewsCount { get; set; }
        public int Likes { get; set; }
        public DateTime PubDate { get; set; }
    }
}
