namespace DailyTasksApplication.Database.Models
{
    using DailyTasksApplication.Database.Models.Abstractions;

    using System;
    public class Task : BaseModel
    {
        public Task()
        {
            this.IsDone = false;
            this.CreatedAt = DateTime.UtcNow;
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
