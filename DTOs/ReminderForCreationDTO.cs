using System;

namespace Push.API.DTOs
{
    public class ReminderForCreationDTO
    {
        public DateTime ResponseTime { get; set; }
        public string Text { get; set; }
    }
}