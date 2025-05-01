using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tinder_1.Models
{
   
    public class Gender
    {
        public int Id { get; set; }
        public required string Name { get; set; }
    }
}