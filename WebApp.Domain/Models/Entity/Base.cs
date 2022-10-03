using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebApp.Domain.Models.Entity
{
    public class Base
    {
        [Key]
        public int? Id { get; set; }
    }
}
