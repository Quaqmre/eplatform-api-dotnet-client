
namespace ePlatform.eBelge.Api.Models.Models.Enums
{
    public enum TaskStatus
    {
        //Test = 0,     
        Waiting = 1,   //Veritabanında kayıt Edildi.
        Queued = 2,  // Add Task
        Running = 3, // Çalışıyor
        Failed = 4,
        Succeed = 5,
        Deleted = 6
    }
}
