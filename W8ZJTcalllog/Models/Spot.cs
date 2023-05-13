using MessagePack;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace W8ZJTcalllog.Models
{
    [Index(nameof(time), nameof(band))]
    [Index(nameof(freq))]
    [Index(nameof(dxcall))]
    [Index(nameof(band))]
    public class Spot
    {
        [System.ComponentModel.DataAnnotations.Key] [Column(TypeName = "bigint")] public int nr { get; set; }
        [StringLength(12)] public string call { get; set; } = string.Empty;
        [Column(TypeName = "float")] public double freq { get; set; }
        [StringLength(12)] public string dxcall { get; set; } = string.Empty;
        [StringLength(30)] public string comment { get; set; } = string.Empty;
        public DateTime time { get; set; }
        [Column(TypeName = "float")] public double band { get; set; }
        [Column("dx_prefix")] [StringLength(10)] public string DxPrefix { get; set; } = string.Empty;
        [Column("dx_name")][StringLength(100)] public string DxName { get; set; } = string.Empty;
        [Column("dx_cqz")][StringLength(100)] public string DxCqz { get; set; } = string.Empty;
        [Column("dx_ituz")][StringLength(100)] public string DxItuz { get; set; } = string.Empty;
        [Column("dx_cont")][StringLength(5)] public string DxCont { get; set; } = string.Empty;
        [Column("dx_long")][StringLength(100)] public string DxLong { get; set; } = string.Empty;
        [Column("dx_lat")][StringLength(100)] public string DxLat { get; set; } = string.Empty;
        [Column("spotter_prefix")][StringLength(10)] public string SpotterPrefix { get; set; } = string.Empty;
        [Column("spotter_name")][StringLength(150)] public string SpotterName { get; set; } = string.Empty;
        [Column("spotter_cqz")][StringLength(100)] public string SpotterCqz { get; set; } = string.Empty;
        [Column("spotter_ituz")][StringLength(100)] public string SpotterItuz { get; set; } = string.Empty;
        [Column("spotter_cont")][StringLength(5)] public string  SpotterCont { get; set; } = string.Empty;
        [Column("spotter_long")][StringLength(100)] public string SpotterLong { get; set; } = string.Empty;
        [Column("spotter_lat")][StringLength(100)] public string SpotterLat { get; set; } = string.Empty;
    }
}
