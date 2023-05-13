﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using W8ZJTcalllog.Models;

#nullable disable

namespace W8ZJTcalllog.Migrations
{
    [DbContext(typeof(FccAmateurContext))]
    [Migration("20230513175059_fixed case of column names in spots")]
    partial class fixedcaseofcolumnnamesinspots
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_0900_ai_ci")
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");

            modelBuilder.Entity("W8ZJTcalllog.Models.Am", b =>
                {
                    b.Property<int>("Fccid")
                        .HasColumnType("int")
                        .HasColumnName("fccid");

                    b.Property<string>("Callsign")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("callsign");

                    b.Property<string>("Class")
                        .HasMaxLength(1)
                        .HasColumnType("varchar(1)")
                        .HasColumnName("class");

                    b.Property<string>("Col4")
                        .HasMaxLength(1)
                        .HasColumnType("varchar(1)")
                        .HasColumnName("col4");

                    b.Property<string>("Col5")
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)")
                        .HasColumnName("col5");

                    b.Property<string>("Col6")
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)")
                        .HasColumnName("col6");

                    b.Property<string>("FormerCall")
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("former_call");

                    b.Property<string>("FormerClass")
                        .HasMaxLength(1)
                        .HasColumnType("varchar(1)")
                        .HasColumnName("former_class");

                    b.HasKey("Fccid")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Callsign" }, "idx_callsign");

                    b.HasIndex(new[] { "Class" }, "idx_class");

                    b.ToTable("am", (string)null);
                });

            modelBuilder.Entity("W8ZJTcalllog.Models.En", b =>
                {
                    b.Property<int>("Fccid")
                        .HasColumnType("int")
                        .HasColumnName("fccid");

                    b.Property<string>("Address1")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("address1");

                    b.Property<string>("Callsign")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("callsign");

                    b.Property<string>("City")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("city");

                    b.Property<string>("First")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("first");

                    b.Property<string>("FullName")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("full_name");

                    b.Property<string>("Last")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("last");

                    b.Property<string>("Middle")
                        .HasMaxLength(1)
                        .HasColumnType("varchar(1)")
                        .HasColumnName("middle");

                    b.Property<string>("State")
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)")
                        .HasColumnName("state");

                    b.Property<string>("Zip")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("zip");

                    b.HasKey("Fccid")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Callsign" }, "idx_callsign")
                        .HasDatabaseName("idx_callsign1");

                    b.HasIndex(new[] { "Zip" }, "idx_zip");

                    b.ToTable("en", (string)null);
                });

            modelBuilder.Entity("W8ZJTcalllog.Models.HamLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("AltCallsign")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("CallModifier")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Callsign")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("City")
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Comments")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Country")
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<DateTime?>("DateAndTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FccId")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Frequency")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FullName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("LastName")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<int>("LogCount")
                        .HasColumnType("int");

                    b.Property<string>("Mode")
                        .HasMaxLength(5)
                        .HasColumnType("varchar(5)");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<int?>("Power")
                        .HasColumnType("int");

                    b.Property<string>("QTH")
                        .HasColumnType("longtext");

                    b.Property<string>("RSTrec")
                        .HasMaxLength(5)
                        .HasColumnType("varchar(5)");

                    b.Property<string>("RSTsent")
                        .HasMaxLength(5)
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Reciprical")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<bool>("RstRecbool")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("RstSentbool")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("State")
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.Property<DateTime?>("TimeOff")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("band")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("HamLogs");
                });

            modelBuilder.Entity("W8ZJTcalllog.Models.Hd", b =>
                {
                    b.Property<int>("Fccid")
                        .HasColumnType("int")
                        .HasColumnName("fccid");

                    b.Property<string>("Callsign")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("callsign");

                    b.Property<string>("Status")
                        .HasMaxLength(1)
                        .HasColumnType("varchar(1)")
                        .HasColumnName("status");

                    b.HasKey("Fccid")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Callsign" }, "idx_callsign")
                        .HasDatabaseName("idx_callsign2");

                    b.HasIndex(new[] { "Status" }, "idx_status");

                    b.ToTable("hd", (string)null);
                });

            modelBuilder.Entity("W8ZJTcalllog.Models.Spot", b =>
                {
                    b.Property<long>("nr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("DxCont")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("varchar(5)")
                        .HasColumnName("dx_cont");

                    b.Property<string>("DxCqz")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("dx_cqz");

                    b.Property<string>("DxItuz")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("dx_ituz");

                    b.Property<string>("DxLat")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("dx_lat");

                    b.Property<string>("DxLong")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("dx_long");

                    b.Property<string>("DxName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("dx_name");

                    b.Property<string>("DxPrefix")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("dx_prefix");

                    b.Property<string>("SpotterCont")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("varchar(5)")
                        .HasColumnName("spotter_cont");

                    b.Property<string>("SpotterCqz")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("spotter_cqz");

                    b.Property<string>("SpotterItuz")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("spotter_ituz");

                    b.Property<string>("SpotterLat")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("spotter_lat");

                    b.Property<string>("SpotterLong")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("spotter_long");

                    b.Property<string>("SpotterName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("spotter_name");

                    b.Property<string>("SpotterPrefix")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("spotter_prefix");

                    b.Property<float>("band")
                        .HasColumnType("float");

                    b.Property<string>("call")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("varchar(12)");

                    b.Property<string>("comment")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("dxcall")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("varchar(12)");

                    b.Property<float>("freq")
                        .HasColumnType("float");

                    b.Property<DateTime>("time")
                        .HasColumnType("datetime(6)");

                    b.HasKey("nr");

                    b.HasIndex("band");

                    b.HasIndex("dxcall");

                    b.HasIndex("freq");

                    b.HasIndex("time", "band");

                    b.ToTable("Spots");
                });

            modelBuilder.Entity("W8ZJTcalllog.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Callsign")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("DefaultMode")
                        .HasMaxLength(4)
                        .HasColumnType("varchar(4)");

                    b.Property<int>("DefaultPower")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastWorkedMode")
                        .HasMaxLength(4)
                        .HasColumnType("varchar(4)");

                    b.Property<int>("LastWorkedPower")
                        .HasColumnType("int");

                    b.Property<string>("LogMode")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("NumberOfCallsToShow")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("PriviousCallsToShow")
                        .HasColumnType("int");

                    b.Property<int>("RecordCount")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Style")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<bool>("showAddressColumn")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("showNetColumn")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("W8ZJTcalllog.Models.HamLog", b =>
                {
                    b.HasOne("W8ZJTcalllog.Models.User", "User")
                        .WithMany("HamLogs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("W8ZJTcalllog.Models.User", b =>
                {
                    b.Navigation("HamLogs");
                });
#pragma warning restore 612, 618
        }
    }
}
