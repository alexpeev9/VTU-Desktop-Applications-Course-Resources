namespace DailyTasksApplication.Database.Models
{
    using Abstractions;

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class User : BaseModel
    {
        public User()
        {
            this.CreatedAt = DateTime.UtcNow;
            this.Tasks = new HashSet<Task>();
        }

        [Required]
        public string Username { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        public string Salt { get; set; }

        public DateTime CreatedAt { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}
