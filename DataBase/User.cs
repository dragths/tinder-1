using System.ComponentModel.DataAnnotations;

namespace tinder_1.Models
{
    public class User
    {
       
        public int Id { get; set; }
        public required string Login { get; set; }
        public required string Password { get; set; }
    }
}
