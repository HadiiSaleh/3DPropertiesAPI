using _3DPropertiesAPI.Data;
using _3DPropertiesAPI.Models;

namespace _3DPropertiesAPI.Services
{
    public class ExceptionsLoggerService
    {
        private readonly ApplicationDbContext _db;

        public ExceptionsLoggerService(ApplicationDbContext db)
        {
            _db = db;
        }

        public void saveExceptionLog(string UserId, string Source, string Message)
        {
            ExceptionLog log = new ExceptionLog
            {
                UserId = UserId,
                Source = Source,
                Message = Message
            };

            _db.ExceptionLogs.Add(log);
            _db.SaveChanges();
        }
    }
}
