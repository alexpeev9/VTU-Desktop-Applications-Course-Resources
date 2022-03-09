namespace DailyTasksApplication.Database.Models.Abstractions
{
    using System.ComponentModel.DataAnnotations;
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
    }
}
