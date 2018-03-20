using System.IO;

namespace TimeSheetManager.Models
{
    public class SavedFile
    {
        public long Id { get; set; }
        public FileInfo fileInfo { get; set; }
        // Navigation Properties
        public virtual TimeSheetExportHistory timeSheetExportHistory { get; set; }
    }
}
