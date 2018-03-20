using System;

namespace TimeSheetManager.Models
{
    public class ProjectTimelineHistory
    {
        public long Id { get; set; }
        public TimeSpan startedFrom { get; set; }
        public TimeSpan? stoppedOn { get; set; }
        // Navigation Properties
        public long projectId { get; set; }
        public virtual Project project { get; set; }
    }
}
