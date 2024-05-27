namespace ELearning.Web.AppCodes
{
    public class SD // system definition
    {
        // Roles
        public const string ROLE_ADMIN = "Admin";
        public const string ROLE_INSTRUCTOR = "Instructor";
        public const string ROLE_STUDENT = "Student";

        // Course status
        public const string COURSE_PRIVATE = "Riêng tư";
        public const string COURSE_PUBLISH = "Published";
        public const string COURSE_UNPUBLISH = "Unpublished";
        public const string COURSE_PENDING_APPROVAL = "Pending approval";

        // Course request status
        public const string REQUEST_NEW = "New";
        public const string REQUEST_PENDING = "Pending";
        public const string REQUEST_APPROVED = "Approved";
        public const string REQUEST_DENIED = "Denied";
        public const string REQUEST_CANCELED = "Canceled";

        // Enrollment status
        public const string EN_ENROLLED = "Enrolled";
        public const string EN_IN_PROGRESS = "In progress";
        public const string EN_COMPLETED = "Completed";

        // Payment status
        public const string PAY_COMPLETED = "Completed";
        public const string PAY_PENDING = "Pending";
        public const string PAY_FAILED = "Failed";
        public const string PAY_CANCELED = "Canceled";
        public const string PAY_REFUNDED = "Refunded";

        // Refund request status
        public const string REFUND_NEW = "New";
        public const string REFUND_PENDING = "Pending";
        public const string REFUND_APPROVED = "Approved";
        public const string REFUND_DENIED = "Denied";
        public const string REFUND_CANCELED = "Canceled";
        public const string REFUND_COMPLETED = "Completed";
        public const string REFUND_FAILED = "Failed";

        // Lesson report status
        public const string REPORT_NEW = "New";
        public const string REPORT_PENDING = "Pending";
        public const string REPORT_RESOLVED = "Resolved";

        // Quiz attempt status
    }
}
