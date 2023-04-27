
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace W8ZJTcalllog.Models
{
    public class HamLog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        [JsonIgnore] public virtual User? User { get; set; }
        [StringLength(30)] public string? FccId { get; set; }
        [StringLength(30)] public string Callsign { get; set; } = string.Empty;
        [StringLength(30)] public string? AltCallsign { get; set; }
        [StringLength(30)] public string? CallModifier { get; set; }
        [StringLength(30)] public string? Reciprical { get; set; }
        [StringLength(50)] public string? Frequency { get; set; }
        [StringLength(5)] public string? Mode { get; set; }
        [StringLength(5)] public string? RSTsent { get; set; }
        [StringLength(5)] public string? RSTrec { get; set; }
        public int? band { get; set; }
        public int? Power { get; set; }
        [StringLength(30)] public string FirstName { get; set; } = string.Empty;
        [StringLength(30)] public string? LastName { get; set; }
        [StringLength(100)] public string? FullName { get; set; }
        [StringLength(40)] public string? Country { get; set; } = "United States";
        [StringLength(40)] public string? City { get; set; }
        [StringLength(2)] public string? State { get; set; }
        [StringLength(10)] public string? PostalCode { get; set; }
        [StringLength(100)] public string? Address { get; set; }
        [StringLength(255)] public string? Comments { get; set; }
        public string? QTH { get; set; }
        public int LogCount { get; set; } = 0;
        public DateTime? DateAndTime { get; set; }
        public DateTime? TimeOff { get; set; }

        public HamLog() { }
    }
}
