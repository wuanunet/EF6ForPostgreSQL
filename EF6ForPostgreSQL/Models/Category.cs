using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF6ForPostgreSQL.Models
{
    public class Category
    {
        public Category()
        {
            this.Category1 = new HashSet<Category>();
        }

        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Category2")]
        public Guid? ParentId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Category> Category1 { get; set; }

        public virtual Category Category2 { get; set; }
    }
}