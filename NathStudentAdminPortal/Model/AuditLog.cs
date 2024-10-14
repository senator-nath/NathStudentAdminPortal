using System;

namespace NathStudentAdminPortal.Model
{
    public class AuditLog
    {
        public int AuditLogId { get; set; }
        public string Action { get; set; }
        public string Entity { get; set; }
        public DateTime ActionDate { get; set; }
        public string PerformedByAdminId { get; set; }
        public Admin PerformedBy { get; set; }
        public string Details { get; set; }
    }
}
