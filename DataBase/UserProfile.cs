using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tinder_1.Models
{
    public class UserProfile
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }  

        public virtual User User { get; set; }
        public string Name { get; set; }
        public int? GenderId { get; set; }
        public virtual Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public int? CityId { get; set; }
        public virtual City City { get; set; }
        public string PhotoPath { get; set; }
        public int? HobbyId { get; set; }
        public virtual Hobby Hobby { get; set; }
        public int? MusicGenreId { get; set; }
        public virtual MusicGenre MusicGenre { get; set; }
        public int? FilmGenreId { get; set; }
        public virtual FilmGenre FilmGenre { get; set; }
        public int? BadHabitsAttitudeId { get; set; }
        public virtual BadHabitsAttitude BadHabitsAttitude { get; set; }
        public string? AboutMe { get; set; }
    }
}