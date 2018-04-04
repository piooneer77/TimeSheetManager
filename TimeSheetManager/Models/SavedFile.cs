using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace TimeSheetManager.Models
{
    public class SavedFile
    {
        public long Id { get; set; }
        //public FileInfo fileInfo { get; set; }
        // Navigation Properties
        [ForeignKey("TimeSheetExportHistory")]
        public long exportHistoryId { get; set; }
        public virtual TimeSheetExportHistory timeSheetExportHistory { get; set; }
    }
}
