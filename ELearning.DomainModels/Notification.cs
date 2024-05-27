using ELearning.DomainModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DomainModels
{
    public enum NotificationTypes
    {
        StudentEnrolled = 1,
        CoursePublished = 2,
        Report = 3,
        ReportResult = 4,
    }

    public class Notification
    {
        public int NotificationId { get; set; }
        public int UserId { get; set; }
        public string Message { get; set; }
        public NotificationTypes NotificationType { get; set; }
        public DateTime CreatedAt { get; set; }

        // relationships
        public ApplicationUser User { get; set; }

    }
}
