using System;
using Microsoft.EntityFrameworkCore;
using TimeSheetManager.Models;

namespace TimeSheetManager.Utilities
{
    public class TimeSheetGenericRepository
    {
        #region Member Variables
        protected DbContext databaseContext = null;
        private GenericRepository<User> userRepository;
        private GenericRepository<Project> projectRepository;
        private GenericRepository<ProjectTimelineHistory> projectTimeLineHistoryRepository;
        private GenericRepository<SavedFile> savedFileRepository;
        private GenericRepository<TimeSheetEntry> timeSheetEntryRepository;
        private GenericRepository<TimeSheetExportHistory> timeSheetExportHistoryRepository;
        #endregion

        #region Constructors
        public TimeSheetGenericRepository()
        {
            databaseContext = new GenericContext();
        }
        #endregion

        #region Properties
        public GenericRepository<User> UserRepository
        {
            get
            {
                if (this.userRepository != null)
                {
                    return this.userRepository;
                }
                else
                {
                    this.userRepository = new GenericRepository<User>(databaseContext);
                    return this.userRepository;
                }   
            }
        }

        public GenericRepository<Project> ProjectRepository
        {
            get
            {
                if (this.projectRepository != null)
                {
                    return this.projectRepository;
                } 
                else
                {
                    this.projectRepository = new GenericRepository<Project>(this.databaseContext);
                    return this.projectRepository;
                }
            }
        }

        public GenericRepository<TimeSheetEntry> TimeSheetEntryRepository
        {
            get
            {
                if (this.timeSheetEntryRepository != null)
                {
                    return this.timeSheetEntryRepository;
                }
                else
                {
                    this.timeSheetEntryRepository = new GenericRepository<TimeSheetEntry>(this.databaseContext);
                    return this.timeSheetEntryRepository;
                }
            }
        }

        public GenericRepository<SavedFile> SavedFileRepository
        {
            get
            {
                if (this.savedFileRepository != null)
                {
                    return this.savedFileRepository;
                }
                else
                {
                    this.savedFileRepository = new GenericRepository<SavedFile>(this.databaseContext);
                    return this.savedFileRepository;
                }
            }
        }

        public GenericRepository<TimeSheetExportHistory> TimeSheetExportHistoryRepository
        {
            get
            {
                if (this.timeSheetExportHistoryRepository != null)
                {
                    return this.timeSheetExportHistoryRepository;
                }
                else
                {
                    this.timeSheetExportHistoryRepository = new GenericRepository<TimeSheetExportHistory>(this.databaseContext);
                    return this.timeSheetExportHistoryRepository;
                }
            }
        }

        public GenericRepository<ProjectTimelineHistory> ProjectTimelineHistoryRepository
        {
            get
            {
                if (this.projectTimeLineHistoryRepository != null)
                {
                    return this.projectTimeLineHistoryRepository;
                }
                else
                {
                    this.projectTimeLineHistoryRepository = new GenericRepository<ProjectTimelineHistory>(this.databaseContext);
                    return this.projectTimeLineHistoryRepository;
                }
            }
        }
        #endregion

        #region Methods
        public int Save()
        {
            try
            {
                return databaseContext.SaveChanges();   
            }
            catch (Exception exception)
            {
                throw;
            }
        }
        #endregion

    }
}
