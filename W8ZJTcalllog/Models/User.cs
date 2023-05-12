using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace W8ZJTcalllog.Models
{
    [Index("UserName", IsUnique = true)]
    public class User
    {
        public int Id { get; set; }
        public bool IsAdmin { get; set; }
        public bool showNetColumn { get; set; }
        public bool showAddressColumn { get; set; }
        [StringLength(50)] public string FirstName { get; set; } = string.Empty;
        [StringLength(50)] public string LastName { get; set; } = string.Empty;
        [StringLength(30)] public string UserName { get; set; } = string.Empty;
        [StringLength(100)] public string Password { get; set; } = string.Empty;
        [StringLength(30)] public string Callsign { get; set; } = string.Empty;
        [StringLength(255)] public string? Email { get; set; }
        [StringLength(255)] public string? Address { get; set; }
        [StringLength(255)] public string? Style { get; set; }
        [StringLength(255)] public string? LogMode { get; set; }
        public int NumberOfCallsToShow { get; set; } = 10;
        public int PriviousCallsToShow { get; set; } = 10;
        [StringLength(4)] public string? DefaultMode { get; set; } = "LSB";
        [StringLength(4)] public string? LastWorkedMode { get; set; }
        public int DefaultPower { get; set; } = 100;
        public int LastWorkedPower { get; set; }
        public int RecordCount { get; set; } = 0;
        [StringLength(20)] public string Status { get; set; } = "NEW";
        public virtual ICollection<HamLog>? HamLogs { get; set; }
    }
}
